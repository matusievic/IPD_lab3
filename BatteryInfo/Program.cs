using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace BatteryInfo
{
    static class Program
    {
        /// <summary>
        /// Main application entry point.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            var batteryForm = new BatteryInfoForm();
            Application.Run(batteryForm);
        }
    }
}
