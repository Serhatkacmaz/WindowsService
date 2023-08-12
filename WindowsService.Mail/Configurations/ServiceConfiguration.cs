using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsService.Mail
{
    internal class ServiceConfiguration
    {
        public static string Host { get; } = ConfigurationManager.AppSettings["Host"];
        public static int Port { get; } = int.Parse(ConfigurationManager.AppSettings["Port"]);
    }
}
