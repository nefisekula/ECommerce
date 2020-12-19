using Microsoft.AspNetCore.Mvc;

namespace ECommerce.UI.Components
{
    public class HeaderViewComponent : ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            return View();
        }
    }
}
