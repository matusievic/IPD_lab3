using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Management;

namespace BatteryInfo
{
    class Battery
    {
        private static double _percent;
        private static PowerLineStatus _connectionType;
        private static UInt32 _remainingTime;

        public static double Percent
        { get { return _percent; } }
        public static PowerLineStatus ConnectionType
        { get { return _connectionType; } }
        public static UInt32 RemainingTime
        { get { return _remainingTime; } }


        public Battery()
        {
            UpdateData();
        }

        public static void UpdateData() {
            _percent = SystemInformation.PowerStatus.BatteryLifePercent * 100;
            _connectionType = SystemInformation.PowerStatus.PowerLineStatus;
            //_remainingTime = SystemInformation.PowerStatus.BatteryLifeRemaining;
            var seacher = new ManagementObjectSearcher("SELECT * FROM Win32_Battery").Get();
            foreach (var property in seacher)
            {
                _remainingTime = (UInt32)property["EstimatedRunTime"];
            }
        }
    }
}
