using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq.Expressions;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Dafcam.Pop;

namespace Dafcam
{
    public partial class MotorsForm : Form
    {
        public MotorsForm()
        {
            InitializeComponent();
        }

        private void MotorsForm_Load(object sender, EventArgs e)
        {
            Populate();
        }

        private void Delete_Button_Click(object sender, EventArgs e)
        {
            if (this.dataGridView1.SelectedRows.Count > 0)
            {
                int ID = Convert.ToInt32(this.dataGridView1.SelectedRows[0].Cells["ID"].Value);

                if (ID > 0)
                {
                    using (DafcamEntities m_Context = new DafcamEntities())
                    {
                        Motor m_Motor = m_Context.Motors.Where(q => q.ID == ID).FirstOrDefault();

                        m_Context.Motors.Remove(m_Motor);
                        m_Context.SaveChanges();
                        Populate();
                    }
                }
            }
        }

        private void Populate()
        {
            this.dataGridView1.DataSource = null;

            DafcamEntities m_Context = new DafcamEntities();


            var m_Motors = from motor in m_Context.Motors
                           select new
                           {
                               ID = motor.ID,
                               Ad = motor.Name,
                               Eksen = motor.Axis.Name,
                               MaxRpm = motor.MaxRpm,
                               Ivme = motor.UseRamping
                           };

            this.dataGridView1.DataSource = m_Motors.ToList();
            this.dataGridView1.Columns[0].Width = 30;
            this.dataGridView1.Columns[0].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            this.dataGridView1.Columns[0].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
        }

        private void Add_Button_Click(object sender, EventArgs e)
        {
            Add_Motor_Pop m_Pop = new Add_Motor_Pop();
            m_Pop.ShowDialog();
            Populate();
        }

        private void Edit_Button_Click(object sender, EventArgs e)
        {
            if (this.dataGridView1.SelectedRows.Count > 0)
            {
                int ID = Convert.ToInt32(this.dataGridView1.SelectedRows[0].Cells["ID"].Value);

                if (ID > 0)
                {
                    Edit_Motor_Pop m_Pop = new Edit_Motor_Pop();
                    m_Pop.MotorID = ID;
                    m_Pop.ShowDialog();
                    Populate();
                    Core.ApplySettings();
                }
            }
        }
    }
}
