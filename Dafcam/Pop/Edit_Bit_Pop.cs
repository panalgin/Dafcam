using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Windows.Media.Media3D;

namespace Dafcam.Pop
{
    public partial class Edit_Bit_Pop : Form
    {
        private Controller Controller = null;

        public int BitID { get; set; }

        public Edit_Bit_Pop()
        {
            InitializeComponent();
        }

        private void EditDrillBit_Pop_Load(object sender, EventArgs e)
        {

            if (BitID > 0)
            {
                using (DafcamEntities m_Context = new DafcamEntities())
                {
                    Bit m_Bit = m_Context.Bits.Where(q => q.ID == this.BitID).FirstOrDefault();

                    if (m_Bit != null)
                    {
                        this.Name_Box.Text = m_Bit.Name;
                        this.ShaftDiameter_Num.Value = Convert.ToDecimal(m_Bit.ShaftDiameter);
                        this.PointDiameter_Num.Value = Convert.ToDecimal(m_Bit.OuterDiameter);
                        this.Length_Num.Value = Convert.ToDecimal(m_Bit.Length);

                        this.Stall_X_Num.Value = Convert.ToDecimal(m_Bit.StallsAt.X);
                        this.Stall_Y_Num.Value = Convert.ToDecimal(m_Bit.StallsAt.Y);
                        this.Stall_Z_Num.Value = Convert.ToDecimal(m_Bit.StallsAt.Z);

                        this.Drop_X_Num.Value = Convert.ToDecimal(m_Bit.DropsAt.X);
                        this.Drop_Y_Num.Value = Convert.ToDecimal(m_Bit.DropsAt.Y);
                        this.Drop_Z_Num.Value = Convert.ToDecimal(m_Bit.DropsAt.Z);

                    }
                }
            }
            /*this.Controller = World.Items.Where(q => q is ControllerEx).FirstOrDefault() as ControllerEx;

            if (this.Controller == null)
            {
                MessageBox.Show("Kontrol kartı bulunamadı.");
            }
            else
            {
                EventManager.CurrentPositionChanged += EventManager_CurrentPositionChanged;

                if (this.Bit != null)
                {
                    this.Diameter_Num.Value = Convert.ToDecimal(this.Bit.Diameter);
                    this.X_Num.Value = Convert.ToDecimal(this.Bit.StallsAt.X);
                    this.Y_Num.Value = Convert.ToDecimal(this.Bit.StallsAt.Y);
                    this.Z_Num.Value = Convert.ToDecimal(this.Bit.StallsAt.Z);
                    this.DropAbove_Num.Value = Units.StepsToMilimeter(this.Bit.DropHeight);
                }
            }*/
        }

        void EventManager_CurrentPositionChanged(Vector3D pos)
        {
            //this.X_Num.Value = Convert.ToDecimal(pos.X);
            //this.Y_Num.Value = Convert.ToDecimal(pos.Y);
            //this.Z_Num.Value = Convert.ToDecimal(pos.Z);
        }

        private void Save_Button_Click(object sender, EventArgs e)
        {
            if (this.BitID > 0)
            {
                using (DafcamEntities m_Context = new DafcamEntities())
                {
                    Bit m_Bit = m_Context.Bits.Where(q => q.ID == this.BitID).FirstOrDefault();

                    if (m_Bit != null)
                    {
                        m_Bit.Name = this.Name_Box.Text;
                        m_Bit.Length = Convert.ToDouble(this.Length_Num.Value);
                        m_Bit.OuterDiameter = Convert.ToDouble(this.PointDiameter_Num.Value);
                        m_Bit.ShaftDiameter = Convert.ToDouble(this.ShaftDiameter_Num.Value);
                        m_Bit.StallsAt = new Vector3D(Convert.ToDouble(this.Stall_X_Num.Value), Convert.ToDouble(this.Stall_Y_Num.Value), Convert.ToDouble(this.Stall_Z_Num.Value));
                        m_Bit.DropsAt = new Vector3D(Convert.ToDouble(this.Drop_X_Num.Value), Convert.ToDouble(this.Drop_Y_Num.Value), Convert.ToDouble(this.Drop_Z_Num.Value));

                        m_Context.SaveChanges();
                    }
                }
            }


            this.Close();
        }

        private void Cancel_Button_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void GetCurrentPosition_Button_Click(object sender, EventArgs e)
        {
            this.Controller.Send("GetCurrentPosition;");
        }
    }
}
