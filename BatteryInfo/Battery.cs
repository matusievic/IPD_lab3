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
        private static Battery instance;

        private double _percent;
        private PowerLineStatus _connectionType;
        private UInt32 _remainingTime;

        public double Percent
        { get { return _percent; } }
        public PowerLineStatus ConnectionType
        { get { return _connectionType; } }
        public UInt32 RemainingTime
        { get { return _remainingTime; } }

        /// <summary>
        /// This method gets information about the battery using WMI
        /// </summary>
        public void UpdateData() {
            _percent = SystemInformation.PowerStatus.BatteryLifePercent * 100;
            _connectionType = SystemInformation.PowerStatus.PowerLineStatus;
            var seacher = new ManagementObjectSearcher("SELECT * FROM Win32_Battery").Get();
            foreach (var property in seacher)
            {
                _remainingTime = (UInt32)property["EstimatedRunTime"];
            }
        }

        private Battery()
        {
            UpdateData();
        }

        public static Battery GetInstance()
        {
            if (instance == null)
                instance = new Battery();
            return instance;
        }
    }
}
