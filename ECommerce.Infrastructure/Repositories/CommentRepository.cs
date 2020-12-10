using ECommerce.Context;
using ECommerce.Entities;
using ECommerce.Infrastructure.Repositories.Abstracts;
using System;
using System.Collections.Generic;
using System.Text;

namespace ECommerce.Infrastructure.Repositories
{
    public class CommentRepository : BaseRepository<Comment>, ICommentRepository
    {
        public CommentRepository(ApplicationDbContext applicationDbContext) :base(applicationDbContext)
        {

        }
    }
}
