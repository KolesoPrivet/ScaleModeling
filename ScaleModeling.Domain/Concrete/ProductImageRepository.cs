using System.Linq;

using ScaleModeling.Domain.Abstract;
using ScaleModeling.Domain.Entities;

namespace ScaleModeling.Domain.Concrete
{
    public class ProductImageRepository : IRepository<ProductImage>
    {
        private EntityFrameworkDBContext context = new EntityFrameworkDBContext();

        public IQueryable<ProductImage> Get
        {
            get
            {
                return context.ProductImages;
            }
        }
    }
}