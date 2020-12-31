using ECommerce.Infrastructure.Extensions;
using ECommerce.Infrastructure.Services.Abstracts;
using ECommerce.UI.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;

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

        public void AddToBasket(int productId, int quantity)
        {
            var basketModel = new BasketModel { Product = _productService.Get(productId), Quantity = quantity };
            var basketList = SessionExtensions.GetObjectFromJson<List<BasketModel>>(HttpContext.Session, "Cart");

            if (basketList == null)
            {
                var cart = new List<BasketModel>();
                cart.Add(basketModel);
                SessionExtensions.SetObjectAsJson(HttpContext.Session, "Cart", cart);
            }
            else
            {
                var index = isExist(productId);
                if (index != -1)
                    basketList[index].Quantity += quantity;
                else
                    basketList.Add(basketModel);

                SessionExtensions.SetObjectAsJson(HttpContext.Session, "Cart", basketList);
            }
        }

        public IActionResult Basket()
        {
            var basketList = SessionExtensions.GetObjectFromJson<List<BasketModel>>(HttpContext.Session, "Cart");

            if (basketList == null)
                basketList = new List<BasketModel>();

            return View(basketList);
        }

        public int UpdateQuantity(int productId, int quantity)
        {
            var basketList = SessionExtensions.GetObjectFromJson<List<BasketModel>>(HttpContext.Session, "Cart");
            var index = isExist(productId);

            if (index != -1)
            {
                basketList[index].Quantity += quantity;

                SessionExtensions.SetObjectAsJson(HttpContext.Session, "Cart", basketList);
                
                return basketList[index].Quantity;
            }
            return 0;
        }

        public void Remove(int productID)
        {
            var basketList = SessionExtensions.GetObjectFromJson<List<BasketModel>>(HttpContext.Session, "Cart");
            var index = isExist(productID);

            basketList.RemoveAt(index);
            SessionExtensions.Set(HttpContext.Session, "Cart", basketList);
        }

        private int isExist(int productId)
        {
            var cart = SessionExtensions.GetObjectFromJson<List<BasketModel>>(HttpContext.Session, "Cart");

            for (int i = 0; i < cart.Count; i++)
            {
                if (cart[i].Product.ID.Equals(productId))
                    return i;
            }
            return -1;
        }
    }
}
