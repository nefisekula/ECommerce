using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ECommerce.UI.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            ViewBag.ShowSlider = true;
            return View();
        }

        public IActionResult About()
        {
            ViewBag.ShowSlider = false;
            return View();
        }
    }
}
