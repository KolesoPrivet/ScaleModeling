using System.Linq;

using ScaleModeling.Domain.Abstract;
using ScaleModeling.Domain.Entities;

namespace ScaleModeling.Domain.Concrete
{
    public class ProductCategoryRepository : IRepository<ProductCategory>
    {
        private EntityFrameworkDBContext context = new EntityFrameworkDBContext();

        public IQueryable<ProductCategory> Get
        {
            get
            {
                return context.ProductCategories;
            }
        }
    }
}