using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace BatteryInfo
{
    public partial class BatteryInfoForm : Form
    {
        public BatteryInfoForm()
        {
            InitializeComponent();
        }
        public void UpdateFormData()
        {
            chargeLevelLabel.Text = String.Format("{0:0.00}", Battery.Percent) + " %";
            if ((Battery.ConnectionType == PowerLineStatus.Online))
            {
                connectionTypeLabel.Text = "AC";
                remainingTimeLabel.Text = "N/A in AC mode";
            }
            else
            {
                connectionTypeLabel.Text = "Battery";
                remainingTimeLabel.Text = (Battery.RemainingTime.ToString() + " min");
            }
        }
    }
}
