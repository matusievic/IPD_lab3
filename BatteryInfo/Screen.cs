using System;
using System.Collections.Generic;
using System.Linq;
using System.Diagnostics;
using System.Text.RegularExpressions;
using System.Runtime.InteropServices;
using System.Threading;
using System.Windows.Forms;
using System.Text;

namespace BatteryInfo
{
    class Screen
    {
        private static Screen _instance;
        public int InitialTime { get; private set; }

        private Screen()
        { }
        public static Screen GetInstance()
        {
            if (_instance == null)
            {
                _instance = new Screen();
                _instance.InitialTime = _instance.GetInitialTime();
            }
            return _instance;
        }

        /// <summary>
        /// This method gets an initial screen turn off time value
        /// </summary>
        /// <returns>initial time in minutes</returns>
        private int GetInitialTime()
        {
            var сmd = new Process();
            сmd.StartInfo.UseShellExecute = false;
            сmd.StartInfo.RedirectStandardOutput = true;
            сmd.StartInfo.StandardOutputEncoding = Encoding.GetEncoding(866);
            сmd.StartInfo.FileName = "cmd.exe";
            сmd.StartInfo.Arguments = "/c powercfg /q";
            сmd.StartInfo.WindowStyle = ProcessWindowStyle.Hidden;
            сmd.Start();

            var hexSecString = сmd.StandardOutput.ReadToEnd().Split("GUID".ToCharArray()).
                Single(s => s.Contains("Отключать экран через")).
                Split("\r\n".ToCharArray())[12].Split(' ').Last();

            return Convert.ToInt32(hexSecString, 16) / 60;
        }

        /// <summary>
        /// This method changes screen turn off time when a computer works in a battery mode
        /// </summary>
        /// <param name="time">new time in minutes</param>
        public void SetSwitchingTime(int time)
        {
            var cmd = new Process();
            cmd.StartInfo.FileName = "cmd.exe";
            cmd.StartInfo.Arguments = "/c powercfg /x -monitor-timeout-dc " + time;
            cmd.StartInfo.WindowStyle = ProcessWindowStyle.Hidden;
            cmd.Start();
        }
    }
}
