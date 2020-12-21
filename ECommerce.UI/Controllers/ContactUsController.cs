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

            ViewBag.Message = await _mailService.SendEmailSmtpAsync(model);

            return View();
        }

    }
}
