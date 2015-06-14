namespace Dafcam.Pop
{
    partial class Edit_Motor_Pop
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
            this.label1 = new System.Windows.Forms.Label();
            this.Name_Box = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.Axes_Combo = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.MaxRpm_Num = new System.Windows.Forms.NumericUpDown();
            this.DwellRpm_Num = new System.Windows.Forms.NumericUpDown();
            this.AccelerationStartsAt_Num = new System.Windows.Forms.NumericUpDown();
            this.ShortDistance_Num = new System.Windows.Forms.NumericUpDown();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label11 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.UseRamp_Check = new System.Windows.Forms.CheckBox();
            this.label7 = new System.Windows.Forms.Label();
            this.Save_Button = new System.Windows.Forms.Button();
            this.Cancel_Button = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.MaxRpm_Num)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DwellRpm_Num)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.AccelerationStartsAt_Num)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ShortDistance_Num)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(86, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(23, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Ad:";
            // 
            // Name_Box
            // 
            this.Name_Box.Location = new System.Drawing.Point(115, 19);
            this.Name_Box.Name = "Name_Box";
            this.Name_Box.Size = new System.Drawing.Size(121, 20);
            this.Name_Box.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(69, 48);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(40, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Eksen:";
            // 
            // Axes_Combo
            // 
            this.Axes_Combo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.Axes_Combo.FormattingEnabled = true;
            this.Axes_Combo.Location = new System.Drawing.Point(115, 45);
            this.Axes_Combo.Name = "Axes_Combo";
            this.Axes_Combo.Size = new System.Drawing.Size(121, 21);
            this.Axes_Combo.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(27, 74);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(82, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Maximum Devir:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(29, 96);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(80, 13);
            this.label4.TabIndex = 5;
            this.label4.Text = "Sürünme Devri:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(20, 44);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(89, 13);
            this.label5.TabIndex = 6;
            this.label5.Text = "İvmelenme Devri:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(41, 70);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(68, 13);
            this.label6.TabIndex = 7;
            this.label6.Text = "Kısa Mesafe:";
            // 
            // MaxRpm_Num
            // 
            this.MaxRpm_Num.Location = new System.Drawing.Point(115, 72);
            this.MaxRpm_Num.Maximum = new decimal(new int[] {
            100000,
            0,
            0,
            0});
            this.MaxRpm_Num.Name = "MaxRpm_Num";
            this.MaxRpm_Num.Size = new System.Drawing.Size(121, 20);
            this.MaxRpm_Num.TabIndex = 8;
            // 
            // DwellRpm_Num
            // 
            this.DwellRpm_Num.Location = new System.Drawing.Point(115, 94);
            this.DwellRpm_Num.Maximum = new decimal(new int[] {
            100000,
            0,
            0,
            0});
            this.DwellRpm_Num.Name = "DwellRpm_Num";
            this.DwellRpm_Num.Size = new System.Drawing.Size(121, 20);
            this.DwellRpm_Num.TabIndex = 9;
            // 
            // AccelerationStartsAt_Num
            // 
            this.AccelerationStartsAt_Num.Location = new System.Drawing.Point(115, 42);
            this.AccelerationStartsAt_Num.Maximum = new decimal(new int[] {
            100000,
            0,
            0,
            0});
            this.AccelerationStartsAt_Num.Name = "AccelerationStartsAt_Num";
            this.AccelerationStartsAt_Num.Size = new System.Drawing.Size(121, 20);
            this.AccelerationStartsAt_Num.TabIndex = 10;
            // 
            // ShortDistance_Num
            // 
            this.ShortDistance_Num.DecimalPlaces = 2;
            this.ShortDistance_Num.Location = new System.Drawing.Point(115, 68);
            this.ShortDistance_Num.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.ShortDistance_Num.Name = "ShortDistance_Num";
            this.ShortDistance_Num.Size = new System.Drawing.Size(121, 20);
            this.ShortDistance_Num.TabIndex = 11;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label11);
            this.groupBox1.Controls.Add(this.Name_Box);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.Axes_Combo);
            this.groupBox1.Controls.Add(this.MaxRpm_Num);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Location = new System.Drawing.Point(12, 9);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(242, 107);
            this.groupBox1.TabIndex = 12;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Motor Bilgileri";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.BackColor = System.Drawing.SystemColors.Window;
            this.label11.Location = new System.Drawing.Point(191, 75);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(24, 13);
            this.label11.TabIndex = 17;
            this.label11.Text = "rpm";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label10);
            this.groupBox2.Controls.Add(this.label9);
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Controls.Add(this.UseRamp_Check);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.DwellRpm_Num);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.ShortDistance_Num);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.AccelerationStartsAt_Num);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Location = new System.Drawing.Point(12, 122);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(242, 132);
            this.groupBox2.TabIndex = 13;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "İvmelenme Bilgileri";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.BackColor = System.Drawing.SystemColors.Window;
            this.label10.Location = new System.Drawing.Point(191, 97);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(24, 13);
            this.label10.TabIndex = 16;
            this.label10.Text = "rpm";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.BackColor = System.Drawing.SystemColors.Window;
            this.label9.Location = new System.Drawing.Point(191, 46);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(24, 13);
            this.label9.TabIndex = 15;
            this.label9.Text = "rpm";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.SystemColors.Window;
            this.label8.Location = new System.Drawing.Point(192, 71);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(23, 13);
            this.label8.TabIndex = 14;
            this.label8.Text = "mm";
            // 
            // UseRamp_Check
            // 
            this.UseRamp_Check.AutoSize = true;
            this.UseRamp_Check.Location = new System.Drawing.Point(115, 19);
            this.UseRamp_Check.Name = "UseRamp_Check";
            this.UseRamp_Check.Size = new System.Drawing.Size(47, 17);
            this.UseRamp_Check.TabIndex = 13;
            this.UseRamp_Check.Text = "Aktif";
            this.UseRamp_Check.UseVisualStyleBackColor = true;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(48, 20);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(61, 13);
            this.label7.TabIndex = 12;
            this.label7.Text = "İvmelenme:";
            // 
            // Save_Button
            // 
            this.Save_Button.Location = new System.Drawing.Point(98, 271);
            this.Save_Button.Name = "Save_Button";
            this.Save_Button.Size = new System.Drawing.Size(75, 23);
            this.Save_Button.TabIndex = 14;
            this.Save_Button.Text = "Kaydet";
            this.Save_Button.UseVisualStyleBackColor = true;
            this.Save_Button.Click += new System.EventHandler(this.Save_Button_Click);
            // 
            // Cancel_Button
            // 
            this.Cancel_Button.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.Cancel_Button.Location = new System.Drawing.Point(179, 271);
            this.Cancel_Button.Name = "Cancel_Button";
            this.Cancel_Button.Size = new System.Drawing.Size(75, 23);
            this.Cancel_Button.TabIndex = 15;
            this.Cancel_Button.Text = "İptal";
            this.Cancel_Button.UseVisualStyleBackColor = true;
            // 
            // Edit_Motor_Pop
            // 
            this.AcceptButton = this.Save_Button;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.Cancel_Button;
            this.ClientSize = new System.Drawing.Size(266, 306);
            this.Controls.Add(this.Cancel_Button);
            this.Controls.Add(this.Save_Button);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Edit_Motor_Pop";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Motor Düzenle";
            this.Load += new System.EventHandler(this.Edit_Motor_Pop_Load);
            ((System.ComponentModel.ISupportInitialize)(this.MaxRpm_Num)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DwellRpm_Num)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.AccelerationStartsAt_Num)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ShortDistance_Num)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox Name_Box;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox Axes_Combo;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.NumericUpDown MaxRpm_Num;
        private System.Windows.Forms.NumericUpDown DwellRpm_Num;
        private System.Windows.Forms.NumericUpDown AccelerationStartsAt_Num;
        private System.Windows.Forms.NumericUpDown ShortDistance_Num;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.CheckBox UseRamp_Check;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button Save_Button;
        private System.Windows.Forms.Button Cancel_Button;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
    }
}