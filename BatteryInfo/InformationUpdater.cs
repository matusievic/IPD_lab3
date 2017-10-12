using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Windows.Forms;

namespace BatteryInfo
{
    /// <summary>
    /// This is a class for the thread that updates all window information
    /// </summary>
    public class InformationUpdater
    {
        private Thread UpdaterThread;
        private BatteryInfoForm Form;

        private bool _isInterrupted;
        public bool IsInterrupted
        { set { _isInterrupted = value; } }

        public InformationUpdater(BatteryInfoForm form)
        {
            Form = form;
            UpdaterThread = new Thread(this.InformationUpdaterThread);
            _isInterrupted = false;
            UpdaterThread.Start();
        }

        /// <summary>
        /// This function updates window information by invoking UpdateData() method of a Battery object
        /// </summary>
        private void InformationUpdaterThread()
        {
            const int ONE_SECOND = 1000;
            while (!_isInterrupted)
            {
                Thread.Sleep(ONE_SECOND);
                Battery.GetInstance().UpdateData();
                try
                { Form.Invoke((MethodInvoker)delegate { Form.UpdateFormData(); }); }
                catch
                { break; }
            }
        }
    }
}
