using ECommerce.Context;
using ECommerce.Entities;
using ECommerce.Infrastructure.Repositories.Abstracts;
using System.Collections.Generic;
using System.Linq;

namespace ECommerce.Infrastructure.Repositories
{
    public class BaseRepository<T> : IBaseRepository<T> where T : BaseEntity 
        //eger bu class olsaydi herhangi bi class bu BaseRep. kullanabilrdi. Simdi sadece BaseEntity tipindeki klasslar inherit edebilir.
    {
        private readonly ApplicationDbContext _applicationDbContext;

        public BaseRepository(ApplicationDbContext applicationDbContext)
        {
            _applicationDbContext = applicationDbContext;
        }

        public void Delete(T entity)
        {
            _applicationDbContext.Set<T>().Remove(entity);
            Save();
        }

        public T Get(int ID)
        {
            return _applicationDbContext.Set<T>().FirstOrDefault(m => m.ID == ID);
        }

        public List<T> GetAll()
        {
            return _applicationDbContext.Set<T>().ToList();
        }

        public void Insert(T entity)
        {
            _applicationDbContext.Set<T>().Add(entity);
            Save();
        }

        public void Update(T entity)
        {
            _applicationDbContext.Set<T>().Update(entity);
            Save();
        }

        public void Save()
        {
            _applicationDbContext.SaveChanges();
        }
    }
}
