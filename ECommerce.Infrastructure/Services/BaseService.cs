using ECommerce.Entities;
using ECommerce.Infrastructure.Repositories.Abstracts;
using ECommerce.Infrastructure.Services.Abstracts;
using System;
using System.Collections.Generic;
using System.Text;

namespace ECommerce.Infrastructure.Services
{
    public class BaseService<T> : IBaseService<T> where T : BaseEntity
    {
        private readonly IBaseRepository<T> _baseRepository;

        public BaseService(IBaseRepository<T> baseRepository)
        {
            _baseRepository = baseRepository;
        }

        public List<T> GetAll()
        {
            return _baseRepository.GetAll();
        }

        public T Get(int ID)
        {
            return _baseRepository.Get(ID);
        }

        public void Delete(T entity)
        {
            _baseRepository.Delete(entity);
        }

        public void Insert(T entity)
        {
            _baseRepository.Insert(entity);
        }

        public void Update(T entity)
        {
            _baseRepository.Update(entity);
        }
    }
}
