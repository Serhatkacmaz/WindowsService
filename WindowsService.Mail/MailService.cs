using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Linq;
using System.Net.Mail;
using System.ServiceProcess;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace WindowsService.Mail
{
    public partial class MailService : ServiceBase
    {
        private Task _taskSendMailSMTP;

        public MailService()
        {
            InitializeComponent();
        }

        #region DebugMode
        public void OnDebugStart()
        {
            OnStart(null);
        }

        public void OnDebugStop()
        {
            OnStop();
        }

        public void OnDebugInfiniteMod()
        {
          Thread.Sleep(Timeout.Infinite);
        }
        #endregion

        protected override void OnStart(string[] args)
        {
            _taskSendMailSMTP = Task.Factory.StartNew(new Action(SendMailSMTP), new CancellationToken(), TaskCreationOptions.LongRunning, TaskScheduler.Default);
        }

        protected override void OnStop()
        {
            try
            {
                _taskSendMailSMTP.Dispose();
            }
            catch (Exception)
            {
                //TODO: write log
                throw;
            }
        }

        private void SendMailSMTP()
        {
            try
            {
                //Send Mail
            }
            catch (Exception)
            {

                throw;
            }
        }
    }
}
