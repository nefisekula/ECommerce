using ECommerce.Entities;
using ECommerce.Infrastructure.Repositories.Abstracts;
using ECommerce.Infrastructure.Services.Abstracts;
using System;
using System.Collections.Generic;
using System.Text;

namespace ECommerce.Infrastructure.Services
{
    class PictureService : IPictureService
    {
        private readonly IPictureRepository _pictureRepository;

        public PictureService(IPictureRepository pictureRepository)
        {
            _pictureRepository = pictureRepository;
        }

        public List<Picture> GetAll()
        {
            return _pictureRepository.GetAll();
        }

        public Picture Get(int ID)
        {
            return _pictureRepository.Get(ID);
        }

        public void Insert(Picture picture)
        {
            _pictureRepository.Insert(picture);
        }

        public void Update(Picture picture)
        {
            _pictureRepository.Update(picture);
        }

        public void Delete(Picture picture)
        {
            _pictureRepository.Delete(picture);
        }
    }
}
