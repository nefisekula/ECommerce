using ECommerce.Context;
using ECommerce.Entities;
using ECommerce.Infrastructure.Repositories.Abstracts;

namespace ECommerce.Infrastructure.Repositories
{
    public class BrandRepository : BaseRepository<Brand>, IBrandRepository
    {
        public BrandRepository(ApplicationDbContext applicationDbContext) : base(applicationDbContext)
        {

        }
    }
}
