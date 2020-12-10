using ECommerce.Infrastructure.Services.Abstracts;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ECommerce.UI.Components
{
    public class RecommendedViewComponent : ViewComponent
    {
        private readonly IProductService _productService;

        public RecommendedViewComponent(IProductService productService)
        {
            _productService = productService;
        }

        public IViewComponentResult Invoke()
        {
            var products = _productService.GetAll();
            var recommended = products.Where(p => p.IsRecommended).Take(10).ToList();
            return View(recommended);
        }
    }
}
