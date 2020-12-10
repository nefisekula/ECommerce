using ECommerce.Infrastructure.Services.Abstracts;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ECommerce.UI.Controllers
{
    public class ProductController : BaseController
    {
        private readonly IProductService _productService;

        public ProductController(IProductService productService)
        {
            _productService = productService;
        }

        public IActionResult Index()
        {
            var products = _productService.GetAll();
            return View(products);
        }

        public IActionResult ProductDetail(int productId)
        {
            var products = _productService.GetAll();
            var product = products.FirstOrDefault(x => x.ID == productId);

            return View(product);
        }
    }
}
