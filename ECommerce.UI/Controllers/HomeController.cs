using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace ECommerce.UI.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
            _logger.LogDebug(1, "NLog injected into HomeController");
        }
        public IActionResult Index()
        {
            _logger.LogInformation("Hello, this is the index!");

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
