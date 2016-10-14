using System.Linq;
using System.Threading.Tasks;

using ScaleModeling.Domain.Abstract;
using ScaleModeling.Domain.Entities;
using ScaleModeling.Domain.EF;

namespace ScaleModeling.Domain.Concrete
{
    public class WishListRepository : IRepository<WishList>
    {
        private ApplicationDbContext context = new ApplicationDbContext();

        public IQueryable<WishList> Get
        {
            get
            {
                return context.WishLists;
            }
        }

        public async Task<int> SaveChanges()
        {
            return await context.SaveChangesAsync();
        }
    }
}