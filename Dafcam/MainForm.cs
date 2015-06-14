using Dafcam.Properties;
using ExcellonViewer;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.IO;
using System.IO.Ports;
using System.Text;
using System.Threading;
using System.Windows.Forms;
using System.Windows.Forms.Integration;
using System.Windows.Interop;
using System.Windows.Markup;
using Wpf = System.Windows;
using System.Linq;
using Emgu.CV;
using Emgu.CV.Structure;
using System.Data.Entity;

namespace Dafcam
{
    public enum ProgramState
    {
        Idle,
        Waiting,
        Working
    }
    public partial class MainForm : Form
    {
        private Capture m_EmguCam = null;
        private bool m_IsCapturing;

        public ProgramState ProgramState { get; set; }

        public List<ExcellonPanel> Layouts = new List<ExcellonPanel>();
        public ExcellonPanel CurrentExcellon { get; set; }
        public Wpf.Vector CurrentCoordinate { get; set; }
        public int CurrentPadIndex { get; set; }

        private DafcamEntities m_Context = new DafcamEntities();

        public MainForm()
        {
            InitializeComponent();

            try
            {
                m_EmguCam = new Capture(0);
                m_EmguCam.SetCaptureProperty(Emgu.CV.CvEnum.CAP_PROP.CV_CAP_PROP_FRAME_WIDTH, 1280);
                m_EmguCam.SetCaptureProperty(Emgu.CV.CvEnum.CAP_PROP.CV_CAP_PROP_FRAME_HEIGHT, 720);
                m_EmguCam.FlipHorizontal = true;
                m_EmguCam.FlipVertical = true;
                
                m_EmguCam.ImageGrabbed += EmguCam_ImageGrabbed;
            }
            catch (Exception excpt)
            {
                //MessageBox.Show(excpt.Message);
            }

            Form.CheckForIllegalCrossThreadCalls = false;
        }

        public static Wpf.Vector RotatePoint(double angle, Wpf.Vector b, Wpf.Vector center)
        {
            var a = angle * System.Math.PI / 180.0;
            double cosa = Math.Cos(a);
            double sina = Math.Sin(a);
            Wpf.Vector newVector = new Wpf.Vector(((b.X - center.X) * cosa ) - ((b.Y - center.Y) * sina), ((b.X - center.X) * sina + (b.Y - center.Y) * cosa));

            newVector.X += center.X;
            newVector.Y += center.Y;

            return newVector;
        }

