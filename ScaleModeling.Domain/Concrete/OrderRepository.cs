using System.Linq;

using ScaleModeling.Domain.Abstract;
using ScaleModeling.Domain.Entities;
using ScaleModeling.Domain.EF;

namespace ScaleModeling.Domain.Concrete
{
    public class OrderRepository : IRepository<Order, int>
    {
        private ApplicationDbContext context = new ApplicationDbContext();

        public IQueryable<Order> Get
        {
            get
            {
                return context.Orders;
            }
        }
    }
}