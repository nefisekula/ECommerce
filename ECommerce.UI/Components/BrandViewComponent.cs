using ECommerce.Infrastructure.Services.Abstracts;
using Microsoft.AspNetCore.Mvc;

namespace ECommerce.UI.Components
{
    public class BrandViewComponent : ViewComponent
    {
        private readonly IBrandService _brandService;
        
        public BrandViewComponent(IBrandService brandService)
        {
            _brandService = brandService;
        }

        public IViewComponentResult Invoke()
        {
            var brands = _brandService.GetAll();
            return View(brands);
        }
    }
}
