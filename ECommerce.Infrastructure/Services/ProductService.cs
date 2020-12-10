using ECommerce.Entities;
using ECommerce.Infrastructure.Repositories.Abstracts;
using ECommerce.Infrastructure.Services.Abstracts;
using System;
using System.Collections.Generic;
using System.Text;

namespace ECommerce.Infrastructure.Services
{
    public class ProductService : IProductService
    {
        private readonly IProductRepository _productRepository;
        
        public ProductService(IProductRepository productRepository)
        {
            _productRepository = productRepository;
        }

        public List<Product> GetAll()
        {
            return _productRepository.GetAll();
        }

        public Product Get(int ID)
        {
            return _productRepository.Get(ID);
        }

        public void Insert(Product product)
        {
            _productRepository.Insert(product);
        }

        public void Update(Product product)
        {
            _productRepository.Update(product);
        }

        public void Delete(Product product)
        {
            _productRepository.Delete(product);
        }
    }
}
