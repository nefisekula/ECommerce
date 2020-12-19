using ECommerce.Infrastructure.Interfaces;
using ECommerce.Infrastructure.Models;
using Microsoft.Extensions.Options;
using System;
using System.Collections.Generic;
using System.Net;
using System.Net.Mail;
using System.Text;
using System.Threading.Tasks;

namespace ECommerce.Infrastructure.Services
{
    public class MailService : IMailService
    {
        private readonly MailInfo _mailInfo;

        public MailService(IOptions<MailInfo> mailInfo)
        {
            _mailInfo = mailInfo.Value;
        }

        public async Task<string> SendEmailSmtpAsync(MailRequestModel mailRequest)
        {
            try
            {
                using (MailMessage mailMsg = new MailMessage(mailRequest.Email, _mailInfo.Mail))
                {
                    mailMsg.Subject = "ECommerce Customer Mail";
                    mailMsg.Body = mailRequest.Message;

                    using (SmtpClient smtp = new SmtpClient())
                    {
                        smtp.Host = _mailInfo.Host;
                        smtp.EnableSsl = true;
                        smtp.UseDefaultCredentials = false;
                        NetworkCredential networkCredential = new NetworkCredential(_mailInfo.Mail, _mailInfo.Password);
                        smtp.Credentials = networkCredential;
                        smtp.Port = _mailInfo.Port;
                        smtp.Send(mailMsg);
                        await smtp.SendMailAsync(mailMsg);
                    }
                }
            }
            catch (Exception ex)
            {

                return ($"Mail couldn't sent: {ex.Message}");
            }
            return "Mail sent.";
        }

    }
}
