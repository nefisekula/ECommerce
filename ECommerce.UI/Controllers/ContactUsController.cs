using ECommerce.Infrastructure.Interfaces;
using ECommerce.Infrastructure.Models;
using ECommerce.UI.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.ComponentModel;
using System.Net;
using System.Net.Mail;
using System.Text;
using System.Threading.Tasks;

namespace ECommerce.UI.Controllers
{
    public class ContactUsController : BaseController
    {
        private readonly IMailService _mailService;

        public ContactUsController(IMailService mailService)
        {
            _mailService = mailService;
        }
        public IActionResult Index()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Index(MailRequestModel model)
        {
            if (!ModelState.IsValid)
                return View();

            /*
            using (MailMessage mailMsg = new MailMessage(model.Email, "nefise.ozkan@gmail.com"))
            {
                mailMsg.Subject = "ECommerce Customer Mail";
                mailMsg.Body = model.Message;

                using (SmtpClient smtp = new SmtpClient("smtp.gmail.com"))
                {
                    smtp.Host = "smtp.gmail.com";
                    smtp.EnableSsl = true;
                    smtp.UseDefaultCredentials = false;
                    NetworkCredential networkCredential = new NetworkCredential("nefise.ozkan@gmail.com", "fname2604212312");   
                    smtp.Credentials = networkCredential;
                    smtp.Port = 587;
                    smtp.Send(mailMsg);
                    ViewBag.Message = "Email sent.";                  
                }
            }
            */
            var temp = await _mailService.SendEmailSmtpAsync(model);            

            return View();
        }

    }
}
