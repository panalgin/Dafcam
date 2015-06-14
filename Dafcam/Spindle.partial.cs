using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading;
using System.Windows.Forms;

namespace Dafcam
{
    public enum SpindleState
    {
        Idle = 0,
        EquippingTool = 1,
        UnequippingTool = 2
    }

    public enum EquipState
    {
        None = 0,
        InitialLift = 1,
        AboveTool = 2,
        ReadyToPick = 3,
        Finished = 4
    }

    public enum UnequipState
    {
        None = 0,
        InitialLift = 1,
        AboveSlot = 2,
        ReadyToDrop = 3,
        Finished = 4
    }

    public partial class Spindle
    {
        private SpindleState m_SpindleState = Dafcam.SpindleState.Idle;

        [NotMapped]
        public SpindleState SpindleState 
        {
            get { return m_SpindleState; }
            set
            {
                EventManager.InvokeSpindleStateChanged();
                m_SpindleState = value;
            }
        }

        [NotMapped]
        public EquipState EquipState { get; set; }

        [NotMapped]
        public UnequipState UnequipState { get; set; }

        public Spindle()
        {
            this.TargetRpm = 0;
        }

        public void Unequip()
        {
            if (this.CurrentBitID != null)
            {
                this.Stop();
                SpindleState = SpindleState.UnequippingTool;

                if (Core.Controller != null)
                {
                    UnequipState = Dafcam.UnequipState.InitialLift;
                    Core.Controller.Send("ResetZ=0;"); // first movement
                }
            }
        }

        private void SilentEquip(Bit bit)
        {
            while (true)
            {
                if (SpindleState == Dafcam.SpindleState.Idle)
                {
                    Equip(bit);
                    break;
                }

                Application.DoEvents();
            }
        }

        public void Equip(Bit bit)
        {
            if (Core.Spindle.CurrentBitID != null && Core.Spindle.CurrentBitID != bit.ID)
            {
                SpindleState = Dafcam.SpindleState.UnequippingTool;
                this.Unequip();

                ThreadStart m_Start = new ThreadStart(delegate() { SilentEquip(bit); });
                Thread m_Thread = new Thread(m_Start);
                m_Thread.Start();
            }

            else if (Core.Spindle.CurrentBitID == null)
            {
                this.Stop();
                SpindleState = SpindleState.EquippingTool;

                if (Core.Controller != null)
                {
                    this.TargetBit = bit;
                    this.TargetBitID = bit.ID;
                    EquipState = Dafcam.EquipState.InitialLift;


                    Core.Controller.Send("ResetZ=0;"); // first movement
                }
            }

        }

        public void Stop()
        {
            if (Core.Controller != null)
            {
                while (true)
                {
                    if (Core.Controller.DrillState == DrillState.Ready || Core.Controller.DrillState == DrillState.LiftFinished)
                    {
                        Thread.Sleep(500);
                        Core.Controller.Send("ToggleSpindle=OFF;");
                        Thread.Sleep(500);
                        break;
                    }

                    Application.DoEvents();
                }
            }
        }

        public void Run()
        {
            if (Core.Controller != null)
            {
                while (true)
                {
                    if (Core.Controller.DrillState == DrillState.Ready)
                    {

                        Core.Controller.Send("ToggleSpindle=ON;");
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
