﻿using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsService.Mail
{
    internal class ServiceSettings
    {
        public static string Host { get; } = ConfigurationManager.AppSettings["Host"];
        public static string Smtp { get; } = ConfigurationManager.AppSettings["Smtp"];
        public static int Port { get; } = int.Parse(ConfigurationManager.AppSettings["Port"]);
    }
}
