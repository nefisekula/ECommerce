using ECommerce.Infrastructure.Services.Abstracts;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ECommerce.UI.Components
{
    public class FeatureItemsViewComponent: ViewComponent
    {
        private readonly IProductService _productService;

        public FeatureItemsViewComponent(IProductService productService)
        {
            _productService = productService;
        }

        public IViewComponentResult Invoke()
        {
            var products = _productService.GetAll();
            var latestProducts = products.OrderByDescending(x => x.CreatedTime).Take(6).ToList();
            return View(latestProducts);
        }
    }
}
