using ECommerce.Infrastructure.Models;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace ECommerce.Infrastructure.Interfaces
{
    public interface IMailService
    {
        Task<string> SendEmailSmtpAsync(MailRequestModel mailRequest);
    }
}
