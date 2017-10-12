using System;
using System.Collections.Generic;
using System.Linq;
using System.Diagnostics;
using System.Text.RegularExpressions;
using System.Runtime.InteropServices;
using System.Threading;
using System.Windows.Forms;

namespace BatteryInfo
{
    class ScreenSwitcher
    {
        private Thread SwitcherThread;
        private static ScreenSwitcher Instance;

        private bool _isInterrupted;
        public bool IsInterrupted
        { set { _isInterrupted = value; } }

        private int _time;
        public int Time
        { set { _time = value; } }

        private ScreenSwitcher()
        { }
        public static ScreenSwitcher GetInstance()
        {
            if (Instance == null)
            {
                Instance = new ScreenSwitcher();
                Instance._time = Instance.GetDowntime();
                Instance.SwitcherThread = new Thread(Instance.ScreenSwitcherThread);
                Instance._isInterrupted = false;
                Instance.SwitcherThread.Start();
            }
            return Instance;
        }

        /// <summary>
        /// This is a thread-function that checks if it's necessary to turn off the screen, and turns off it
        /// </summary>
        private void ScreenSwitcherThread()
        {
            const int ONE_SECOND = 1000;
            while (!_isInterrupted)
            {
                var isNeedTurnOff = true;
                for (var i = 0; i < _time; i++)
                {
                    Thread.Sleep(ONE_SECOND);
                    if (GetDowntime() < 2)
                    {
                        isNeedTurnOff = false;
                        break;
                    }
                }
                if (isNeedTurnOff && Battery.GetInstance().ConnectionType == PowerLineStatus.Offline)
                {
                    TurnOffScreen();
                    do
                    { Thread.Sleep(ONE_SECOND); } while (GetDowntime() != 0);
                }
            }
        }

        [DllImport("user32.dll")]
        private static extern int SendMessage(int hWnd, int hMsg, int wParam, int lParam);

        /// <summary>
        /// This function turns off the screen
        /// </summary>
        private void TurnOffScreen()
        {
            const int TOP_LEVEL_WINDOW = 0xFFFF;
            const int MESSAGE = 0x112;
            const int PARAMS = 0xF170;
            const int OFF_SCREEN_PARAM = 2;
            SendMessage(TOP_LEVEL_WINDOW, MESSAGE, PARAMS, OFF_SCREEN_PARAM);
        }

        [StructLayout(LayoutKind.Sequential)]
        struct LASTINPUTINFO
        {
            public static readonly int SizeOf = Marshal.SizeOf(typeof(LASTINPUTINFO));

            [MarshalAs(UnmanagedType.U4)]
            public UInt32 cbSize;
            [MarshalAs(UnmanagedType.U4)]
            public UInt32 dwTime;
        }

        [DllImport("user32.dll")]
        static extern bool GetLastInputInfo(ref LASTINPUTINFO plii);

        /// <summary>
        /// This function calculates time, while a mouse and a keyboard are inactive
        /// </summary>
        /// <returns>Time in seconds</returns>
        private int GetDowntime()
        {
            var lastInputInfo = new LASTINPUTINFO();
            lastInputInfo.cbSize = (UInt32)Marshal.SizeOf(lastInputInfo);
            lastInputInfo.dwTime = 0;
            var envTicks = Environment.TickCount;

            var idleTime = 0;
            if (GetLastInputInfo(ref lastInputInfo))
            {
                var lastInputTick = (Int32)lastInputInfo.dwTime;
                idleTime = envTicks - lastInputTick;
            }

            return ((idleTime > 0) ? (idleTime / 1000) : 0);
        }
    }
}
