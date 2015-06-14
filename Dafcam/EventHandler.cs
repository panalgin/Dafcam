using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Media.Media3D;

namespace Dafcam
{
    public static class EventManager
    {
        public delegate void OnConnected();
        public delegate void OnDisconnected();
        public delegate void OnError(string message);
        public delegate void OnCommandAcquired(string command);
        public delegate void OnCommandSent(string command);
        public delegate void OnPadOffsetChanged(string data);
        public delegate void OnZMaxOffsetChanged(string data);
        public delegate void OnCurrentPositionChanged(Vector3D pos);
        public delegate void OnReady();
        public delegate void OnMoveStarted();
        public delegate void OnMoveFinished();
        public delegate void OnDrillStarted();
        public delegate void OnDrillFinished();
        public delegate void OnLiftStarted();
        public delegate void OnLiftFinished();
        public delegate void OnResetStarted();
        public delegate void OnResetFinished();
        public delegate void OnJogStarted();
        public delegate void OnJogFinished();
        public delegate void OnSpindleToolChanged(Bit bit);
        public delegate void OnSpindleStateChanged();

        public static event OnConnected Connected;
        public static event OnDisconnected Disconnected;
        public static event OnError Error;
        public static event OnCommandAcquired CommandAcquired;
        public static event OnCommandSent CommandSent;
        public static event OnPadOffsetChanged PadOffsetChanged;
        public static event OnZMaxOffsetChanged ZMaxOffsetChanged;
        public static event OnCurrentPositionChanged CurrentPositionChanged;
        public static event OnReady ReadyChanged;
        public static event OnMoveStarted MoveStarted;
        public static event OnMoveFinished MoveFinished;
        public static event OnDrillStarted DrillStarted;
        public static event OnDrillFinished DrillFinished;
        public static event OnLiftStarted LiftStarted;
        public static event OnLiftFinished LiftFinished;
        public static event OnResetStarted ResetStarted;
        public static event OnResetFinished ResetFinished;
        public static event OnJogStarted JogStarted;
        public static event OnJogFinished JogFinished;
        public static event OnSpindleToolChanged SpindleToolChanged;
        public static event OnSpindleStateChanged SpindleStateChanged;

        public static void InvokeSpindleStateChanged() {
            if (SpindleStateChanged != null)
                SpindleStateChanged();
        }

        public static void InvokeSpindleToolChanged(Bit bit)
        {
            if (SpindleToolChanged != null)
                SpindleToolChanged(bit);
        }
        public static void InvokeJogFinished()
        {
            if (JogFinished != null)
                JogFinished();
        }

        public static void InvokeJogStarted()
        {
            if (JogStarted != null)
                JogStarted();
        }

        public static void InvokeResetFinished()
        {
            if (ResetFinished != null)
                ResetFinished();
        }

        public static void InvokeResetStarted()
        {
            if (ResetStarted != null)
                ResetStarted();
        }

        public static void InvokeLiftFinished()
        {
            if (LiftFinished != null)
                LiftFinished();
        }

        public static void InvokeLiftStarted()
        {
            if (LiftStarted != null)
                LiftStarted();
        }

        public static void InvokeDrillFinished()
        {
            if (DrillFinished != null)
                DrillFinished();
        }

        public static void InvokeDrillStarted()
        {
            if (DrillStarted != null)
                DrillStarted();
        }

        public static void InvokeMoveFinished()
        {
            if (MoveFinished != null)
                MoveFinished();
        }

        public static void InvokeMoveStarted()
        {
            if (MoveStarted != null)
                MoveStarted();
        }

        public static void InvokeReadyChanged()
        {
            if (ReadyChanged != null)
                ReadyChanged();
        }

        public static void InvokeCurrentPositionChanged(Vector3D pos)
        {
            if (CurrentPositionChanged != null)
                CurrentPositionChanged(pos);
        }

        public static void InvokeZMaxOffsetChanged(string data)
        {
            if (ZMaxOffsetChanged != null)
                ZMaxOffsetChanged(data);
        }

        public static void InvokePadOffsetChanged(string data)
        {
            if (PadOffsetChanged != null)
                PadOffsetChanged(data);
        }

        public static void InvokeConnected()
        {
            if (Connected != null)
                Connected();
        }

        public static void InvokeDisconnected()
        {
            if (Disconnected != null)
                Disconnected();
        }

        public static void InvokeError(string message)
        {
            if (Error != null)
                Error(message);
        }

        public static void InvokeCommandAcquired(string command)
        {
            if (CommandAcquired != null)
                CommandAcquired(command);
        }

        public static void InvokeCommandSent(string command)
        {
            if (CommandSent != null)
                CommandSent(command);
        }
    }
}
