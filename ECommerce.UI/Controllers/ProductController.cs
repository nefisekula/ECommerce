using ECommerce.Infrastructure.Services.Abstracts;
using ECommerce.UI.Models;
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

        public IActionResult Index(int categoryId, int brandId, int pageIndex)
        {
            ProductViewModel model = new ProductViewModel();
            model.PageIndex -= 1;

            var products = _productService.GetAll();

            if (categoryId != 0)
                products = products.Where(x => x.CategoryId == categoryId).ToList();

            if (brandId != 0)
                products = products.Where(x => x.BrandId == brandId).ToList();

            model.TotalPageCount = (int)Math.Ceiling((decimal)products.Count / model.Count);
            model.Products = products.Skip(model.PageIndex * model.Count).Take(model.Count).ToList();
            model.CategoryId = categoryId;
            model.BrandId = brandId;

            return View(model);
        }

        public IActionResult ProductDetail(int productId)
        {
            var products = _productService.GetAll();
            var product = products.FirstOrDefault(x => x.ID == productId);

            return View(product);
        }

        public IActionResult Basket()
        {
            return View();
        }
    }
}
