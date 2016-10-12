using System.Linq;

using ScaleModeling.Domain.Abstract;
using ScaleModeling.Domain.Entities;
using ScaleModeling.Domain.EF;

namespace ScaleModeling.Domain.Concrete
{
    public class ProductRepository : IRepository<Product, int>
    {
        private ApplicationDbContext context = new ApplicationDbContext();

        public IQueryable<Product> Get
        {
            get
            {
                return context.Products;
            }
        }
    }
}
