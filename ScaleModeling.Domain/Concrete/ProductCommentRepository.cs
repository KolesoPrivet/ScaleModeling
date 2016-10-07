using System.Linq;

using ScaleModeling.Domain.Abstract;
using ScaleModeling.Domain.Entities;

namespace ScaleModeling.Domain.Concrete
{
    public class ProductCommentRepository : IRepository<ProductComment>
    {
        private EntityFrameworkDBContext context = new EntityFrameworkDBContext();

        public IQueryable<ProductComment> Get
        {
            get
            {
                return context.ProductComments;
            }
        }
    }
}