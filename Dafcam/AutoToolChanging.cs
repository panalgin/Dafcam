using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;

namespace Dafcam
{
    public static class AutoToolChanging
    {
        public static void Initialize()
        {
            EventManager.JogFinished += EventManager_JogFinished;
            EventManager.ResetFinished += EventManager_ResetFinished;
        }
        static void EventManager_JogFinished()
        {
            if (Core.Spindle.SpindleState == SpindleState.EquippingTool)
            {
                switch (Core.Spindle.EquipState)
                {
                    case EquipState.InitialLift: // in initallift mode, our jog finished ready to delve
                        {
                            Core.Spindle.EquipState = Dafcam.EquipState.AboveTool;

                            using (DafcamEntities m_Context = new DafcamEntities())
                            {
                                Bit m_TargetBit = m_Context.Bits.Where(q => q.ID == Core.Spindle.TargetBitID.Value).FirstOrDefault();

                                Core.Controller.Send(string.Format("ResetZ={0};", m_TargetBit.StallsAt.Z.ToString()));
                            }

                            break;
                        }
                }
            }

            else if (Core.Spindle.SpindleState == Dafcam.SpindleState.UnequippingTool)
            {
                switch (Core.Spindle.UnequipState)
                {
                    case Dafcam.UnequipState.InitialLift:
                        {
                            Core.Spindle.UnequipState = Dafcam.UnequipState.AboveSlot;
                            Thread.Sleep(200);

                            using (DafcamEntities m_Context = new DafcamEntities())
                            {
                                Bit m_CurrentBit = m_Context.Bits.Where(q => q.ID == Core.Spindle.CurrentBitID.Value).FirstOrDefault();

                                Core.Controller.Send(string.Format("ResetZ={0};", m_CurrentBit.DropsAt.Z.ToString()));
                            }

                            break;
                        }
                }
            }
        }

        static void EventManager_ResetFinished()
        {
            if (Core.Spindle.SpindleState == SpindleState.EquippingTool)
            {
                switch (Core.Spindle.EquipState)
                {
                    case Dafcam.EquipState.InitialLift:
                        {
                            Thread.Sleep(100);


                            Core.Controller.Send(string.Format("Equip={0}:{1};", Core.Spindle.TargetBit.StallsAt.X.ToString(), Core.Spindle.TargetBit.StallsAt.Y.ToString()));
                            break;
                        }

                    case Dafcam.EquipState.AboveTool:
                        {
                            //now we are really on tool
                            Core.Spindle.EquipState = Dafcam.EquipState.ReadyToPick;
                            Core.Spindle.CurrentBit = Core.Spindle.TargetBit;
                            Core.Spindle.CurrentBitID = Core.Spindle.TargetBitID;
                            //this.CurrentBit.Equipped = true;

                            Core.Controller.Send("ResetZ=0;");

                            Core.Spindle.CurrentBitID = Core.Spindle.TargetBitID;
                            Core.Spindle.TargetBitID = null;
                            Core.Spindle.TargetBit = null;

                            using (DafcamEntities m_Context = new DafcamEntities())
                            {
                                Spindle m_Temp = m_Context.Spindles.FirstOrDefault();
                                m_Temp.TargetBitID = Core.Spindle.TargetBitID;
                                m_Temp.CurrentBitID = Core.Spindle.CurrentBitID;

                                m_Context.SaveChanges();
                            }



                            break;
                        }

                    case Dafcam.EquipState.ReadyToPick:
                        {
                            //picked it up
                            Core.Spindle.EquipState = Dafcam.EquipState.Finished;
                            Core.Spindle.EquipState = Dafcam.EquipState.None;
                            Core.Spindle.SpindleState = Dafcam.SpindleState.Idle;
                            EventManager.InvokeSpindleToolChanged(Core.Spindle.CurrentBit);

                            break;
                        }
                }

            }
            else if (Core.Spindle.SpindleState == Dafcam.SpindleState.UnequippingTool)
            {
                switch (Core.Spindle.UnequipState)
                {
                    case Dafcam.UnequipState.InitialLift:
                        {
                            using (DafcamEntities m_Context = new DafcamEntities())
                            {
                                Bit m_Bit = m_Context.Bits.Where(q => q.ID == Core.Spindle.CurrentBitID).FirstOrDefault();
                                Core.Controller.Send(string.Format("Equip={0}:{1};", m_Bit.DropsAt.X.ToString(), m_Bit.DropsAt.Y.ToString()));
                            }
                            break;
                        }

                    case Dafcam.UnequipState.AboveSlot:
                        {
                            //now we are really on slot
                            Core.Spindle.UnequipState = Dafcam.UnequipState.ReadyToDrop;
                            Core.Controller.Send("ToggleCoil=ON;");
                            Thread.Sleep(1500);
                            //this.CurrentBit.Equipped = false;
                            Core.Controller.Send("ResetZ=0;");


                            Core.Spindle.CurrentBitID = null;
                            Core.Spindle.TargetBitID = null;
                            Core.Spindle.CurrentBit = null;
                            Core.Spindle.TargetBit = null;


                            using (DafcamEntities m_Context = new DafcamEntities())
                            {
                                Spindle m_Temp = m_Context.Spindles.FirstOrDefault();
                                m_Temp.TargetBitID = Core.Spindle.TargetBitID;
                                m_Temp.CurrentBitID = Core.Spindle.CurrentBitID;

                                m_Context.SaveChanges();
                            }


                            break;
                        }

                    case Dafcam.UnequipState.ReadyToDrop:
                        {
                            //dropped it
                            Core.Spindle.UnequipState = Dafcam.UnequipState.Finished;
                            Core.Spindle.UnequipState = Dafcam.UnequipState.None;
                            Core.Spindle.SpindleState = Dafcam.SpindleState.Idle;
                            EventManager.InvokeSpindleToolChanged(Core.Spindle.CurrentBit);


                            break;
                        }
                }
            }
        }
    }
}
