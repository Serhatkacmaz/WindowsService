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
        public void SendMail(MailModel mailModel)
        {
            using (SmtpClient smtpClient = new SmtpClient(ServiceConfiguration.Host, ServiceConfiguration.Port))
            using (MailMessage mailMessage = new MailMessage(mailModel.From, mailModel.To))
            {
                mailMessage.Subject = mailModel.Subject;
                mailMessage.Body = mailModel.Body;
                mailMessage.IsBodyHtml = mailModel.IsBodyHtml;

                smtpClient.UseDefaultCredentials = false;
                smtpClient.Send(mailMessage);
            }
        }

    }
}
