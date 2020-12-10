using ECommerce.Context;
using ECommerce.Entities;
using ECommerce.Infrastructure.Repositories.Abstracts;

namespace ECommerce.Infrastructure.Repositories
{
    public class MenuRepository : BaseRepository<Menu>, IMenuRepository
    {
        public MenuRepository(ApplicationDbContext applicationDbContext) : base(applicationDbContext)
        {

        }
    }
}
