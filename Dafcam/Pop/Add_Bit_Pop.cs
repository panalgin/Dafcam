using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Windows.Forms;
using System.Windows.Media.Media3D;

namespace Dafcam.Pop
{
    public partial class Add_Bit_Pop : Form
    {
        public Controller Controller { get; set; }
        private int m_LastHit = 0;

        public Add_Bit_Pop()
        {
            InitializeComponent();
        }

        private void AddNewDrillBit_Pop_Load(object sender, EventArgs e)
        {
            /*this.Controller = World.Items.Where(q => q is ControllerEx).FirstOrDefault() as ControllerEx;

            if (this.Controller == null)
            {
                MessageBox.Show("Kontrol kartı bulunamadı.");
            }
            else
            {
                EventManager.CurrentPositionChanged += EventManager_CurrentPositionChanged;
            }*/

            if (this.Controller == null)
            {
                using (DafcamEntities m_Context = new DafcamEntities())
                {
                    this.Controller = m_Context.Controllers.FirstOrDefault();

                    if (this.Controller == null)
                        MessageBox.Show("Bağlantı kurulamadı.");
                    else
                        EventManager.CurrentPositionChanged += EventManager_CurrentPositionChanged;
                }
            }
        }

        void EventManager_CurrentPositionChanged(Vector3D pos)
        {
            if (m_LastHit == 0)
            {
                this.Stall_X_Num.Value = Convert.ToDecimal(pos.X);
                this.Stall_Y_Num.Value = Convert.ToDecimal(pos.Y);
                this.Stall_Z_Num.Value = Convert.ToDecimal(pos.Z);
            }
            else
            {
                this.Drop_X_Num.Value = Convert.ToDecimal(pos.X);
                this.Drop_Y_Num.Value = Convert.ToDecimal(pos.Y);
                this.Drop_Z_Num.Value = Convert.ToDecimal(pos.Z);
                    
            }
        }

        private void Save_Button_Click(object sender, EventArgs e)
        {
            using (DafcamEntities m_Context = new DafcamEntities())
            {
                Bit m_Bit = new Bit();
                m_Bit.OuterDiameter = Convert.ToDouble(this.PointDiameter_Num.Value);
                m_Bit.ShaftDiameter = Convert.ToDouble(this.ShaftDiameter_Num.Value);
                m_Bit.StallsAt = new Vector3D(Convert.ToDouble(this.Stall_X_Num.Value), Convert.ToDouble(this.Stall_Y_Num.Value), Convert.ToDouble(this.Stall_Z_Num.Value));
                m_Bit.DropsAt = new Vector3D(Convert.ToDouble(this.Drop_X_Num.Value), Convert.ToDouble(this.Drop_Y_Num.Value), Convert.ToDouble(this.Drop_Z_Num.Value));
                m_Bit.Name = this.Name_Box.Text;
                m_Bit.Worktime = TimeSpan.MinValue.Ticks;
                m_Bit.Length = Convert.ToDouble(this.Length_Num.Value);

                m_Context.Bits.Add(m_Bit);
                m_Context.SaveChanges();
            }
            

            this.Close();
        }

        private void Cancel_Button_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Stall_GetCurrentPosition_Button_Click(object sender, EventArgs e)
        {
            m_LastHit = 0;
            this.Controller.Send("GetCurrentPosition;");
        }

        private void Drop_GetCurrentPosition_Button_Click(object sender, EventArgs e)
        {
            m_LastHit = 1;
            this.Controller.Send("GetCurrentPosition;");
        }
    }
}
