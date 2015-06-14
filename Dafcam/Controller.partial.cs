using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.IO.Ports;
using System.Linq;
using System.Text;
using System.Threading;
using System.Windows.Forms;
using System.Windows.Media.Media3D;

namespace Dafcam
{
    public enum DrillState
    {
        Ready           = 0,
        MoveStarted     = 1,
        MoveFinished    = 2,
        DrillStarted    = 3,
        DrillFinished   = 4,
        LiftStarted     = 5,
        LiftFinished    = 0,
        ResetStarted    = 7,
        ResetFinished   = 0,
        JogStarted      = 9,
        JogFinished     = 0,
    }

    public partial class Controller
    {

        private DrillState m_DrillState = DrillState.Ready;
        private static SerialPort m_Port = null;

        [NotMapped]
        public DrillState DrillState { get { return m_DrillState; } set { m_DrillState = value; } }
        
        [NotMapped]
        public string Model { get; set; }

        [NotMapped]
        public static SerialPort Port
        {
            get { return m_Port; }
            set
            {
                m_Port = value;

                if (value != null)
                    Port.DataReceived += Port_DataReceived;
                else
                    Port.DataReceived -= Port_DataReceived;
            }
        }

        public Controller()
        {
            EventManager.ReadyChanged -= EventManager_ReadyChanged;
            EventManager.MoveStarted -= EventManager_MoveStarted;
            EventManager.MoveFinished -= EventManager_MoveFinished;
            EventManager.DrillStarted -= EventManager_DrillStarted;
            EventManager.DrillFinished -= EventManager_DrillFinished;
            EventManager.LiftStarted -= EventManager_LiftStarted;
            EventManager.LiftFinished -= EventManager_LiftFinished;
            EventManager.ResetStarted -= EventManager_ResetStarted;
            EventManager.ResetFinished -= EventManager_ResetFinished;
            EventManager.JogStarted -= EventManager_JogStarted;
            EventManager.JogFinished -= EventManager_JogFinished;

            EventManager.ReadyChanged += EventManager_ReadyChanged;
            EventManager.MoveStarted += EventManager_MoveStarted;
            EventManager.MoveFinished += EventManager_MoveFinished;
            EventManager.DrillStarted += EventManager_DrillStarted;
            EventManager.DrillFinished += EventManager_DrillFinished;
            EventManager.LiftStarted += EventManager_LiftStarted;
            EventManager.LiftFinished += EventManager_LiftFinished;
            EventManager.ResetStarted += EventManager_ResetStarted;
            EventManager.ResetFinished += EventManager_ResetFinished;
            EventManager.JogStarted += EventManager_JogStarted;
            EventManager.JogFinished += EventManager_JogFinished;
        }

        void EventManager_JogFinished()
        {
            this.DrillState = Dafcam.DrillState.JogFinished;
        }

        void EventManager_JogStarted()
        {
            this.DrillState = Dafcam.DrillState.JogStarted;
        }

        void EventManager_ResetFinished()
        {
            this.DrillState = Dafcam.DrillState.ResetFinished;
        }

        void EventManager_ResetStarted()
        {
            this.DrillState = Dafcam.DrillState.ResetStarted;
        }

        void EventManager_LiftFinished()
        {
            this.DrillState = Dafcam.DrillState.LiftFinished;
        }

        void EventManager_LiftStarted()
        {
            this.DrillState = Dafcam.DrillState.LiftStarted;
        }

        void EventManager_DrillFinished()
        {
            this.DrillState = Dafcam.DrillState.DrillFinished;
        }

        void EventManager_DrillStarted()
        {
            this.DrillState = Dafcam.DrillState.DrillStarted;
        }

        void EventManager_MoveFinished()
        {
            this.DrillState = Dafcam.DrillState.MoveFinished;
        }

        void EventManager_MoveStarted()
        {
            this.DrillState = Dafcam.DrillState.MoveStarted;
        }

        void EventManager_ReadyChanged()
        {
            this.DrillState = Dafcam.DrillState.Ready;
        }

        private static void Port_DataReceived(object sender, SerialDataReceivedEventArgs e)
        {
            if (IsConnected)
            {
                try
                {
                    while (Port.BytesToRead != 0)
                    {
                        string m_Line = Port.ReadLine();


                        EventManager.InvokeCommandAcquired(m_Line);

                        m_Line = m_Line.Replace("\r\n", "").Replace("\n", "").Trim().Replace(Environment.NewLine, "");

                        if (m_Line.StartsWith("PadOffset"))
                            EventManager.InvokePadOffsetChanged(m_Line);
                        else if (m_Line.StartsWith("ZMaxOffset"))
                            EventManager.InvokeZMaxOffsetChanged(m_Line);
                        else if (m_Line.StartsWith("CurrentPos"))
                        {
                            m_Line = m_Line.Replace("CurrentPos=", "").Replace(";", "");
                            string[] m_Split = m_Line.Split(':');
                            Vector3D pos = new Vector3D();
                            pos.X = Convert.ToDouble(m_Split[0]);
                            pos.Y = Convert.ToDouble(m_Split[1]);
                            pos.Z = Convert.ToDouble(m_Split[2]);

                            EventManager.InvokeCurrentPositionChanged(pos);
                        }
                        else
                        {
                            switch (m_Line)
                            {
                                case "State: Ready":
                                    {
                                        EventManager.InvokeReadyChanged();

                                        break;
                                    }
                                case "Move: Started":
                                    {
                                        EventManager.InvokeMoveStarted();

                                        break;
                                    }
                                case "Move: Completed":
                                    {
                                        EventManager.InvokeMoveFinished();

                                        break;
                                    }
                                case "Drill: Started":
                                    {
                                        EventManager.InvokeDrillStarted();

                                        break;
                                    }

                                case "Drill: Completed":
                                    {
                                        EventManager.InvokeDrillFinished();

                                        break;
                                    }
                                case "Lift: Started":
                                    {
                                        EventManager.InvokeLiftStarted();

                                        break;
                                    }

                                case "Lift: Completed":
                                    {
                                        EventManager.InvokeLiftFinished();

                                        break;
                                    }
                                case "Reset: Started":
                                    {
                                        EventManager.InvokeResetStarted();

                                        break;
                                    }

                                case "ResetZ: Started":
                                    {
                                        EventManager.InvokeResetStarted();

                                        break;
                                    }

                                case "Reset: Completed":
                                    {
                                        EventManager.InvokeResetFinished();

                                        break;
                                    }

                                case "ResetZ: Completed":
                                    {
                                        EventManager.InvokeResetFinished();

                                        break;
                                    }

                                case "Jog: Started":
                                    {
                                        EventManager.InvokeJogStarted();

                                        break;
                                    }

                                case "Jog: Completed":
                                    {
                                        EventManager.InvokeJogFinished();

                                        break;
                                    }
                            }
                        }
                    }
                }
                catch (Exception ex)
                {
                    EventManager.InvokeError(ex.Message);
                }
            }
        }

        public static bool IsConnected
        {
            get
            {
                return Port != null ? Port.IsOpen : false;
            }
        }

        public void Connect(string portName, int baudRate)
        {
            try
            {
                this.Disconnect();
                Port = new SerialPort(portName, baudRate);
                Port.Open();
            }
            catch (Exception ex)
            {
                EventManager.InvokeError(ex.Message);
            }
        }

        public void Disconnect()
        {
            if (Port != null)
            {
                Port.Close();
            }
        }

        public void Send(string command)
        {
            Port.Write(command);
        }
    }
}
