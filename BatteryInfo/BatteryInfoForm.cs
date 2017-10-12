using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Threading;

namespace BatteryInfo
{
    public partial class BatteryInfoForm : Form
    {
        private Battery PCBattery;
        private ScreenSwitcher PCScreen;
        private InformationUpdater Updater;

        public BatteryInfoForm()
        {
            InitializeComponent();
            PCBattery = Battery.GetInstance();
            PCScreen = ScreenSwitcher.GetInstance();
            Updater = new InformationUpdater(this);
            turnOffTimeComboBox.SelectedIndex = 0;
        }

        /// <summary>
        /// This method updates all data displayed on the application window
        /// </summary>
        public void UpdateFormData()
        {
            chargeLevelLabel.Text = String.Format("{0:0.00}", PCBattery.Percent) + " %";
            if ((PCBattery.ConnectionType == PowerLineStatus.Online))
            {
                connectionTypeLabel.Text = "AC";
                remainingTimeLabel.Text = "N/A in AC mode";
            }
            else
            {
                connectionTypeLabel.Text = "Battery";
                remainingTimeLabel.Text = (PCBattery.RemainingTime.ToString() + " min");
            }
        }

        private void turnOffTimeComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            PCScreen.Time = int.Parse(turnOffTimeComboBox.Text);
        }

        private void BatteryInfoForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            Updater.IsInterrupted = true;
            PCScreen.IsInterrupted = true;
        }
    }
}
