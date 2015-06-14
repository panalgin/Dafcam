namespace Dafcam
{
    partial class SettingsForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.ZDrillRpmNum = new System.Windows.Forms.NumericUpDown();
            this.ZLiftRpmNum = new System.Windows.Forms.NumericUpDown();
            this.ZDrillRampableCheck = new System.Windows.Forms.CheckBox();
            this.ZLiftRampableCheck = new System.Windows.Forms.CheckBox();
            this.label18 = new System.Windows.Forms.Label();
            this.label19 = new System.Windows.Forms.Label();
            this.Save_Button = new System.Windows.Forms.Button();
            this.Cancel_Button = new System.Windows.Forms.Button();
            this.label21 = new System.Windows.Forms.Label();
            this.label22 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.ZDrillRpmNum)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ZLiftRpmNum)).BeginInit();
            this.SuspendLayout();
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(34, 14);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(78, 13);
            this.label6.TabIndex = 5;
            this.label6.Text = "Z Dalma Devir:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(18, 40);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(94, 13);
            this.label7.TabIndex = 6;
            this.label7.Text = "Z Yükselme Devir:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(23, 65);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(89, 13);
            this.label8.TabIndex = 7;
            this.label8.Text = "Z Dalarken İvme:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(11, 88);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(101, 13);
            this.label9.TabIndex = 8;
            this.label9.Text = "Z Yükselirken İvme:";
            // 
            // ZDrillRpmNum
            // 
            this.ZDrillRpmNum.Location = new System.Drawing.Point(118, 12);
            this.ZDrillRpmNum.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.ZDrillRpmNum.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.ZDrillRpmNum.Name = "ZDrillRpmNum";
            this.ZDrillRpmNum.Size = new System.Drawing.Size(120, 20);
            this.ZDrillRpmNum.TabIndex = 5;
            this.ZDrillRpmNum.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // ZLiftRpmNum
            // 
            this.ZLiftRpmNum.Location = new System.Drawing.Point(118, 38);
            this.ZLiftRpmNum.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.ZLiftRpmNum.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.ZLiftRpmNum.Name = "ZLiftRpmNum";
            this.ZLiftRpmNum.Size = new System.Drawing.Size(120, 20);
            this.ZLiftRpmNum.TabIndex = 6;
            this.ZLiftRpmNum.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // ZDrillRampableCheck
            // 
            this.ZDrillRampableCheck.AutoSize = true;
            this.ZDrillRampableCheck.Location = new System.Drawing.Point(118, 64);
            this.ZDrillRampableCheck.Name = "ZDrillRampableCheck";
            this.ZDrillRampableCheck.Size = new System.Drawing.Size(59, 17);
            this.ZDrillRampableCheck.TabIndex = 7;
            this.ZDrillRampableCheck.Text = "Uygula";
            this.ZDrillRampableCheck.UseVisualStyleBackColor = true;
            // 
            // ZLiftRampableCheck
            // 
            this.ZLiftRampableCheck.AutoSize = true;
            this.ZLiftRampableCheck.Location = new System.Drawing.Point(118, 87);
            this.ZLiftRampableCheck.Name = "ZLiftRampableCheck";
            this.ZLiftRampableCheck.Size = new System.Drawing.Size(59, 17);
            this.ZLiftRampableCheck.TabIndex = 8;
            this.ZLiftRampableCheck.Text = "Uygula";
            this.ZLiftRampableCheck.UseVisualStyleBackColor = true;
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.BackColor = System.Drawing.SystemColors.Window;
            this.label18.Location = new System.Drawing.Point(193, 15);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(24, 13);
            this.label18.TabIndex = 28;
            this.label18.Text = "rpm";
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.BackColor = System.Drawing.SystemColors.Window;
            this.label19.Location = new System.Drawing.Point(193, 41);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(24, 13);
            this.label19.TabIndex = 29;
            this.label19.Text = "rpm";
            // 
            // Save_Button
            // 
            this.Save_Button.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.Save_Button.Location = new System.Drawing.Point(88, 203);
            this.Save_Button.Name = "Save_Button";
            this.Save_Button.Size = new System.Drawing.Size(75, 23);
            this.Save_Button.TabIndex = 11;
            this.Save_Button.Text = "Kaydet";
            this.Save_Button.UseVisualStyleBackColor = true;
            this.Save_Button.Click += new System.EventHandler(this.Save_Button_Click);
            // 
            // Cancel_Button
            // 
            this.Cancel_Button.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.Cancel_Button.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.Cancel_Button.Location = new System.Drawing.Point(169, 203);
            this.Cancel_Button.Name = "Cancel_Button";
            this.Cancel_Button.Size = new System.Drawing.Size(75, 23);
            this.Cancel_Button.TabIndex = 12;
            this.Cancel_Button.Text = "İptal";
            this.Cancel_Button.UseVisualStyleBackColor = true;
            this.Cancel_Button.Click += new System.EventHandler(this.Cancel_Button_Click);
            // 
            // label21
            // 
            this.label21.AutoSize = true;
            this.label21.Location = new System.Drawing.Point(148, 133);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(90, 13);
            this.label21.TabIndex = 32;
            this.label21.Text = "1mm = 1250 adım";
            // 
            // label22
            // 
            this.label22.AutoSize = true;
            this.label22.Location = new System.Drawing.Point(148, 150);
            this.label22.Name = "label22";
            this.label22.Size = new System.Drawing.Size(94, 13);
            this.label22.TabIndex = 33;
            this.label22.Text = "1cm = 12500 adım";
            // 
            // SettingsForm
            // 
            this.AcceptButton = this.Save_Button;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.Cancel_Button;
            this.ClientSize = new System.Drawing.Size(256, 238);
            this.Controls.Add(this.label22);
            this.Controls.Add(this.label21);
            this.Controls.Add(this.Cancel_Button);
            this.Controls.Add(this.Save_Button);
            this.Controls.Add(this.label19);
            this.Controls.Add(this.label18);
            this.Controls.Add(this.ZLiftRampableCheck);
            this.Controls.Add(this.ZDrillRampableCheck);
            this.Controls.Add(this.ZLiftRpmNum);
            this.Controls.Add(this.ZDrillRpmNum);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "SettingsForm";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Ayarlar";
            this.Load += new System.EventHandler(this.SettingsForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.ZDrillRpmNum)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ZLiftRpmNum)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.NumericUpDown ZDrillRpmNum;
        private System.Windows.Forms.NumericUpDown ZLiftRpmNum;
        private System.Windows.Forms.CheckBox ZDrillRampableCheck;
        private System.Windows.Forms.CheckBox ZLiftRampableCheck;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.Button Save_Button;
        private System.Windows.Forms.Button Cancel_Button;
        private System.Windows.Forms.Label label21;
        private System.Windows.Forms.Label label22;
    }
}