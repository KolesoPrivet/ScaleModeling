using System.Linq;

using ScaleModeling.Domain.Abstract;
using ScaleModeling.Domain.Entities;
using ScaleModeling.Domain.EF;

namespace ScaleModeling.Domain.Concrete
{
    public class WishListRepository : IRepository<WishList, int>
    {
        private ApplicationDbContext context = new ApplicationDbContext();

        public IQueryable<WishList> Get
        {
            get
            {
                return context.WishLists;
            }
        }
    }
}