namespace Dafcam
{
    partial class MainForm
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.ExcellonDialog = new System.Windows.Forms.OpenFileDialog();
            this.Ports_Combo = new System.Windows.Forms.ComboBox();
            this.Connect_Button = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.Baud_Combo = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.Scale_Num = new System.Windows.Forms.NumericUpDown();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.dosyaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.çıkışToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.araçlarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.motorlarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ayarlarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.takımlarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.yardımToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.Xminus_Button = new System.Windows.Forms.Button();
            this.Xplus_Button = new System.Windows.Forms.Button();
            this.Yplus_Button = new System.Windows.Forms.Button();
            this.Yminus_Button = new System.Windows.Forms.Button();
            this.Zminus_Button = new System.Windows.Forms.Button();
            this.Zplus_Button = new System.Windows.Forms.Button();
            this.Reset_Button = new System.Windows.Forms.Button();
            this.ZMaxNum = new System.Windows.Forms.NumericUpDown();
            this.label3 = new System.Windows.Forms.Label();
            this.GoZMax_Button = new System.Windows.Forms.Button();
            this.ZLastNum = new System.Windows.Forms.NumericUpDown();
            this.ZLiftNum = new System.Windows.Forms.NumericUpDown();
            this.ZDrillNum = new System.Windows.Forms.NumericUpDown();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.ZLiftNuml = new System.Windows.Forms.Label();
            this.Jobs_Tab = new System.Windows.Forms.TabControl();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.numericUpDown2 = new System.Windows.Forms.NumericUpDown();
            this.numericUpDown1 = new System.Windows.Forms.NumericUpDown();
            this.Camera_Toggle = new System.Windows.Forms.Button();
            this.opticBox1 = new Emgu.CV.UI.ImageBox();
            this.ImageList = new System.Windows.Forms.ImageList(this.components);
            this.Incoming_Box = new System.Windows.Forms.TextBox();
            this.Status_Strip = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripStatusLabel2 = new System.Windows.Forms.ToolStripStatusLabel();
            this.PadCounterLabel = new System.Windows.Forms.ToolStripStatusLabel();
            this.PercentageLabel = new System.Windows.Forms.ToolStripStatusLabel();
            this.PercentageBar = new System.Windows.Forms.ToolStripProgressBar();
            this.label12 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.GoZFirst_Button = new System.Windows.Forms.Button();
            this.Repeat_Layout_Button = new System.Windows.Forms.Button();
            this.Delete_Layout_Button = new System.Windows.Forms.Button();
            this.New_Layout_Button = new System.Windows.Forms.Button();
            this.Start_Button = new System.Windows.Forms.Button();
            this.Global_Timer = new System.Windows.Forms.Timer(this.components);
            this.button1 = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.CurrentBit_Label = new System.Windows.Forms.Label();
            this.SpindleState_Label = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.Scale_Num)).BeginInit();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ZMaxNum)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ZLastNum)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ZLiftNum)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ZDrillNum)).BeginInit();
            this.Jobs_Tab.SuspendLayout();
            this.tabPage3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.opticBox1)).BeginInit();
            this.Status_Strip.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // ExcellonDialog
            // 
            this.ExcellonDialog.Filter = "Excellon Drill|*.txt";
            // 
            // Ports_Combo
            // 
            this.Ports_Combo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.Ports_Combo.FormattingEnabled = true;
            this.Ports_Combo.Location = new System.Drawing.Point(12, 46);
            this.Ports_Combo.Name = "Ports_Combo";
            this.Ports_Combo.Size = new System.Drawing.Size(121, 21);
            this.Ports_Combo.TabIndex = 2;
            // 
            // Connect_Button
            // 
            this.Connect_Button.Location = new System.Drawing.Point(139, 46);
            this.Connect_Button.Name = "Connect_Button";
            this.Connect_Button.Size = new System.Drawing.Size(75, 23);
            this.Connect_Button.TabIndex = 3;
            this.Connect_Button.Text = "Bağlan";
            this.Connect_Button.UseVisualStyleBackColor = true;
            this.Connect_Button.Click += new System.EventHandler(this.Connect_Button_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 107);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(59, 13);
            this.label1.TabIndex = 7;
            this.label1.Text = "Gelen Veri:";
            // 
            // Baud_Combo
            // 
            this.Baud_Combo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.Baud_Combo.FormattingEnabled = true;
            this.Baud_Combo.Items.AddRange(new object[] {
            "300",
            "1200",
            "2400",
            "4800",
            "9600",
            "14400",
            "19200",
            "28800",
            "38400",
            "57600",
            "115200",
            "230400"});
            this.Baud_Combo.Location = new System.Drawing.Point(12, 73);
            this.Baud_Combo.Name = "Baud_Combo";
            this.Baud_Combo.Size = new System.Drawing.Size(121, 21);
            this.Baud_Combo.TabIndex = 11;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(285, 49);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(38, 13);
            this.label2.TabIndex = 12;
            this.label2.Text = "Ölçek:";
            // 
            // Scale_Num
            // 
            this.Scale_Num.DecimalPlaces = 8;
            this.Scale_Num.Location = new System.Drawing.Point(329, 47);
            this.Scale_Num.Maximum = new decimal(new int[] {
            100000,
            0,
            0,
            0});
            this.Scale_Num.Name = "Scale_Num";
            this.Scale_Num.Size = new System.Drawing.Size(94, 20);
            this.Scale_Num.TabIndex = 13;
            this.Scale_Num.Value = new decimal(new int[] {
            2542,
            0,
            0,
            262144});
            this.Scale_Num.ValueChanged += new System.EventHandler(this.Scale_Num_ValueChanged);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.dosyaToolStripMenuItem,
            this.araçlarToolStripMenuItem,
            this.yardımToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1005, 24);
            this.menuStrip1.TabIndex = 14;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // dosyaToolStripMenuItem
            // 
            this.dosyaToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.çıkışToolStripMenuItem});
            this.dosyaToolStripMenuItem.Name = "dosyaToolStripMenuItem";
            this.dosyaToolStripMenuItem.Size = new System.Drawing.Size(49, 20);
            this.dosyaToolStripMenuItem.Text = "Dosya";
            // 
            // çıkışToolStripMenuItem
            // 
            this.çıkışToolStripMenuItem.Name = "çıkışToolStripMenuItem";
            this.çıkışToolStripMenuItem.Size = new System.Drawing.Size(95, 22);
            this.çıkışToolStripMenuItem.Text = "Çıkış";
            this.çıkışToolStripMenuItem.Click += new System.EventHandler(this.çıkışToolStripMenuItem_Click);
            // 
            // araçlarToolStripMenuItem
            // 
            this.araçlarToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.motorlarToolStripMenuItem,
            this.ayarlarToolStripMenuItem,
            this.takımlarToolStripMenuItem});
            this.araçlarToolStripMenuItem.Name = "araçlarToolStripMenuItem";
            this.araçlarToolStripMenuItem.Size = new System.Drawing.Size(53, 20);
            this.araçlarToolStripMenuItem.Text = "Araçlar";
            // 
            // motorlarToolStripMenuItem
            // 
            this.motorlarToolStripMenuItem.Name = "motorlarToolStripMenuItem";
            this.motorlarToolStripMenuItem.Size = new System.Drawing.Size(114, 22);
            this.motorlarToolStripMenuItem.Text = "Motorlar";
            this.motorlarToolStripMenuItem.Click += new System.EventHandler(this.motorlarToolStripMenuItem_Click);
            // 
            // ayarlarToolStripMenuItem
            // 
            this.ayarlarToolStripMenuItem.Name = "ayarlarToolStripMenuItem";
            this.ayarlarToolStripMenuItem.Size = new System.Drawing.Size(114, 22);
            this.ayarlarToolStripMenuItem.Text = "Ayarlar";
            this.ayarlarToolStripMenuItem.Click += new System.EventHandler(this.ayarlarToolStripMenuItem_Click);
            // 
            // takımlarToolStripMenuItem
            // 
            this.takımlarToolStripMenuItem.Name = "takımlarToolStripMenuItem";
            this.takımlarToolStripMenuItem.Size = new System.Drawing.Size(114, 22);
            this.takımlarToolStripMenuItem.Text = "Takımlar";
            this.takımlarToolStripMenuItem.Click += new System.EventHandler(this.takımlarToolStripMenuItem_Click);
            // 
            // yardımToolStripMenuItem
            // 
            this.yardımToolStripMenuItem.Name = "yardımToolStripMenuItem";
            this.yardımToolStripMenuItem.Size = new System.Drawing.Size(51, 20);
            this.yardımToolStripMenuItem.Text = "Yardım";
            // 
            // Xminus_Button
            // 
            this.Xminus_Button.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.Xminus_Button.Location = new System.Drawing.Point(787, 110);
            this.Xminus_Button.Name = "Xminus_Button";
            this.Xminus_Button.Size = new System.Drawing.Size(75, 23);
            this.Xminus_Button.TabIndex = 16;
            this.Xminus_Button.Text = "X-";
            this.Xminus_Button.UseVisualStyleBackColor = true;
            this.Xminus_Button.Click += new System.EventHandler(this.Xminus_Button_Click);
            this.Xminus_Button.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Xminus_Button_MouseDown);
            this.Xminus_Button.MouseUp += new System.Windows.Forms.MouseEventHandler(this.Xminus_Button_MouseUp);
            // 
            // Xplus_Button
            // 
            this.Xplus_Button.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.Xplus_Button.Location = new System.Drawing.Point(892, 110);
            this.Xplus_Button.Name = "Xplus_Button";
            this.Xplus_Button.Size = new System.Drawing.Size(75, 23);
            this.Xplus_Button.TabIndex = 17;
            this.Xplus_Button.Text = "X+";
            this.Xplus_Button.UseVisualStyleBackColor = true;
            this.Xplus_Button.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Xplus_Button_MouseDown);
            this.Xplus_Button.MouseUp += new System.Windows.Forms.MouseEventHandler(this.Xplus_Button_MouseUp);
            // 
            // Yplus_Button
            // 
            this.Yplus_Button.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.Yplus_Button.Location = new System.Drawing.Point(837, 157);
            this.Yplus_Button.Name = "Yplus_Button";
            this.Yplus_Button.Size = new System.Drawing.Size(75, 23);
            this.Yplus_Button.TabIndex = 18;
            this.Yplus_Button.Text = "Y+";
            this.Yplus_Button.UseVisualStyleBackColor = true;
            this.Yplus_Button.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Yplus_Button_MouseDown);
            this.Yplus_Button.MouseUp += new System.Windows.Forms.MouseEventHandler(this.Yplus_Button_MouseUp);
            // 
            // Yminus_Button
            // 
            this.Yminus_Button.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.Yminus_Button.Location = new System.Drawing.Point(837, 60);
            this.Yminus_Button.Name = "Yminus_Button";
            this.Yminus_Button.Size = new System.Drawing.Size(75, 23);
            this.Yminus_Button.TabIndex = 19;
            this.Yminus_Button.Text = "Y-";
            this.Yminus_Button.UseVisualStyleBackColor = true;
            this.Yminus_Button.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Yminus_Button_MouseDown);
            this.Yminus_Button.MouseUp += new System.Windows.Forms.MouseEventHandler(this.Yminus_Button_MouseUp);
            // 
            // Zminus_Button
            // 
            this.Zminus_Button.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.Zminus_Button.Location = new System.Drawing.Point(837, 31);
            this.Zminus_Button.Name = "Zminus_Button";
            this.Zminus_Button.Size = new System.Drawing.Size(75, 23);
            this.Zminus_Button.TabIndex = 20;
            this.Zminus_Button.Text = "Z-";
            this.Zminus_Button.UseVisualStyleBackColor = true;
            this.Zminus_Button.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Zminus_Button_MouseDown);
            this.Zminus_Button.MouseUp += new System.Windows.Forms.MouseEventHandler(this.Zminus_Button_MouseUp);
            // 
            // Zplus_Button
            // 
            this.Zplus_Button.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.Zplus_Button.Location = new System.Drawing.Point(837, 184);
            this.Zplus_Button.Name = "Zplus_Button";
            this.Zplus_Button.Size = new System.Drawing.Size(75, 23);
            this.Zplus_Button.TabIndex = 21;
            this.Zplus_Button.Text = "Z+";
            this.Zplus_Button.UseVisualStyleBackColor = true;
            this.Zplus_Button.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Zplus_Button_MouseDown);
            this.Zplus_Button.MouseUp += new System.Windows.Forms.MouseEventHandler(this.Zplus_Button_MouseUp);
            // 
            // Reset_Button
            // 
            this.Reset_Button.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.Reset_Button.Location = new System.Drawing.Point(756, 31);
            this.Reset_Button.Name = "Reset_Button";
            this.Reset_Button.Size = new System.Drawing.Size(75, 23);
            this.Reset_Button.TabIndex = 23;
            this.Reset_Button.Text = "Reset";
            this.Reset_Button.UseVisualStyleBackColor = true;
            this.Reset_Button.Click += new System.EventHandler(this.Reset_Button_Click);
            // 
            // ZMaxNum
            // 
            this.ZMaxNum.Location = new System.Drawing.Point(329, 73);
            this.ZMaxNum.Maximum = new decimal(new int[] {
            100000000,
            0,
            0,
            0});
            this.ZMaxNum.Name = "ZMaxNum";
            this.ZMaxNum.ReadOnly = true;
            this.ZMaxNum.Size = new System.Drawing.Size(94, 20);
            this.ZMaxNum.TabIndex = 27;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(259, 75);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(64, 13);
            this.label3.TabIndex = 28;
            this.label3.Text = "Z Maximum:";
            // 
            // GoZMax_Button
            // 
            this.GoZMax_Button.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.GoZMax_Button.Location = new System.Drawing.Point(918, 184);
            this.GoZMax_Button.Name = "GoZMax_Button";
            this.GoZMax_Button.Size = new System.Drawing.Size(75, 23);
            this.GoZMax_Button.TabIndex = 29;
            this.GoZMax_Button.Text = "Z son";
            this.GoZMax_Button.UseVisualStyleBackColor = true;
            this.GoZMax_Button.Click += new System.EventHandler(this.GoZMax_Button_Click);
            // 
            // ZLastNum
            // 
            this.ZLastNum.Location = new System.Drawing.Point(329, 100);
            this.ZLastNum.Maximum = new decimal(new int[] {
            1000000,
            0,
            0,
            0});
            this.ZLastNum.Minimum = new decimal(new int[] {
            1000000,
            0,
            0,
            -2147483648});
            this.ZLastNum.Name = "ZLastNum";
            this.ZLastNum.ReadOnly = true;
            this.ZLastNum.Size = new System.Drawing.Size(94, 20);
            this.ZLastNum.TabIndex = 30;
            // 
            // ZLiftNum
            // 
            this.ZLiftNum.DecimalPlaces = 2;
            this.ZLiftNum.Location = new System.Drawing.Point(329, 127);
            this.ZLiftNum.Maximum = new decimal(new int[] {
            1000000,
            0,
            0,
            0});
            this.ZLiftNum.Name = "ZLiftNum";
            this.ZLiftNum.Size = new System.Drawing.Size(94, 20);
            this.ZLiftNum.TabIndex = 31;
            this.ZLiftNum.ValueChanged += new System.EventHandler(this.ZLiftNum_ValueChanged);
            // 
            // ZDrillNum
            // 
            this.ZDrillNum.DecimalPlaces = 2;
            this.ZDrillNum.Location = new System.Drawing.Point(329, 153);
            this.ZDrillNum.Maximum = new decimal(new int[] {
            1000000,
            0,
            0,
            0});
            this.ZDrillNum.Name = "ZDrillNum";
            this.ZDrillNum.Size = new System.Drawing.Size(94, 20);
            this.ZDrillNum.TabIndex = 32;
            this.ZDrillNum.ValueChanged += new System.EventHandler(this.ZDrillNum_ValueChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(284, 102);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(39, 13);
            this.label4.TabIndex = 33;
            this.label4.Text = "Z Son:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(243, 155);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(80, 13);
            this.label5.TabIndex = 34;
            this.label5.Text = "Delme Derinliği:";
            // 
            // ZLiftNuml
            // 
            this.ZLiftNuml.AutoSize = true;
            this.ZLiftNuml.Location = new System.Drawing.Point(267, 129);
            this.ZLiftNuml.Name = "ZLiftNuml";
            this.ZLiftNuml.Size = new System.Drawing.Size(56, 13);
            this.ZLiftNuml.TabIndex = 35;
            this.ZLiftNuml.Text = "Yükselme:";
            // 
            // Jobs_Tab
            // 
            this.Jobs_Tab.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Jobs_Tab.Controls.Add(this.tabPage3);
            this.Jobs_Tab.ImageList = this.ImageList;
            this.Jobs_Tab.Location = new System.Drawing.Point(15, 213);
            this.Jobs_Tab.Name = "Jobs_Tab";
            this.Jobs_Tab.SelectedIndex = 0;
            this.Jobs_Tab.Size = new System.Drawing.Size(897, 370);
            this.Jobs_Tab.SizeMode = System.Windows.Forms.TabSizeMode.Fixed;
            this.Jobs_Tab.TabIndex = 39;
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.numericUpDown2);
            this.tabPage3.Controls.Add(this.numericUpDown1);
            this.tabPage3.Controls.Add(this.Camera_Toggle);
            this.tabPage3.Controls.Add(this.opticBox1);
            this.tabPage3.Location = new System.Drawing.Point(4, 23);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3.Size = new System.Drawing.Size(889, 343);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Optik";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // numericUpDown2
            // 
            this.numericUpDown2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.numericUpDown2.Location = new System.Drawing.Point(786, 288);
            this.numericUpDown2.Maximum = new decimal(new int[] {
            500,
            0,
            0,
            0});
            this.numericUpDown2.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericUpDown2.Name = "numericUpDown2";
            this.numericUpDown2.Size = new System.Drawing.Size(97, 20);
            this.numericUpDown2.TabIndex = 7;
            this.numericUpDown2.Value = new decimal(new int[] {
            20,
            0,
            0,
            0});
            // 
            // numericUpDown1
            // 
            this.numericUpDown1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.numericUpDown1.Location = new System.Drawing.Point(786, 262);
            this.numericUpDown1.Maximum = new decimal(new int[] {
            500,
            0,
            0,
            0});
            this.numericUpDown1.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericUpDown1.Name = "numericUpDown1";
            this.numericUpDown1.Size = new System.Drawing.Size(97, 20);
            this.numericUpDown1.TabIndex = 6;
            this.numericUpDown1.Value = new decimal(new int[] {
            170,
            0,
            0,
            0});
            // 
            // Camera_Toggle
            // 
            this.Camera_Toggle.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.Camera_Toggle.Location = new System.Drawing.Point(786, 314);
            this.Camera_Toggle.Name = "Camera_Toggle";
            this.Camera_Toggle.Size = new System.Drawing.Size(97, 23);
            this.Camera_Toggle.TabIndex = 3;
            this.Camera_Toggle.Text = "Kamera: Açık";
            this.Camera_Toggle.UseVisualStyleBackColor = true;
            this.Camera_Toggle.Click += new System.EventHandler(this.Camera_Toggle_Click);
            // 
            // opticBox1
            // 
            this.opticBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.opticBox1.InterpolationMode = System.Drawing.Drawing2D.InterpolationMode.HighQualityBicubic;
            this.opticBox1.Location = new System.Drawing.Point(3, 3);
            this.opticBox1.Name = "opticBox1";
            this.opticBox1.Size = new System.Drawing.Size(883, 337);
            this.opticBox1.TabIndex = 2;
            this.opticBox1.TabStop = false;
            // 
            // ImageList
            // 
            this.ImageList.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("ImageList.ImageStream")));
            this.ImageList.TransparentColor = System.Drawing.Color.Transparent;
            this.ImageList.Images.SetKeyName(0, "exclamation.png");
            // 
            // Incoming_Box
            // 
            this.Incoming_Box.Location = new System.Drawing.Point(12, 123);
            this.Incoming_Box.Multiline = true;
            this.Incoming_Box.Name = "Incoming_Box";
            this.Incoming_Box.Size = new System.Drawing.Size(202, 72);
            this.Incoming_Box.TabIndex = 6;
            // 
            // Status_Strip
            // 
            this.Status_Strip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel1,
            this.toolStripStatusLabel2,
            this.PadCounterLabel,
            this.PercentageLabel,
            this.PercentageBar});
            this.Status_Strip.Location = new System.Drawing.Point(0, 586);
            this.Status_Strip.Name = "Status_Strip";
            this.Status_Strip.Size = new System.Drawing.Size(1005, 22);
            this.Status_Strip.TabIndex = 40;
            this.Status_Strip.Text = "statusStrip1";
            // 
            // toolStripStatusLabel1
            // 
            this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            this.toolStripStatusLabel1.Size = new System.Drawing.Size(71, 17);
            this.toolStripStatusLabel1.Text = "Durum: Aylak";
            // 
            // toolStripStatusLabel2
            // 
            this.toolStripStatusLabel2.Name = "toolStripStatusLabel2";
            this.toolStripStatusLabel2.Size = new System.Drawing.Size(919, 17);
            this.toolStripStatusLabel2.Spring = true;
            // 
            // PadCounterLabel
            // 
            this.PadCounterLabel.Name = "PadCounterLabel";
            this.PadCounterLabel.Size = new System.Drawing.Size(103, 17);
            this.PadCounterLabel.Text = "Delinen/Toplam: 0/0";
            this.PadCounterLabel.Visible = false;
            // 
            // PercentageLabel
            // 
            this.PercentageLabel.Name = "PercentageLabel";
            this.PercentageLabel.Size = new System.Drawing.Size(30, 17);
            this.PercentageLabel.Text = "%00";
            this.PercentageLabel.Visible = false;
            // 
            // PercentageBar
            // 
            this.PercentageBar.Name = "PercentageBar";
            this.PercentageBar.Size = new System.Drawing.Size(100, 16);
            this.PercentageBar.Visible = false;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.BackColor = System.Drawing.SystemColors.Window;
            this.label12.Location = new System.Drawing.Point(380, 131);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(23, 13);
            this.label12.TabIndex = 44;
            this.label12.Text = "mm";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.SystemColors.Window;
            this.label6.Location = new System.Drawing.Point(380, 157);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(23, 13);
            this.label6.TabIndex = 45;
            this.label6.Text = "mm";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.Transparent;
            this.label7.Location = new System.Drawing.Point(381, 76);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(23, 13);
            this.label7.TabIndex = 46;
            this.label7.Text = "mm";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.Transparent;
            this.label8.Location = new System.Drawing.Point(380, 103);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(23, 13);
            this.label8.TabIndex = 47;
            this.label8.Text = "mm";
            // 
            // GoZFirst_Button
            // 
            this.GoZFirst_Button.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.GoZFirst_Button.Location = new System.Drawing.Point(756, 184);
            this.GoZFirst_Button.Name = "GoZFirst_Button";
            this.GoZFirst_Button.Size = new System.Drawing.Size(75, 23);
            this.GoZFirst_Button.TabIndex = 48;
            this.GoZFirst_Button.Text = "Z baş";
            this.GoZFirst_Button.UseVisualStyleBackColor = true;
            this.GoZFirst_Button.Click += new System.EventHandler(this.GoZFirst_Button_Click);
            // 
            // Repeat_Layout_Button
            // 
            this.Repeat_Layout_Button.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.Repeat_Layout_Button.Image = global::Dafcam.Properties.Resources.redo;
            this.Repeat_Layout_Button.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Repeat_Layout_Button.Location = new System.Drawing.Point(918, 354);
            this.Repeat_Layout_Button.Name = "Repeat_Layout_Button";
            this.Repeat_Layout_Button.Size = new System.Drawing.Size(75, 23);
            this.Repeat_Layout_Button.TabIndex = 43;
            this.Repeat_Layout_Button.Text = "Tekrarla";
            this.Repeat_Layout_Button.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.Repeat_Layout_Button.UseVisualStyleBackColor = true;
            this.Repeat_Layout_Button.Click += new System.EventHandler(this.Repeat_Layout_Button_Click);
            // 
            // Delete_Layout_Button
            // 
            this.Delete_Layout_Button.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.Delete_Layout_Button.Image = global::Dafcam.Properties.Resources.delete;
            this.Delete_Layout_Button.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Delete_Layout_Button.Location = new System.Drawing.Point(918, 325);
            this.Delete_Layout_Button.Name = "Delete_Layout_Button";
            this.Delete_Layout_Button.Size = new System.Drawing.Size(75, 23);
            this.Delete_Layout_Button.TabIndex = 42;
            this.Delete_Layout_Button.Text = "Sil";
            this.Delete_Layout_Button.UseVisualStyleBackColor = true;
            this.Delete_Layout_Button.Click += new System.EventHandler(this.Delete_Layout_Button_Click);
            // 
            // New_Layout_Button
            // 
            this.New_Layout_Button.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.New_Layout_Button.Image = global::Dafcam.Properties.Resources.layout_add;
            this.New_Layout_Button.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.New_Layout_Button.Location = new System.Drawing.Point(918, 296);
            this.New_Layout_Button.Name = "New_Layout_Button";
            this.New_Layout_Button.Size = new System.Drawing.Size(75, 23);
            this.New_Layout_Button.TabIndex = 41;
            this.New_Layout_Button.Text = "Yeni";
            this.New_Layout_Button.UseVisualStyleBackColor = true;
            this.New_Layout_Button.Click += new System.EventHandler(this.New_Layout_Button_Click);
            // 
            // Start_Button
            // 
            this.Start_Button.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.Start_Button.Image = global::Dafcam.Properties.Resources.control_play_blue;
            this.Start_Button.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Start_Button.Location = new System.Drawing.Point(918, 236);
            this.Start_Button.Name = "Start_Button";
            this.Start_Button.Size = new System.Drawing.Size(75, 23);
            this.Start_Button.TabIndex = 9;
            this.Start_Button.Text = "Başlat";
            this.Start_Button.UseVisualStyleBackColor = true;
            this.Start_Button.Click += new System.EventHandler(this.Start_Button_Click);
            // 
            // Global_Timer
            // 
            this.Global_Timer.Enabled = true;
            this.Global_Timer.Interval = 60000;
            this.Global_Timer.Tick += new System.EventHandler(this.Global_Timer_Tick);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(119, 141);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 49;
            this.button1.Text = "Çalıştır";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.SpindleToggle_Button_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.CurrentBit_Label);
            this.groupBox1.Controls.Add(this.SpindleState_Label);
            this.groupBox1.Controls.Add(this.label10);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.button1);
            this.groupBox1.Location = new System.Drawing.Point(550, 31);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(200, 176);
            this.groupBox1.TabIndex = 51;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Spindle";
            // 
            // CurrentBit_Label
            // 
            this.CurrentBit_Label.AutoSize = true;
            this.CurrentBit_Label.Location = new System.Drawing.Point(62, 45);
            this.CurrentBit_Label.Name = "CurrentBit_Label";
            this.CurrentBit_Label.Size = new System.Drawing.Size(50, 13);
            this.CurrentBit_Label.TabIndex = 53;
            this.CurrentBit_Label.Text = "Bilinmiyor";
            // 
            // SpindleState_Label
            // 
            this.SpindleState_Label.AutoSize = true;
            this.SpindleState_Label.Location = new System.Drawing.Point(62, 20);
            this.SpindleState_Label.Name = "SpindleState_Label";
            this.SpindleState_Label.Size = new System.Drawing.Size(50, 13);
            this.SpindleState_Label.TabIndex = 52;
            this.SpindleState_Label.Text = "Bilinmiyor";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(32, 45);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(24, 13);
            this.label10.TabIndex = 51;
            this.label10.Text = "Uç:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(15, 20);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(41, 13);
            this.label9.TabIndex = 50;
            this.label9.Text = "Durum:";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1005, 608);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.GoZFirst_Button);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.Repeat_Layout_Button);
            this.Controls.Add(this.Delete_Layout_Button);
            this.Controls.Add(this.New_Layout_Button);
            this.Controls.Add(this.Status_Strip);
            this.Controls.Add(this.Jobs_Tab);
            this.Controls.Add(this.ZLiftNuml);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.ZDrillNum);
            this.Controls.Add(this.ZLiftNum);
            this.Controls.Add(this.ZLastNum);
            this.Controls.Add(this.GoZMax_Button);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.ZMaxNum);
            this.Controls.Add(this.Reset_Button);
            this.Controls.Add(this.Zplus_Button);
            this.Controls.Add(this.Zminus_Button);
            this.Controls.Add(this.Yminus_Button);
            this.Controls.Add(this.Yplus_Button);
            this.Controls.Add(this.Xplus_Button);
            this.Controls.Add(this.Xminus_Button);
            this.Controls.Add(this.Scale_Num);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.Baud_Combo);
            this.Controls.Add(this.Start_Button);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Incoming_Box);
            this.Controls.Add(this.Connect_Button);
            this.Controls.Add(this.Ports_Combo);
            this.Controls.Add(this.menuStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Dafcam - Version 0.1.5";
            this.Load += new System.EventHandler(this.MainForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.Scale_Num)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ZMaxNum)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ZLastNum)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ZLiftNum)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ZDrillNum)).EndInit();
            this.Jobs_Tab.ResumeLayout(false);
            this.tabPage3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.opticBox1)).EndInit();
            this.Status_Strip.ResumeLayout(false);
            this.Status_Strip.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.OpenFileDialog ExcellonDialog;
        private System.Windows.Forms.ComboBox Ports_Combo;
        private System.Windows.Forms.Button Connect_Button;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button Start_Button;
        private System.Windows.Forms.ComboBox Baud_Combo;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.NumericUpDown Scale_Num;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem dosyaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem çıkışToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem araçlarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem motorlarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ayarlarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem yardımToolStripMenuItem;
        private System.Windows.Forms.Button Reset_Button;
        private System.Windows.Forms.Button Xminus_Button;
        private System.Windows.Forms.Button Xplus_Button;
        private System.Windows.Forms.Button Yplus_Button;
        private System.Windows.Forms.Button Yminus_Button;
        private System.Windows.Forms.Button Zminus_Button;
        private System.Windows.Forms.Button Zplus_Button;
        private System.Windows.Forms.NumericUpDown ZMaxNum;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button GoZMax_Button;
        private System.Windows.Forms.NumericUpDown ZLastNum;
        private System.Windows.Forms.NumericUpDown ZLiftNum;
        private System.Windows.Forms.NumericUpDown ZDrillNum;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label ZLiftNuml;
        private System.Windows.Forms.TabControl Jobs_Tab;
        private System.Windows.Forms.TextBox Incoming_Box;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.StatusStrip Status_Strip;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel1;
        private System.Windows.Forms.ImageList ImageList;
        private System.Windows.Forms.Button New_Layout_Button;
        private System.Windows.Forms.Button Delete_Layout_Button;
        private System.Windows.Forms.Button Repeat_Layout_Button;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel2;
        private System.Windows.Forms.ToolStripStatusLabel PercentageLabel;
        private System.Windows.Forms.ToolStripProgressBar PercentageBar;
        private System.Windows.Forms.ToolStripStatusLabel PadCounterLabel;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button GoZFirst_Button;
        private System.Windows.Forms.ToolStripMenuItem takımlarToolStripMenuItem;
        private System.Windows.Forms.Timer Global_Timer;
        private System.Windows.Forms.Button button1;
        private Emgu.CV.UI.ImageBox opticBox1;
        private System.Windows.Forms.Button Camera_Toggle;
        private System.Windows.Forms.NumericUpDown numericUpDown2;
        private System.Windows.Forms.NumericUpDown numericUpDown1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label CurrentBit_Label;
        private System.Windows.Forms.Label SpindleState_Label;
        
    }
}

