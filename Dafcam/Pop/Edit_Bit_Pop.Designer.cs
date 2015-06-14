namespace Dafcam.Pop
{
    partial class Edit_Bit_Pop
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
            this.Save_Button = new System.Windows.Forms.Button();
            this.Cancel_Button = new System.Windows.Forms.Button();
            this.Drop_GetCurrentPosition_Button = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.Drop_Z_Num = new System.Windows.Forms.NumericUpDown();
            this.Drop_Y_Num = new System.Windows.Forms.NumericUpDown();
            this.label15 = new System.Windows.Forms.Label();
            this.Drop_X_Num = new System.Windows.Forms.NumericUpDown();
            this.label13 = new System.Windows.Forms.Label();
            this.PointDiameter_Num = new System.Windows.Forms.NumericUpDown();
            this.label12 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.Length_Num = new System.Windows.Forms.NumericUpDown();
            this.label10 = new System.Windows.Forms.Label();
            this.Name_Box = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.Stall_GetCurrentPosition_Button = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.Stall_Z_Num = new System.Windows.Forms.NumericUpDown();
            this.Stall_Y_Num = new System.Windows.Forms.NumericUpDown();
            this.label3 = new System.Windows.Forms.Label();
            this.Stall_X_Num = new System.Windows.Forms.NumericUpDown();
            this.label2 = new System.Windows.Forms.Label();
            this.ShaftDiameter_Num = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.Drop_Z_Num)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Drop_Y_Num)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Drop_X_Num)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PointDiameter_Num)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Length_Num)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Stall_Z_Num)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Stall_Y_Num)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Stall_X_Num)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ShaftDiameter_Num)).BeginInit();
            this.SuspendLayout();
            // 
            // Save_Button
            // 
            this.Save_Button.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.Save_Button.Location = new System.Drawing.Point(296, 278);
            this.Save_Button.Name = "Save_Button";
            this.Save_Button.Size = new System.Drawing.Size(75, 23);
            this.Save_Button.TabIndex = 5;
            this.Save_Button.Text = "Kaydet";
            this.Save_Button.UseVisualStyleBackColor = true;
            this.Save_Button.Click += new System.EventHandler(this.Save_Button_Click);
            // 
            // Cancel_Button
            // 
            this.Cancel_Button.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.Cancel_Button.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.Cancel_Button.Location = new System.Drawing.Point(377, 278);
            this.Cancel_Button.Name = "Cancel_Button";
            this.Cancel_Button.Size = new System.Drawing.Size(75, 23);
            this.Cancel_Button.TabIndex = 6;
            this.Cancel_Button.Text = "İptal";
            this.Cancel_Button.UseVisualStyleBackColor = true;
            this.Cancel_Button.Click += new System.EventHandler(this.Cancel_Button_Click);
            // 
            // Drop_GetCurrentPosition_Button
            // 
            this.Drop_GetCurrentPosition_Button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Drop_GetCurrentPosition_Button.Location = new System.Drawing.Point(412, 151);
            this.Drop_GetCurrentPosition_Button.Name = "Drop_GetCurrentPosition_Button";
            this.Drop_GetCurrentPosition_Button.Size = new System.Drawing.Size(38, 70);
            this.Drop_GetCurrentPosition_Button.TabIndex = 47;
            this.Drop_GetCurrentPosition_Button.Text = "ÖLÇ";
            this.Drop_GetCurrentPosition_Button.UseVisualStyleBackColor = true;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(307, 203);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(17, 13);
            this.label8.TabIndex = 56;
            this.label8.Text = "Z:";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(307, 177);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(17, 13);
            this.label14.TabIndex = 55;
            this.label14.Text = "Y:";
            // 
            // Drop_Z_Num
            // 
            this.Drop_Z_Num.Location = new System.Drawing.Point(327, 201);
            this.Drop_Z_Num.Maximum = new decimal(new int[] {
            1000000000,
            0,
            0,
            0});
            this.Drop_Z_Num.Minimum = new decimal(new int[] {
            10000000,
            0,
            0,
            -2147483648});
            this.Drop_Z_Num.Name = "Drop_Z_Num";
            this.Drop_Z_Num.Size = new System.Drawing.Size(79, 20);
            this.Drop_Z_Num.TabIndex = 45;
            // 
            // Drop_Y_Num
            // 
            this.Drop_Y_Num.Location = new System.Drawing.Point(327, 175);
            this.Drop_Y_Num.Maximum = new decimal(new int[] {
            1000000000,
            0,
            0,
            0});
            this.Drop_Y_Num.Minimum = new decimal(new int[] {
            10000000,
            0,
            0,
            -2147483648});
            this.Drop_Y_Num.Name = "Drop_Y_Num";
            this.Drop_Y_Num.Size = new System.Drawing.Size(79, 20);
            this.Drop_Y_Num.TabIndex = 42;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(307, 151);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(17, 13);
            this.label15.TabIndex = 54;
            this.label15.Text = "X:";
            // 
            // Drop_X_Num
            // 
            this.Drop_X_Num.Location = new System.Drawing.Point(327, 149);
            this.Drop_X_Num.Maximum = new decimal(new int[] {
            100000000,
            0,
            0,
            0});
            this.Drop_X_Num.Minimum = new decimal(new int[] {
            10000000,
            0,
            0,
            -2147483648});
            this.Drop_X_Num.Name = "Drop_X_Num";
            this.Drop_X_Num.Size = new System.Drawing.Size(79, 20);
            this.Drop_X_Num.TabIndex = 41;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.BackColor = System.Drawing.SystemColors.Window;
            this.label13.Location = new System.Drawing.Point(147, 94);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(23, 13);
            this.label13.TabIndex = 53;
            this.label13.Text = "mm";
            // 
            // PointDiameter_Num
            // 
            this.PointDiameter_Num.DecimalPlaces = 2;
            this.PointDiameter_Num.Location = new System.Drawing.Point(71, 90);
            this.PointDiameter_Num.Name = "PointDiameter_Num";
            this.PointDiameter_Num.Size = new System.Drawing.Size(120, 20);
            this.PointDiameter_Num.TabIndex = 34;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(12, 66);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(53, 13);
            this.label12.TabIndex = 52;
            this.label12.Text = "Şaft Çapı:";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.BackColor = System.Drawing.SystemColors.Window;
            this.label11.Location = new System.Drawing.Point(147, 42);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(23, 13);
            this.label11.TabIndex = 51;
            this.label11.Text = "mm";
            // 
            // Length_Num
            // 
            this.Length_Num.DecimalPlaces = 2;
            this.Length_Num.Location = new System.Drawing.Point(71, 38);
            this.Length_Num.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.Length_Num.Name = "Length_Num";
            this.Length_Num.Size = new System.Drawing.Size(120, 20);
            this.Length_Num.TabIndex = 31;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(37, 40);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(28, 13);
            this.label10.TabIndex = 50;
            this.label10.Text = "Boy:";
            // 
            // Name_Box
            // 
            this.Name_Box.Location = new System.Drawing.Point(71, 12);
            this.Name_Box.Name = "Name_Box";
            this.Name_Box.Size = new System.Drawing.Size(120, 20);
            this.Name_Box.TabIndex = 30;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(42, 15);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(23, 13);
            this.label9.TabIndex = 49;
            this.label9.Text = "Ad:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(225, 125);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(99, 13);
            this.label7.TabIndex = 48;
            this.label7.Text = "Bırakma Pozisyonu:";
            // 
            // Stall_GetCurrentPosition_Button
            // 
            this.Stall_GetCurrentPosition_Button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Stall_GetCurrentPosition_Button.Location = new System.Drawing.Point(412, 31);
            this.Stall_GetCurrentPosition_Button.Name = "Stall_GetCurrentPosition_Button";
            this.Stall_GetCurrentPosition_Button.Size = new System.Drawing.Size(38, 70);
            this.Stall_GetCurrentPosition_Button.TabIndex = 40;
            this.Stall_GetCurrentPosition_Button.Text = "ÖLÇ";
            this.Stall_GetCurrentPosition_Button.UseVisualStyleBackColor = true;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.SystemColors.Window;
            this.label6.Location = new System.Drawing.Point(147, 68);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(23, 13);
            this.label6.TabIndex = 46;
            this.label6.Text = "mm";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(307, 83);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(17, 13);
            this.label5.TabIndex = 44;
            this.label5.Text = "Z:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(307, 57);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(17, 13);
            this.label4.TabIndex = 43;
            this.label4.Text = "Y:";
            // 
            // Stall_Z_Num
            // 
            this.Stall_Z_Num.Location = new System.Drawing.Point(327, 81);
            this.Stall_Z_Num.Maximum = new decimal(new int[] {
            1000000000,
            0,
            0,
            0});
            this.Stall_Z_Num.Minimum = new decimal(new int[] {
            10000000,
            0,
            0,
            -2147483648});
            this.Stall_Z_Num.Name = "Stall_Z_Num";
            this.Stall_Z_Num.Size = new System.Drawing.Size(79, 20);
            this.Stall_Z_Num.TabIndex = 39;
            // 
            // Stall_Y_Num
            // 
            this.Stall_Y_Num.Location = new System.Drawing.Point(327, 55);
            this.Stall_Y_Num.Maximum = new decimal(new int[] {
            1000000000,
            0,
            0,
            0});
            this.Stall_Y_Num.Minimum = new decimal(new int[] {
            10000000,
            0,
            0,
            -2147483648});
            this.Stall_Y_Num.Name = "Stall_Y_Num";
            this.Stall_Y_Num.Size = new System.Drawing.Size(79, 20);
            this.Stall_Y_Num.TabIndex = 37;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(307, 31);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(17, 13);
            this.label3.TabIndex = 38;
            this.label3.Text = "X:";
            // 
            // Stall_X_Num
            // 
            this.Stall_X_Num.Location = new System.Drawing.Point(327, 29);
            this.Stall_X_Num.Maximum = new decimal(new int[] {
            100000000,
            0,
            0,
            0});
            this.Stall_X_Num.Minimum = new decimal(new int[] {
            10000000,
            0,
            0,
            -2147483648});
            this.Stall_X_Num.Name = "Stall_X_Num";
            this.Stall_X_Num.Size = new System.Drawing.Size(79, 20);
            this.Stall_X_Num.TabIndex = 36;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(234, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(90, 13);
            this.label2.TabIndex = 35;
            this.label2.Text = "Takım Pozisyonu:";
            // 
            // ShaftDiameter_Num
            // 
            this.ShaftDiameter_Num.DecimalPlaces = 2;
            this.ShaftDiameter_Num.Location = new System.Drawing.Point(71, 64);
            this.ShaftDiameter_Num.Name = "ShaftDiameter_Num";
            this.ShaftDiameter_Num.Size = new System.Drawing.Size(120, 20);
            this.ShaftDiameter_Num.TabIndex = 32;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(17, 92);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(48, 13);
            this.label1.TabIndex = 33;
            this.label1.Text = "Uç Çapı:";
            // 
            // Edit_Bit_Pop
            // 
            this.AcceptButton = this.Save_Button;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.Cancel_Button;
            this.ClientSize = new System.Drawing.Size(464, 313);
            this.Controls.Add(this.Drop_GetCurrentPosition_Button);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.Drop_Z_Num);
            this.Controls.Add(this.Drop_Y_Num);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.Drop_X_Num);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.PointDiameter_Num);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.Length_Num);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.Name_Box);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.Stall_GetCurrentPosition_Button);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.Stall_Z_Num);
            this.Controls.Add(this.Stall_Y_Num);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.Stall_X_Num);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.ShaftDiameter_Num);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Cancel_Button);
            this.Controls.Add(this.Save_Button);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Edit_Bit_Pop";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Takım Ucu Düzenle";
            this.Load += new System.EventHandler(this.EditDrillBit_Pop_Load);
            ((System.ComponentModel.ISupportInitialize)(this.Drop_Z_Num)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Drop_Y_Num)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Drop_X_Num)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PointDiameter_Num)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Length_Num)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Stall_Z_Num)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Stall_Y_Num)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Stall_X_Num)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ShaftDiameter_Num)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Save_Button;
        private System.Windows.Forms.Button Cancel_Button;
        private System.Windows.Forms.Button Drop_GetCurrentPosition_Button;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.NumericUpDown Drop_Z_Num;
        private System.Windows.Forms.NumericUpDown Drop_Y_Num;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.NumericUpDown Drop_X_Num;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.NumericUpDown PointDiameter_Num;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.NumericUpDown Length_Num;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox Name_Box;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button Stall_GetCurrentPosition_Button;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.NumericUpDown Stall_Z_Num;
        private System.Windows.Forms.NumericUpDown Stall_Y_Num;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.NumericUpDown Stall_X_Num;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.NumericUpDown ShaftDiameter_Num;
        private System.Windows.Forms.Label label1;
    }
}