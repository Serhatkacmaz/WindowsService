using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceProcess;
using System.Text;
using System.Threading.Tasks;

namespace WindowsService.Mail
{
    internal static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        static void Main()
        {
#if (DEBUG)
            MailService mailService = new MailService();
            mailService.OnDebugStart();
            mailService.OnDebugInfiniteMod();
#else
            ServiceBase[] ServicesToRun;
            ServicesToRun = new ServiceBase[]
            {
                new MailService()
            };
            ServiceBase.Run(ServicesToRun);
#endif
        }
    }
}
