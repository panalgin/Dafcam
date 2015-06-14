using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Dafcam.Properties;

namespace Dafcam
{
    public partial class SettingsForm : Form
    {
        public delegate void OnSettingsChanged();
        public event OnSettingsChanged SettingsChanged;

        public SettingsForm()
        {
            InitializeComponent();
        }

        private void SettingsForm_Load(object sender, EventArgs e)
        {
           

            this.ZDrillRpmNum.Value = Settings.Default.ZDrillRpm;
            this.ZLiftRpmNum.Value = Settings.Default.ZLiftRpm;

            this.ZDrillRampableCheck.Checked = Settings.Default.ZDrillRampable;
            this.ZLiftRampableCheck.Checked = Settings.Default.ZLiftRampable;

        }

        private void Save_Button_Click(object sender, EventArgs e)
        {
            Settings.Default.ZDrillRpm = Convert.ToInt32(this.ZDrillRpmNum.Value);
            Settings.Default.ZLiftRpm = Convert.ToInt32(this.ZLiftRpmNum.Value);

            Settings.Default.ZDrillRampable = this.ZDrillRampableCheck.Checked;
            Settings.Default.ZLiftRampable = this.ZLiftRampableCheck.Checked;

            Settings.Default.Save();

            if (this.SettingsChanged != null)
                this.SettingsChanged();

            this.Close();
        }

        private void Cancel_Button_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
