using ECommerce.Entities;
using ECommerce.Infrastructure.Repositories.Abstracts;
using ECommerce.Infrastructure.Services.Abstracts;
using System;
using System.Collections.Generic;
using System.Text;

namespace ECommerce.Infrastructure.Services
{
    public class MenuService : IMenuService
    {
        private readonly IMenuRepository _menuRepository;

        public MenuService(IMenuRepository menuRepository)
        {
            _menuRepository = menuRepository;
        }

        public List<Menu> GetAll()
        {
            return _menuRepository.GetAll();
        }

        public Menu Get(int ID)
        {
            return _menuRepository.Get(ID);
        }

        public void Insert(Menu menu)
        {
            _menuRepository.Insert(menu);
        }

        public void Update(Menu menu)
        {
            _menuRepository.Update(menu);
        }

        public void Delete(Menu menu)
        {
            _menuRepository.Delete(menu);
        }
    }
}
