using ECommerce.Entities;
using ECommerce.Infrastructure.Repositories.Abstracts;
using ECommerce.Infrastructure.Services.Abstracts;
using System.Collections.Generic;

namespace ECommerce.Infrastructure.Services
{
    public class BrandService : IBrandService
    {
        private readonly IBrandRepository _brandRepository;

        public BrandService(IBrandRepository brandRepository)
        {
            _brandRepository = brandRepository;
        }

        public List<Brand> GetAll()
        {
            return _brandRepository.GetAll();
        }

        public Brand Get(int ID)
        {
            return _brandRepository.Get(ID);
        }

        public void Insert(Brand brand)
        {
            _brandRepository.Insert(brand);
        }

        public void Update(Brand brand)
        {
            _brandRepository.Update(brand);
        }

        public void Delete(Brand brand)
        {
            _brandRepository.Delete(brand);
        }
    }
}
