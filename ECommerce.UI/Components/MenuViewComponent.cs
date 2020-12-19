using ECommerce.Infrastructure.Services.Abstracts;
using Microsoft.AspNetCore.Mvc;

namespace ECommerce.UI.Components
{
    public class MenuViewComponent : ViewComponent
    {
        private readonly IMenuService _menuService;

        public MenuViewComponent(IMenuService menuService)
        {
            _menuService = menuService;
        }

        public IViewComponentResult Invoke()
        {
            var menu = _menuService.GetAll();
            return View(menu);
        }
    }
}
