using System;
using System.Collections.Generic;
using System.Text;

namespace ECommerce.Infrastructure.Repositories.Abstracts
{
    public interface IBaseRepository<T>
    {
        public List<T> GetAll();
        public T Get(int ID);
        public void Insert(T entity);
        public void Update(T entity);
        public void Delete(T entity);
    }
}
