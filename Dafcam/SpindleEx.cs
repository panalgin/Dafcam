using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Windows.Forms;

namespace CncDrill
{
    public enum SpindleState
    {
        Idle,
        EquippingTool,
        UnequippingTool
    }

    public enum EquipState
    {
        None,
        InitialLift,
        AboveTool,
        ReadyToPick,
        Finished
    }

    public enum UnequipState
    {
        None,
        InitialLift,
        AboveSlot,
        ReadyToDrop,
        Finished
    }

    [Serializable]
    public class Spindle : Item
    {
        public SpindleState SpindleState { get; set; }
        public EquipState EquipState { get; set; }
        public UnequipState UnequipState { get; set; }
        public Controller Controller { get; set; }
        public DrillBit CurrentTool { get; set; }
        public DrillBit ToolBeingEquipped { get; set; }

        public Spindle()
        {
            EventManager.ResetFinished += EventManager_ResetFinished;
            EventManager.JogFinished += EventManager_JogFinished;
        }

        void EventManager_JogFinished()
        {
            if (this.SpindleState == SpindleState.EquippingTool)
            {
                switch (this.EquipState)
                {
                    case CncDrill.EquipState.InitialLift: // in initallift mode, our jog finished ready to delve
                        {
                            this.EquipState = CncDrill.EquipState.AboveTool;
                            this.Controller.Send(string.Format("ResetZ={0};", this.ToolBeingEquipped.StallsAt.Z.ToString()));
                            break;
                        }
                }
            }

            else if(this.SpindleState == CncDrill.SpindleState.UnequippingTool)
            {
                switch (this.UnequipState)
                {
                    case CncDrill.UnequipState.InitialLift:
                        {
                            this.UnequipState = CncDrill.UnequipState.AboveSlot;
                            Thread.Sleep(200);
                            this.Controller.Send(string.Format("ResetZ={0};", (this.CurrentTool.StallsAt.Z - this.CurrentTool.DropHeight).ToString()));
                            break;
                        }
                }
            }
        }

        void EventManager_ResetFinished()
        {
            if (this.SpindleState == SpindleState.EquippingTool)
            {
                switch (this.EquipState)
                {
                    case CncDrill.EquipState.InitialLift:
                        {
                            Thread.Sleep(100);

                            this.Controller.Send(string.Format("Equip={0}:{1};", this.ToolBeingEquipped.StallsAt.X.ToString(), this.ToolBeingEquipped.StallsAt.Y.ToString()));
                            break;
                        }

                    case CncDrill.EquipState.AboveTool:
                        {
                            //now we are really on tool
                            this.EquipState = CncDrill.EquipState.ReadyToPick;
                            this.CurrentTool = this.ToolBeingEquipped;
                            this.CurrentTool.Equipped = true;
                            this.Controller.Send("ResetZ=0;");
                            

                            break;
                        }

                    case CncDrill.EquipState.ReadyToPick:
                        {
                            //picked it up
                            this.EquipState = CncDrill.EquipState.Finished;
                            this.EquipState = CncDrill.EquipState.None;
                            this.SpindleState = CncDrill.SpindleState.Idle;
                            this.ToolBeingEquipped = null;
                            EventManager.InvokeSpindleToolChanged(this.CurrentTool);
                            World.Save();
                            break;
                        }
                }

            }
            else if (this.SpindleState == CncDrill.SpindleState.UnequippingTool)
            {
                switch (this.UnequipState)
                {
                    case CncDrill.UnequipState.InitialLift:
                        {
                            this.Controller.Send(string.Format("Equip={0}:{1};", this.CurrentTool.StallsAt.X.ToString(), this.CurrentTool.StallsAt.Y.ToString()));
                            break;
                        }

                    case CncDrill.UnequipState.AboveSlot:
                        {
                            //now we are really on slot
                            this.UnequipState = CncDrill.UnequipState.ReadyToDrop;
                            this.Controller.Send("ToggleCoil=ON;");
                            Thread.Sleep(1500);
                            this.CurrentTool.Equipped = false;
                            this.CurrentTool = null;
                            this.Controller.Send("ResetZ=0;");


                            break;
                        }

                    case CncDrill.UnequipState.ReadyToDrop:
                        {
                            //dropped it
                            this.UnequipState = CncDrill.UnequipState.Finished;
                            this.UnequipState = CncDrill.UnequipState.None;
                            this.SpindleState = CncDrill.SpindleState.Idle;
                            EventManager.InvokeSpindleToolChanged(this.CurrentTool);
                            World.Save();
                            break;
                        }
                }
            }
        }

        public void Unequip()
        {
            if (this.CurrentTool != null)
            {
                this.Controller = World.Items.Where(q => q is Controller).FirstOrDefault() as Controller;

                this.Stop();
                this.SpindleState = SpindleState.UnequippingTool;

                EventManager.JogFinished -= EventManager_JogFinished;
                EventManager.ResetFinished -= EventManager_ResetFinished;

                EventManager.JogFinished += EventManager_JogFinished;
                EventManager.ResetFinished += EventManager_ResetFinished;

                if (this.Controller != null)
                {
                    this.UnequipState = CncDrill.UnequipState.InitialLift;
                    this.Controller.Send("ResetZ=0;"); // first movement
                }
            }
        }

        private void SilentEquip(DrillBit bit)
        {
            while (true)
            {
                if (this.SpindleState == CncDrill.SpindleState.Idle)
                {
                    Equip(bit);
                    break;
                }

                Application.DoEvents();
            }
        }

        public void Equip(DrillBit bit)
        {
            if (this.CurrentTool != null && this.CurrentTool != bit)
            {
                this.SpindleState = CncDrill.SpindleState.UnequippingTool;
                this.Unequip();

                ThreadStart m_Start = new ThreadStart(delegate() { SilentEquip(bit); });
                Thread m_Thread = new Thread(m_Start);
                m_Thread.Start();
            }

            else if (this.CurrentTool == null)
            {
                this.Controller = World.Items.Where(q => q is Controller).FirstOrDefault() as Controller;
                this.Stop();
                this.SpindleState = SpindleState.EquippingTool;

                EventManager.JogFinished -= EventManager_JogFinished;
                EventManager.ResetFinished -= EventManager_ResetFinished;

                EventManager.JogFinished += EventManager_JogFinished;
                EventManager.ResetFinished += EventManager_ResetFinished;

                if (this.Controller != null)
                {
                    this.ToolBeingEquipped = bit;
                    this.EquipState = CncDrill.EquipState.InitialLift;
                    this.Controller.Send("ResetZ=0;"); // first movement
                }
            }

        }

        public void Stop()
        {
            if (this.Controller != null)
            {
                while (true)
                {
                    if (this.Controller.DrillState == DrillState.Ready || this.Controller.DrillState == DrillState.LiftFinished)
                    {
                        Thread.Sleep(500);
                        this.Controller.Send("ToggleSpindle=OFF;");
                        Thread.Sleep(500);
                        break;
                    }

                    Application.DoEvents();
                }
            }
        }

        public void Run()
        {
            if (this.Controller != null)
            {
                while (true)
                {
                    if (this.Controller.DrillState == DrillState.Ready)
                    {
                        
                        this.Controller.Send("ToggleSpindle=ON;");
                        Thread.Sleep(500);
                        /*this.Controller.Send("ToggleValve=ON;");*/
                        Thread.Sleep(500);
                        break;
                    }

                    Application.DoEvents();
                }
            }
        }
    }
}
