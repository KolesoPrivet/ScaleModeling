using System.Linq;
using System.Threading.Tasks;

using ScaleModeling.Domain.Abstract;
using ScaleModeling.Domain.Entities;
using ScaleModeling.Domain.EF;


namespace ScaleModeling.Domain.Concrete
{
    public class ProductCategoryRepository : IRepository<ProductCategory, int>
    {
        private ApplicationDbContext context = new ApplicationDbContext();

        public IQueryable<ProductCategory> Get
        {
            get
            {
                return context.ProductCategories;
            }
        }

        public async Task<int> SaveChanges()
        {
            return await context.SaveChangesAsync();
        }
    }
}