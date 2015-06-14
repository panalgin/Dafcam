﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Dafcam.Pop
{
    public partial class Edit_Motor_Pop : Form
    {
        public int MotorID { get; set; }

        public Edit_Motor_Pop()
        {
            InitializeComponent();
        }

        private void Edit_Motor_Pop_Load(object sender, EventArgs e)
        {
            using (DafcamEntities m_Context = new DafcamEntities())
            {
                var m_Axes = m_Context.Axes.ToList();
                this.Axes_Combo.DataSource = m_Axes;
                this.Axes_Combo.ValueMember = "ID";
                this.Axes_Combo.DisplayMember = "Name";

                Motor m_Motor = m_Context.Motors.Where(q => q.ID == this.MotorID).FirstOrDefault();
                
                if (m_Motor != null)
                {
                    this.Name_Box.Text = m_Motor.Name;
                    this.Axes_Combo.SelectedValue = m_Motor.AxisID;
                    this.MaxRpm_Num.Value = m_Motor.MaxRpm;
                    this.DwellRpm_Num.Value = m_Motor.DwellRpm;
                    this.UseRamp_Check.Checked = m_Motor.UseRamping;
                    this.AccelerationStartsAt_Num.Value = m_Motor.AccelerationStartsAt;
                    this.ShortDistance_Num.Value = Units.StepsToMilimeter(m_Motor.ShortDistance);
                }
            }
        }

        private void Save_Button_Click(object sender, EventArgs e)
        {
            using (DafcamEntities m_Context = new DafcamEntities())
            {
                Motor m_Motor = m_Context.Motors.Where(q => q.ID == this.MotorID).FirstOrDefault();

                if (m_Motor != null)
                {
                    m_Motor.Name = this.Name_Box.Text;
                    m_Motor.AxisID = Convert.ToInt32(this.Axes_Combo.SelectedValue);
                    m_Motor.MaxRpm = Convert.ToInt32(this.MaxRpm_Num.Value);
                    m_Motor.DwellRpm = Convert.ToInt32(this.DwellRpm_Num.Value);
                    m_Motor.UseRamping = this.UseRamp_Check.Checked;
                    m_Motor.AccelerationStartsAt = Convert.ToInt32(this.AccelerationStartsAt_Num.Value);
                    m_Motor.ShortDistance = Units.MillimeterToSteps(this.ShortDistance_Num.Value);

                    m_Context.SaveChanges();
                }
            }

            this.Close();
        }
    }
}
