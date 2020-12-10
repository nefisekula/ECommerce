using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Filters;


namespace ECommerce.UI.Controllers
{
    public class BaseController : Controller
    {
        public override void OnActionExecuted(ActionExecutedContext context)
        {
            ViewBag.ShowSlider = false;
            base.OnActionExecuted(context);

        }
    }
}
