using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Dafcam.Pop;

namespace Dafcam
{
    public partial class ToolsForm : Form
    {
        public ToolsForm()
        {
            InitializeComponent();
        }

        private void Add_Button_Click(object sender, EventArgs e)
        {
            Add_Bit_Pop m_Pop = new Add_Bit_Pop();
            m_Pop.ShowDialog();
            //World.Save();

            Populate();
        }

        private void ToolsForm_Load(object sender, EventArgs e)
        {
            EventManager.SpindleToolChanged += EventManager_SpindleToolChanged;
            this.Populate();
        }

        void EventManager_SpindleToolChanged(Bit bit)
        {
            Populate();
        }

        private void Populate()
        {
            try
            {
                this.dataGridView1.DataSource = null;

                DafcamEntities m_Context = new DafcamEntities();
                var m_Bits = from bit in m_Context.Bits
                             select new
                             {
                                 ID = bit.ID,
                                 Ad = bit.Name,
                                 DisCap = bit.OuterDiameter,
                                 SaftCap = bit.ShaftDiameter,
                                 Uzunluk = bit.Length,
                                 DurmaPozisyonu = bit.IntStallsAt,
                                 BirakmaPozisyonu = bit.IntDropsAt
                             };

                this.dataGridView1.DataSource = m_Bits.ToList();
            }
            catch (Exception ex)
            {

            }
        }

        private void Equip_Button_Click(object sender, EventArgs e)
        {
            if (this.dataGridView1.SelectedRows.Count > 0)
            {
                int m_BitID = Convert.ToInt32(this.dataGridView1.SelectedRows[0].Cells[0].Value);

                if (m_BitID > 0)
                {
                    using (DafcamEntities m_Context = new DafcamEntities())
                    {
                        if (Core.Spindle != null)
                        {
                            Bit m_Bit = m_Context.Bits.Where(q => q.ID == m_BitID).FirstOrDefault();

                            if (m_Bit != null && Core.Spindle.CurrentBit != m_Bit)
                            {
                                Core.Spindle.Equip(m_Bit);
                            }
                        }
                    }
                }
            }
        }

        private void Delete_Button_Click(object sender, EventArgs e)
        {
            if (this.dataGridView1.SelectedRows.Count > 0)
            {
                int ID = Convert.ToInt32(this.dataGridView1.SelectedRows[0].Cells["ID"].Value.ToString());

                if (ID > 0)
                {
                    using(DafcamEntities m_Context = new DafcamEntities())
                    {
                        Bit m_Bit = m_Context.Bits.Where(q => q.ID == ID).FirstOrDefault();

                        if (m_Bit != null)
                        {
                            m_Context.Bits.Remove(m_Bit);
                            m_Context.SaveChanges();
                            this.Populate();
                        }
                    }
                }
            }
        }

        private void Unequip_Button_Click(object sender, EventArgs e)
        {
            using (DafcamEntities m_Context = new DafcamEntities())
            {

                Spindle m_Spindle = m_Context.Spindles.FirstOrDefault();
                if (m_Spindle != null && m_Spindle.CurrentBitID != null)
                    m_Spindle.Unequip();
            }
        }

        private void Edit_Button_Click(object sender, EventArgs e)
        {
            if (this.dataGridView1.SelectedRows.Count > 0)
            {
                int ID = Convert.ToInt32(this.dataGridView1.SelectedRows[0].Cells[0].Value.ToString());

                if (ID > 0)
                {
                    Edit_Bit_Pop m_Pop = new Edit_Bit_Pop();
                    m_Pop.BitID = ID;
                    m_Pop.ShowDialog();
                }
            }
        }
    }
}