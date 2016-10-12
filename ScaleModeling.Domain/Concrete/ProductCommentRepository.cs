using System.Linq;

using ScaleModeling.Domain.Abstract;
using ScaleModeling.Domain.Entities;
using ScaleModeling.Domain.EF;

namespace ScaleModeling.Domain.Concrete
{
    public class ProductCommentRepository : IRepository<ProductComment, int>
    {
        private ApplicationDbContext context = new ApplicationDbContext();

        public IQueryable<ProductComment> Get
        {
            get
            {
                return context.ProductComments;
            }
        }
    }
}