using ECommerce.Entities;
using ECommerce.Infrastructure.Repositories.Abstracts;
using ECommerce.Infrastructure.Services.Abstracts;
using System.Collections.Generic;

namespace ECommerce.Infrastructure.Services
{
    public class TagService : ITagService
    {
        public readonly ITagRepository _tagRepository;

        public TagService(ITagRepository tagRepository)
        {
            _tagRepository = tagRepository;
        }

        public List<Tag> GetAll()
        {
            return _tagRepository.GetAll();
        }

        public Tag Get(int ID)
        {
            return _tagRepository.Get(ID);
        }

        public void Insert(Tag tag)
        {
            _tagRepository.Insert(tag);
        }

        public void Update(Tag tag)
        {
            _tagRepository.Update(tag);
        }

        public void Delete(Tag tag)
        {
            _tagRepository.Delete(tag);
        }
    }
}
