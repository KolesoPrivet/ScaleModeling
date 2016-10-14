using System.Linq;
using System.Threading.Tasks;

using ScaleModeling.Domain.Abstract;
using ScaleModeling.Domain.Entities;
using ScaleModeling.Domain.EF;


namespace ScaleModeling.Domain.Concrete
{
    public class ProductImageRepository : IRepository<ProductImage>
    {
        private ApplicationDbContext context = new ApplicationDbContext();

        public IQueryable<ProductImage> Get
        {
            get
            {
                return context.ProductImages;
            }
        }

        public async Task<int> SaveChanges()
        {
            return await context.SaveChangesAsync();
        }
    }
}