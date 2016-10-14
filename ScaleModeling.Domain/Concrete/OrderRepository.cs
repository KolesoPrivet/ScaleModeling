using System.Linq;
using System.Threading.Tasks;

using ScaleModeling.Domain.Abstract;
using ScaleModeling.Domain.Entities;
using ScaleModeling.Domain.EF;

namespace ScaleModeling.Domain.Concrete
{
    public class OrderRepository : IRepository<Order>
    {
        private ApplicationDbContext context = new ApplicationDbContext();

        public IQueryable<Order> Get
        {
            get
            {
                return context.Orders;
            }
        }

        public async Task<int> SaveChanges()
        {
            return await context.SaveChangesAsync();
        }
    }
}