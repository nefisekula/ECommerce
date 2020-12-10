using ECommerce.Context;
using ECommerce.Entities;
using ECommerce.Infrastructure.Repositories.Abstracts;
using System;
using System.Collections.Generic;
using System.Text;

namespace ECommerce.Infrastructure.Repositories
{
    public class TagRepository : BaseRepository<Tag>, ITagRepository
    {
        public TagRepository(ApplicationDbContext applicationDbContext) : base(applicationDbContext)
        {

        }
    }
}
