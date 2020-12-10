using System;
using System.Collections.Generic;
using System.Text;

namespace ECommerce.Infrastructure.Services.Abstracts
{
    public interface IBaseService<T>
    {
        public List<T> GetAll();
        public T Get(int ID);
        public void Insert(T entity);
        public void Update(T entity);
        public void Delete(T entity);
    }
}
