using System.Linq;

using ScaleModeling.Domain.Abstract;
using ScaleModeling.Domain.Entities;

namespace ScaleModeling.Domain.Concrete
{
    public class WishListRepository : IRepository<WishList>
    {
        private EntityFrameworkDBContext context = new EntityFrameworkDBContext();

        public IQueryable<WishList> Get
        {
            get
            {
                return context.WishLists;
            }
        }
    }
}