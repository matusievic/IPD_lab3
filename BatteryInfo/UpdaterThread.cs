using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Windows.Forms;

namespace BatteryInfo
{
    class UpdaterThread
    {
        private Thread Thread;
        private bool _isInterrupted;
        public bool IsInterrupted
        {
            get { return _isInterrupted; }
            set { _isInterrupted = value; }
        }
        private BatteryInfoForm Form;
        public UpdaterThread(BatteryInfoForm form)
        {
            Form = form;
            Thread = new Thread(this.Updater);
            _isInterrupted = false;
        }

        private void Updater()
        {
            while (true)
            {
                Thread.Sleep(1000);
                Battery.UpdateData();
                if (_isInterrupted)
                {
                    break;
                }
                Form.Invoke((MethodInvoker)delegate { Form.UpdateFormData(); });
            }
        }

        public void Start()
        {
            Thread.Start();
        }
    }
}
