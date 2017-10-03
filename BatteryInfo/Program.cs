using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace BatteryInfo
{
    static class Program
    {
        /// <summary>
        /// Главная точка входа для приложения.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            var batteryForm = new BatteryInfoForm();
            var updater = new UpdaterThread(batteryForm);
            updater.Start();
            Application.Run(batteryForm);
            updater.IsInterrupted = true;
        }
    }
}
