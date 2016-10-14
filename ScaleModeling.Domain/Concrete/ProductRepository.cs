using System.Linq;
using System.Threading.Tasks;

using ScaleModeling.Domain.Abstract;
using ScaleModeling.Domain.Entities;
using ScaleModeling.Domain.EF;


namespace ScaleModeling.Domain.Concrete
{
    public class ProductRepository : IRepository<Product>
    {
        private ApplicationDbContext context = new ApplicationDbContext();

        public IQueryable<Product> Get
        {
            get
            {
                return context.Products;
            }
        }

        public async Task<int> SaveChanges()
        {
            return await context.SaveChangesAsync();
        }
    }
}