        private void ParsePadOffset(string m_Line)
        {
            m_Line = m_Line.Replace("PadOffset=", "");
            m_Line = m_Line.Replace(";", "");
            string[] m_Split = m_Line.Split(':');
            string m_Pad = m_Split[0];
            double m_X = Convert.ToDouble(m_Split[1]);
            double m_Y = Convert.ToDouble(m_Split[2]);

            try
            {
                TabPage m_Page = this.Jobs_Tab.SelectedTab;
                ElementHost m_Host = null;
                ExcellonPanel m_Panel = null;

                foreach (TabPage m_Current in this.Jobs_Tab.TabPages)
                {
                    if (m_Page.Controls.Find("elementHost", false).Length > 0)
                    {
                        m_Host = m_Page.Controls[0] as ElementHost;
                        m_Panel = m_Host.Child as ExcellonPanel;

                        if (m_Panel.ASample == null || m_Panel.BSample == null || m_Panel.CSample == null)
                            break;
                        else
                            continue;
                    }
                    else
                        continue;
                }

                if (m_Pad == "0")
                {
                    m_Panel.ASample = new Wpf.Vector(m_X, m_Y);
                    m_Panel.BSample = null;
                    m_Panel.CSample = null;
                }
                else if (m_Pad == "1")
                {
                    m_Panel.BSample = new Wpf.Vector(m_X, m_Y);

                }
                else if (m_Pad == "2")
                {

                    m_Panel.CSample = new Wpf.Vector(m_X, m_Y);

                    this.Start_Button.Enabled = true;
                }


                m_Panel.CheckSamples();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void ParseZMaxOffset(string m_Line)
        {
            m_Line = m_Line.Replace("ZMaxOffset=", "").Replace(";", "");
            ulong m_MaxStep = Convert.ToUInt64(m_Line);

            Settings.Default.Reload();
            Settings.Default.ZMaxOffset = m_MaxStep;
            Settings.Default.ZLastValue = Settings.Default.ZMaxOffset - 1000;
            Settings.Default.Save();

            this.ZMaxNum.Value = Units.StepsToMilimeter(Settings.Default.ZMaxOffset);
            this.ZLastNum.Value = Units.StepsToMilimeter(Settings.Default.ZLastValue);

            Core.ApplySettings();
        }

        private void Drill()
        {
            //if (Core.Controller.DrillState == DrillState.MoveFinished)
            //{
                Core.Controller.Send(string.Format("Drill={0};", Settings.Default.ZLastValue + Settings.Default.ZDrillValue));
            //}
        }

        private void Lift()
        {
            //if (Core.Controller.DrillState == DrillState.DrillFinished)
            //{
                Core.Controller.Send(string.Format("Lift={0};", (Settings.Default.ZLastValue + Settings.Default.ZDrillValue) - Settings.Default.ZLiftValue));
            //}
        }

        private void Connect_Button_Click(object sender, EventArgs e)
        {
            if (Controller.IsConnected)
                Core.Controller.Disconnect();

            if (Controller.IsConnected == false)
            {
                string portName = this.Ports_Combo.SelectedItem.ToString();
                int baudRate = Convert.ToInt32(this.Baud_Combo.SelectedItem.ToString());

                try
                {
                    Core.Controller.Connect(portName, baudRate);
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                finally
                {
                    if (Controller.IsConnected)
                    {
                        MessageBox.Show("Bağlantı başarılı :)", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {

                    }
                }
            }
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            Global_Timer_Tick(sender, e);
            Settings.Default.Reload();


            using(DafcamEntities m_Context = new DafcamEntities())
            {
                Core.Controller = m_Context.Controllers.FirstOrDefault();

                if (Core.Controller == null)
                {
                    Core.Controller = new Controller();
                    Core.Controller.Name = "Controller #1";
                    m_Context.Controllers.Add(Core.Controller);

                    try
                    {
                        m_Context.SaveChanges();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                    }
                }

                Core.Spindle = m_Context.Spindles.Include(q => q.CurrentBit).Include(q => q.TargetBit).FirstOrDefault();

                if (Core.Spindle == null)
                {
                    Core.Spindle = new Spindle();
                    Core.Spindle.Name = "Spindle #1";
                    m_Context.Spindles.Add(Core.Spindle);
                    
                    m_Context.SaveChanges();
                }
            }

            this.Scale_Num.Value = Convert.ToDecimal(Settings.Default.Scale);

            this.ZMaxNum.Value = Units.StepsToMilimeter(Settings.Default.ZMaxOffset);
            this.ZLastNum.Value = Units.StepsToMilimeter(Settings.Default.ZLastValue);
            this.ZLiftNum.Value = Units.StepsToMilimeter(Settings.Default.ZLiftValue);
            this.ZDrillNum.Value = Units.StepsToMilimeter(Settings.Default.ZDrillValue);


            this.Ports_Combo.Items.Clear();

            string[] m_PortNames = SerialPort.GetPortNames();

            foreach (string m_Port in m_PortNames)
            {
                this.Ports_Combo.Items.Add(m_Port);

            }

            this.Ports_Combo.SelectedIndex = 0;
            this.Baud_Combo.SelectedIndex = 10;

            
            EventManager.CommandAcquired += EventManager_CommandAcquired;
            EventManager.ZMaxOffsetChanged += EventManager_ZMaxOffsetChanged;
            EventManager.PadOffsetChanged += EventManager_PadOffsetChanged;
            EventManager.MoveFinished += EventManager_MoveFinished;
            EventManager.DrillFinished += EventManager_DrillFinished;
            EventManager.SpindleToolChanged += EventManager_SpindleToolChanged;
            EventManager.SpindleStateChanged += EventManager_SpindleStateChanged;
            AutoToolChanging.Initialize();
        }

        void EventManager_SpindleStateChanged()
        {
            switch (Core.Spindle.SpindleState)
            {
                case SpindleState.Idle:
                    {
                        this.SpindleState_Label.Text = "Bekliyor";
                        break;
                    }

                case SpindleState.EquippingTool:
                    {
                        this.SpindleState_Label.Text = "Yeni uç alıyor";
                        break;
                    }

                case SpindleState.UnequippingTool:
                    {
                        this.SpindleState_Label.Text = "Ucu bırakıyor";
                        break;
                    }
            }
        }

        void EventManager_SpindleToolChanged(Bit bit)
        {
            if (Core.Spindle.CurrentBit != null && this.ProgramState == Dafcam.ProgramState.Waiting)
            {
                this.Resume();
            }

            if (Core.Spindle.CurrentBit != null)
                this.CurrentBit_Label.Text = string.Format("{0}", Core.Spindle.CurrentBit.Name);
            else
                this.CurrentBit_Label.Text = "Boş";
        }

        void EventManager_CommandAcquired(string command)
        {
            this.Incoming_Box.Text = command + Environment.NewLine + this.Incoming_Box.Text;
        }

        void EventManager_ZMaxOffsetChanged(string data)
        {
            this.ParseZMaxOffset(data);
        }

        void EventManager_PadOffsetChanged(string data)
        {
            this.ParsePadOffset(data);
        }

        void EventManager_DrillFinished()
        {
            Lift();
        }

        private void EventManager_MoveFinished()
        {
            if (Core.Spindle.SpindleState == SpindleState.Idle)
            {
                if (this.CurrentCoordinate != null)
                {
                    this.CurrentPadIndex++;
                }

                Drill();
            }
            else
            {
                Core.Controller.DrillState = DrillState.Ready;
            }
        }

        Thread m_JobThread = null;

        private void Start_Button_Click(object sender, EventArgs e)
        {
            if (this.ProgramState == Dafcam.ProgramState.Idle)
            {
                if (!this.Layouts.TrueForAll(q => q.ASample.HasValue /*&& q.BSample.HasValue && q.CSample.HasValue*/))
                {
                    MessageBox.Show("Offset almadığınız çalışmalar var, kontrol edin!");
                }
                else
                {
                    Core.ApplySettings();
                    this.Start();
                }
            }
            else if (this.ProgramState == Dafcam.ProgramState.Waiting)
            {
                this.Resume();
            }

            else if (this.ProgramState == Dafcam.ProgramState.Working)
            {
                this.Suspend();
            }
        }

        ManualResetEvent m_Event = new ManualResetEvent(true);

        private void Start()
        {
            ProgramState = Dafcam.ProgramState.Working;

            Core.Spindle = m_Context.Spindles.FirstOrDefault();

            if (Core.Spindle != null)
                Core.Spindle.Run();

            ThreadStart m_Start = new ThreadStart(SendNextJob);
            m_JobThread = new Thread(m_Start);
            m_JobThread.IsBackground = true;
            m_JobThread.Start();
            m_Event.Set();

            this.Start_Button.Text = "Durdur";
            this.Start_Button.Image = Dafcam.Properties.Resources.control_pause_blue;

        }

        private void Resume()
        {
            m_Event.Set();

            if (Core.Spindle != null)
                Core.Spindle.Run();

            this.ProgramState = Dafcam.ProgramState.Working;
            this.Start_Button.Text = "Durdur";
            this.Start_Button.Image = Dafcam.Properties.Resources.control_pause_blue;
        }

        private void Suspend()
        {
            m_Event.Reset();
            this.ProgramState = Dafcam.ProgramState.Waiting;

            if (Core.Spindle != null)
                Core.Spindle.Stop();

            this.Start_Button.Text = "Devam";
            this.Start_Button.Image = Dafcam.Properties.Resources.control_play_blue;
        }

        private void Stop()
        {
            this.ProgramState = Dafcam.ProgramState.Idle;
            m_Event.Reset();

            if (Core.Spindle != null)
                Core.Spindle.Stop();

            if (Core.Controller != null)
                Core.Controller.DrillState = DrillState.Ready;

            this.Start_Button.Text = "Başlat";
            this.Start_Button.Image = Dafcam.Properties.Resources.control_play_blue;
        }

        private void ResetPosition()
        {
            Core.Controller.Send(string.Format("Reset={0}:{1}:{2};", 0, 0, 0));
        }

        private void ResetZAxis()
        {
            Core.Controller.Send(string.Format("ResetZ={0};", 0));
        }

        private void SetHome()
        {
            Core.Controller.Send("SetHome;");
        }

        private void SendNextJob()
        {
            while (ProgramState == ProgramState.Working)
            {
                m_Event.WaitOne();

                int m_TotalPads = this.Layouts.Sum(q => q.DrillPads.Count);
                int m_DrilledPads = 0;

                this.Status_Strip.Invoke((MethodInvoker)delegate()
                {
                    this.PadCounterLabel.Text = string.Format("Delinen/Toplam: {0}/{1}", m_DrilledPads, m_TotalPads);
                    this.PercentageLabel.Text = "%0";
                    this.PercentageBar.Value = 0;

                    this.PadCounterLabel.Visible = true;
                    this.PercentageBar.Visible = true;
                    this.PercentageLabel.Visible = true;
                });

                this.Layouts.ForEach(delegate(ExcellonPanel m_Panel)
                {
                    var angle = m_Panel.RotationAngle;

                    Wpf.Vector m_Theresold = m_Panel.AReal.Value; // RotatePoint(angle, new Wpf.Vector(m_Panel.AReal.Value.X, m_Panel.AReal.Value.Y), new Wpf.Vector(0, 0));
                    var m_NewBase = new Wpf.Vector(m_Panel.ASample.Value.X - m_Theresold.X, m_Panel.ASample.Value.Y - m_Theresold.Y);

                    this.CurrentExcellon = m_Panel;
                    int m_PadIndex = 0;

                    string m_CurrentToolKey = "";

                        m_Panel.DrillPads.ForEach(delegate(DrillPad m_Pad)
                        {
                            while (true)
                            {
                                m_Event.WaitOne();

                                if (m_CurrentToolKey != m_Pad.BaseToolKey)
                                {
                                    double m_TargetDiameter = 0.0;

                                    m_TargetDiameter = m_Panel.GetTargetDiameterFor(m_Pad.BaseToolKey);


                                    if (Core.Spindle.CurrentBit == null || Core.Spindle.CurrentBit.OuterDiameter != m_TargetDiameter)
                                    {
                                        Bit m_Bit = m_Context.Bits.Where(q => q.OuterDiameter == m_TargetDiameter).FirstOrDefault();

                                        if (m_Bit == null)
                                            m_Bit = m_Context.Bits.OrderBy(q => q.OuterDiameter).FirstOrDefault();

                                        if (m_Bit != null)
                                        {
                                            this.Suspend();

                                            Core.Spindle.Equip(m_Bit);

                                            while (true)
                                            {
                                                if (Core.Spindle.CurrentBitID != null && Core.Spindle.CurrentBitID == m_Bit.ID)
                                                    break;

                                                Application.DoEvents();
                                            }
                                        }
                                        else
                                        {
                                            break; // we dont have that tool or any suitable tool
                                        }
                                    }
                                }


                                if (Core.Spindle.SpindleState == SpindleState.Idle)
                                {
                                    if (Core.Controller.DrillState == Dafcam.DrillState.Ready || Core.Controller.DrillState == DrillState.LiftFinished)
                                    {
                                        this.CurrentCoordinate = m_Pad.Position;
                                        Wpf.Vector m_Target = new Wpf.Vector(this.CurrentCoordinate.X, this.CurrentCoordinate.Y);
                                        m_Target = RotatePoint(angle, m_Target, m_Panel.AReal.Value);
                                        //m_Pad.TargetPosition = m_Target;


                                        Core.Controller.Send(string.Format("Move={0}:{1};", m_NewBase.X + m_Target.X /*+ 2369*/, m_NewBase.Y + m_Target.Y /*+ 56189*/));
                                        
                                        Core.Controller.DrillState = DrillState.MoveStarted;
                                        m_PadIndex++;
                                        m_DrilledPads++;
                                        this.PadCounterLabel.Text = string.Format("Delinen/Toplam: {0}/{1}", m_DrilledPads, m_TotalPads);
                                        int m_PercentageValue = Convert.ToInt32(((double)m_DrilledPads / (double)m_TotalPads) * 100);
                                        this.PercentageLabel.Text = string.Format("%{0:00}", m_PercentageValue);
                                        this.PercentageBar.Value = m_PercentageValue;

                                        Thread.Sleep(50);
                                        break;
                                    }
                                }
                            }

                        });
                    
                });

                while (true)
                {
                    m_Event.WaitOne();

                    if (Core.Controller.DrillState == Dafcam.DrillState.Ready)
                    {
                        ResetZAxis();
                        
                        break;
                    }
                }


                this.Status_Strip.Invoke((MethodInvoker) delegate()
                {
                    this.PadCounterLabel.Text = string.Format("Delinen/Toplam: 0/0");
                    this.PercentageLabel.Text = "%0";
                    this.PercentageBar.Value = 0;
                    this.PercentageBar.Visible = false;
                    this.PercentageLabel.Visible = false;
                    this.PadCounterLabel.Visible = false;
                });

                this.Stop();
                break;
            }
        }


        private void Scale_Num_ValueChanged(object sender, EventArgs e)
        {
            Properties.Settings.Default.Scale = Convert.ToDouble(this.Scale_Num.Value);
            Properties.Settings.Default.Save();

        }

        private void Home_Button_Click(object sender, EventArgs e)
        {
            this.SetHome();
        }

        private void Reset_Button_Click(object sender, EventArgs e)
        {
            this.ResetPosition();
        }

        bool m_StopButtonPress = false;

        Thread m_PressorThread = null;

        private void Zminus_Button_MouseDown(object sender, MouseEventArgs e)
        {
            m_StopButtonPress = false;
            m_PressorThread = new Thread(() =>
            {
                while (m_StopButtonPress == false)
                {
                    Core.Controller.Send("Jog=Z:-500;");
                    m_StopButtonPress = true;
                }
            });

            m_PressorThread.Start();
        }

        private void Zminus_Button_MouseUp(object sender, MouseEventArgs e)
        {
            m_StopButtonPress = true;
            m_PressorThread.Join();
        }

        private void Zplus_Button_MouseDown(object sender, MouseEventArgs e)
        {
            m_StopButtonPress = false;
            m_PressorThread = new Thread(() =>
            {
                while (m_StopButtonPress == false)
                {
                    Core.Controller.Send("Jog=Z:+250;");
                    m_StopButtonPress = true;
                }
            });

            m_PressorThread.Start();
        }

        private void Zplus_Button_MouseUp(object sender, MouseEventArgs e)
        {
            m_StopButtonPress = true;
            m_PressorThread.Join();
        }

        private void Xplus_Button_MouseDown(object sender, MouseEventArgs e)
        {
            m_StopButtonPress = false;
            m_PressorThread = new Thread(() =>
            {
                while (m_StopButtonPress == false)
                {
                    Core.Controller.Send("Jog=X:+10000;");
                    m_StopButtonPress = true;
                }
            });

            m_PressorThread.Start();
        }

        private void Xplus_Button_MouseUp(object sender, MouseEventArgs e)
        {
            m_StopButtonPress = true;
            m_PressorThread.Join();
        }

        private void Yplus_Button_MouseDown(object sender, MouseEventArgs e)
        {
            m_StopButtonPress = false;
            m_PressorThread = new Thread(() =>
            {
                while (m_StopButtonPress == false)
                {
                    Core.Controller.Send("Jog=Y:+10000;");
                    m_StopButtonPress = true;
                }
            });

            m_PressorThread.Start();
        }

        private void Yplus_Button_MouseUp(object sender, MouseEventArgs e)
        {
            m_StopButtonPress = true;
            m_PressorThread.Join();
        }

        private void Xminus_Button_MouseDown(object sender, MouseEventArgs e)
        {
            m_StopButtonPress = false;
            m_PressorThread = new Thread(() =>
            {
                while (m_StopButtonPress == false)
                {
                    Core.Controller.Send("Jog=X:-10000;");
                    m_StopButtonPress = true;
                }
            });

            m_PressorThread.Start();
        }

        private void Xminus_Button_MouseUp(object sender, MouseEventArgs e)
        {
            m_StopButtonPress = true;
            m_PressorThread.Join();
        }

        private void Yminus_Button_MouseDown(object sender, MouseEventArgs e)
        {
            m_StopButtonPress = false;
            m_PressorThread = new Thread(() =>
            {
                while (m_StopButtonPress == false)
                {
                    Core.Controller.Send("Jog=Y:-10000;");
                    m_StopButtonPress = true;
                }
            });

            m_PressorThread.Start();
        }

        private void Yminus_Button_MouseUp(object sender, MouseEventArgs e)
        {
            m_StopButtonPress = true;
            m_PressorThread.Join();
        }

        private void Zoom_Combo_SelectedIndexChanged(object sender, EventArgs e)
        {
                
        }

        private void GoZMax_Button_Click(object sender, EventArgs e)
        {
            Settings.Default.Reload();

            if (Core.Controller.DrillState == Dafcam.DrillState.Ready)
            {
                Core.Controller.Send("Jog=ZMax:" + Settings.Default.ZLastValue + ";");
            }
        }

        private void ZLiftNum_ValueChanged(object sender, EventArgs e)
        {
            Settings.Default.ZLiftValue = Units.MillimeterToSteps(this.ZLiftNum.Value);
            Settings.Default.Save();
        }

        private void ZDrillNum_ValueChanged(object sender, EventArgs e)
        {
            Settings.Default.ZDrillValue = Units.MillimeterToSteps(this.ZDrillNum.Value);
            Settings.Default.Save();
        }

        private void çıkışToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void New_Layout_Button_Click(object sender, EventArgs e)
        {
            if (ExcellonDialog.ShowDialog() == DialogResult.OK)
            {
                string m_Data = "";

                using (StreamReader m_Reader = new StreamReader(ExcellonDialog.FileName))
                {
                    m_Data = m_Reader.ReadToEnd();
                }

                string[] m_Parsed = m_Data.Split('\n');
                int m_Count = m_Parsed.Length;

                Dictionary<string, double> m_Tools = new Dictionary<string, double>();

                for (int i = 0; i < m_Count; i++)
                {
                    if (!m_Parsed[i].StartsWith("T"))
                        continue;
                    else
                    {
                        string m_Line = m_Parsed[i];

                        if (m_Line.Contains('\t'))
                        {
                            string m_Symbol = m_Line.Split('\t')[0];
                            string m_Value = m_Line.Split('\t')[1].Split(' ')[0];
                            double d_Value = 0.0;

                            if (m_Value.EndsWith("th"))
                            {
                                d_Value = double.Parse(m_Value.Replace("th", "").Replace(".", ","));

                                /*
                                 * mm = in  / 0.039370
                                 * 
                                 * 
                                 * 0.7mm * 0.039370 = in
                                 * 
                                 * 
                                 * 
                                 * 
                                 * 
                                 * 
                                 * T01	0.76mm (0-15)
T02	0.64mm (0-15)
T03	0.38mm (0-15)
T04	1.65mm (0-15)
T05	1.02mm (0-15)
T06	1.14mm (0-15)
T07	1.78mm (0-15)

                                 */

                                d_Value = (d_Value / 1000) / 0.039370;
                            }
                            else
                                d_Value = double.Parse(m_Value.Replace("mm", "").Replace(".", ","));

                            d_Value = Math.Round(d_Value, 2);

                            m_Tools.Add(m_Symbol, d_Value);
                        }
                    }
                }

                m_Data = "";
                m_Parsed = null;

                if (m_Tools.Count > 0)
                {
                    string m_ReadMeFile = this.ExcellonDialog.FileName;
                    string m_DrillFile = m_ReadMeFile.Replace("READ-ME", "Drill");

                    using (StreamReader m_Reader = new StreamReader(m_DrillFile))
                    {
                        m_Data = m_Reader.ReadToEnd();
                    }
                }
                else
                    MessageBox.Show("Seçtiğiniz dosya formatı hatalı.", "Hata");

                m_Parsed = m_Data.Replace("\r", "").Split('\n');

                if (m_Parsed.Length > 0)
                {
                    List<DrillPad> m_Pads = new List<DrillPad>();
                    string m_CurrentToolKey = "";

                    foreach (string m_Line in m_Parsed)
                    {
                        if (m_Tools.Any(q => q.Key == m_Line))
                        {
                            m_CurrentToolKey = m_Line;

                            continue;
                        }

                        if (m_Line.StartsWith("X"))
                        {
                            string[] _Coordinates = m_Line.Split('Y');
                            double m_XPos = Convert.ToDouble(_Coordinates[0].Replace("X", "")) * Settings.Default.Scale;
                            double m_YPos = Convert.ToDouble(_Coordinates[1].Replace("\r", "")) * Settings.Default.Scale;

                            DrillPad m_Pad = new DrillPad();
                            m_Pad.Position = new Wpf.Vector(m_XPos, m_YPos);
                            m_Pad.BaseToolKey = m_CurrentToolKey;
                            m_Pads.Add(m_Pad);
                        }
                    }

                    AddLayout(m_Pads, m_Tools);
                }
            }
        }

        private void AddLayout(List<DrillPad> m_Pads, Dictionary<string, double> m_ToolInfos)
        {
            ExcellonPanel m_Panel = new ExcellonPanel();
            m_Panel.DrillPads = m_Pads;
            m_Panel.ToolInfos = m_ToolInfos;

            AddLayout(m_Panel);
        }

        private void AddLayout(ExcellonPanel m_Panel)
        {
            TabPage m_Page = new TabPage();
            ElementHost m_Host = new ElementHost();
            m_Panel.InitializeComponent();
            m_Host.Child = m_Panel;
            m_Host.Dock = DockStyle.Fill;
            m_Host.Name = "elementHost";

            m_Page.Controls.Add(m_Host);
            m_Page.Text = "Çalışma - 1";

            this.Jobs_Tab.TabPages.Add(m_Page);
            m_Panel.DrawPads();
            m_Panel.CheckSamples();
            
            using(DafcamEntities m_Context = new DafcamEntities())
            {
                var m_Bits = m_Context.Bits.OrderBy(q => q.OuterDiameter).Select(q => q.OuterDiameter).ToList();
                m_Panel.SetDrillBits(m_Bits);
            }

            this.Layouts.Add(m_Panel);
            OrganizePages();
            this.Jobs_Tab.SelectedTab = m_Page;
        }

        private void OrganizePages()
        {
            int index = 0;
            this.Layouts.ForEach(delegate(ExcellonPanel m_Panel)
            {
                TabPage m_Page = null;
                ElementHost m_Host = null;

                var presentationSource = (HwndSource)System.Windows.PresentationSource.FromVisual(m_Panel);
                var parentHandle = presentationSource.Handle;

                if (parentHandle != null)
                {
                    m_Host = System.Windows.Forms.Control.FromChildHandle(parentHandle) as ElementHost;
                }

                m_Page = m_Host.Parent as TabPage;
                m_Page.Text = string.Format("Çalışma - {0}", index + 1);

                index++;
            });
        }

        private void Repeat_Layout_Button_Click(object sender, EventArgs e)
        {
            TabPage m_Page = this.Jobs_Tab.SelectedTab;
            ExcellonPanel m_Panel = (m_Page.Controls[0] as ElementHost).Child as ExcellonPanel;
            ExcellonPanel m_New = new ExcellonPanel();

            m_New.DrillPads = m_Panel.DrillPads;
            //m_New.AReal = m_Panel.AReal;
            /*m_New.BReal = m_Panel.BReal;
            m_New.CReal = m_Panel.CReal;*/

            AddLayout(m_New);
        }

        private void Delete_Layout_Button_Click(object sender, EventArgs e)
        {
            TabPage m_Page = this.Jobs_Tab.SelectedTab;

            if (m_Page.Controls.Find("elementHost", false).Length > 0)
            {
                ExcellonPanel m_Panel = (m_Page.Controls[0] as ElementHost).Child as ExcellonPanel;
                this.Layouts.Remove(m_Panel);
                this.Jobs_Tab.TabPages.Remove(m_Page);

                OrganizePages();
            }
        }

        private void Xminus_Button_Click(object sender, EventArgs e)
        {

        }

        private void ayarlarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SettingsForm m_Form = new SettingsForm();
            m_Form.SettingsChanged += Form_SettingsChanged;
            m_Form.ShowDialog();
        }

        void Form_SettingsChanged()
        {
            Core.ApplySettings();
        }

        private void takımlarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ToolsForm m_Form = new ToolsForm();
            m_Form.ShowDialog();
        }

        private void Global_Timer_Tick(object sender, EventArgs e)
        {
            //World.Save();
        }

        private void GoZFirst_Button_Click(object sender, EventArgs e)
        {
            Settings.Default.Reload();

            if (Core.Controller.DrillState == Dafcam.DrillState.Ready)
            {
                Core.Controller.Send("Jog=ZMax:" + 0 + ";");
            }
        }

        bool m_Running = false;

        private void SpindleToggle_Button_Click(object sender, EventArgs e)
        {
            if (m_Running)
            {
                Core.Spindle.Stop();
                m_Running = false;
            }
            else
            {
                Core.Spindle.Run();
                m_Running = true;
            }
        }

        private void Camera_Toggle_Click(object sender, EventArgs e)
        {
            if (m_EmguCam != null)
            {
                if (m_IsCapturing)
                {  //stop the capture
                    this.Camera_Toggle.Text = "Kamera: Kapalı";
                    m_EmguCam.Pause();
                }
                else
                {
                    //start the capture
                    this.Camera_Toggle.Text = "Kamera: Açık";
                    m_EmguCam.Start();
                }

                m_IsCapturing = !m_IsCapturing;
            }
        }

        void EmguCam_ImageGrabbed(object sender, EventArgs e)
        {
            Image<Bgr, Byte> frame = m_EmguCam.RetrieveBgrFrame();
            Image<Gray, Byte> grayFrame = frame.Convert<Gray, Byte>();

            Image<Gray, byte> Img_Source_Gray = grayFrame.Clone().Xor(new Gray(300));
            Image<Bgr, byte> Img_Result_Bgr = new Image<Bgr, byte>(Img_Source_Gray.Width, Img_Source_Gray.Height);
            CvInvoke.cvCvtColor(Img_Source_Gray.Ptr, Img_Result_Bgr.Ptr, Emgu.CV.CvEnum.COLOR_CONVERSION.GRAY2BGR);
            Gray cannyThreshold = new Gray(Convert.ToInt32(this.numericUpDown1.Value));
            Gray circleAccumulatorThreshold = new Gray(Convert.ToInt32(this.numericUpDown2.Value));
            double Resolution = 1;
            double MinDistance = 100.0;
            int MinRadius = 10;
            int MaxRadius = 80;

            CircleF[] HoughCircles = Img_Source_Gray.Clone().HoughCircles(
                                    cannyThreshold,
                                    circleAccumulatorThreshold,
                                    Resolution, //Resolution of the accumulator used to detect centers of the circles
                                    MinDistance, //min distance 
                                    MinRadius, //min radius
                                    MaxRadius //max radius
                                    )[0]; //Get the circles from the first channel
            #region draw circles
            foreach (CircleF circle in HoughCircles)
            {

                frame.Draw(circle, new Bgr(Color.Blue), 2);

            }

            Point start1 = new Point(frame.Width / 2, 0);
            Point second1 = new Point(frame.Width / 2, frame.Height);

            Point start2 = new Point(0, frame.Height / 2);
            Point second2 = new Point(frame.Width, frame.Height / 2);

            LineSegment2D line=new LineSegment2D(start1,second1);
            LineSegment2D line2 = new LineSegment2D(start2, second2);

            frame.Draw(line, new Bgr(Color.Magenta), 1);
            frame.Draw(line2, new Bgr(Color.Magenta), 1);

            PointF m_Center = new PointF((float)(frame.Width / 2), (float)(frame.Height / 2));
            CircleF m_Circle = new CircleF(m_Center, 50);
            frame.Draw(m_Circle, new Bgr(Color.Magenta), 1);
            #endregion

            this.opticBox1.Image = frame;
            Thread.Sleep(10);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Core.Controller.Send("Jog=X:+2369;");
            Thread.Sleep(2000);
            Core.Controller.Send("Jog=Y:+56189;");
            Thread.Sleep(2000);
        }

        private void motorlarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MotorsForm m_Form = new MotorsForm();
            m_Form.ShowDialog();
        }
    }
}
