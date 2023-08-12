using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Mail;
using System.Text;
using System.Threading.Tasks;
using WindowsService.Mail.Models;

namespace WindowsService.Mail
{
    internal class MailHelper
    {
        public void SendMail(MailModel model)
        {
            SmtpClient smtpClient = new SmtpClient(ServiceSettings.Host, ServiceSettings.Port);
            var mailMessage = new MailMessage(model.From, model.To)
            {
                Subject = model.Subject,
                Body = model.Body,
                IsBodyHtml = model.IsBodyHtml
            };

            smtpClient.UseDefaultCredentials = false;
            smtpClient.Send(mailMessage);

            mailMessage.Dispose();
            smtpClient.Dispose();
        }
    }
}
