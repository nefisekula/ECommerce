using ECommerce.Infrastructure.Interfaces;
using ECommerce.Infrastructure.Models;
using Microsoft.Extensions.Logging;
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
        private readonly ILogger<MailService> _logger;

        public MailService(IOptions<MailInfo> mailInfo, ILogger<MailService> logger)
        {
            _mailInfo = mailInfo.Value;
            _logger = logger;
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
                        await smtp.SendMailAsync(mailMsg);
                    }
                }
                _logger.LogInformation($"From {mailRequest.Email} address sent an email successfully.");
            }
            catch (Exception ex)
            {

                return ($"Mail couldn't sent: {ex.Message}");
            }
            return "Mail sent.";
        }

    }
}
