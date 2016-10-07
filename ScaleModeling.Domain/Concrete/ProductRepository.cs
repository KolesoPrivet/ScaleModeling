using System.Linq;

using ScaleModeling.Domain.Abstract;
using ScaleModeling.Domain.Entities;

namespace ScaleModeling.Domain.Concrete
{
    public class ProductRepository : IRepository<Product>
    {
        private EntityFrameworkDBContext context = new EntityFrameworkDBContext();

        public IQueryable<Product> Get
        {
            get
            {
                return context.Products;
            }
        }
    }
}
