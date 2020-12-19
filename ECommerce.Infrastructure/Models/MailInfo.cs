using System;
using System.Collections.Generic;
using System.Text;

namespace ECommerce.Infrastructure.Models
{
    public class MailInfo
    {
        public string Mail { get; set; }
        public string DisplayName { get; set; }
        public string Password { get; set; }
        public string Host { get; set; }
        public int Port { get; set; }
    }
}
