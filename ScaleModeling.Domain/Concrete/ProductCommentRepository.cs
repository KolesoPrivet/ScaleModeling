using System.Linq;
using System.Threading.Tasks;

using ScaleModeling.Domain.Abstract;
using ScaleModeling.Domain.Entities;
using ScaleModeling.Domain.EF;


namespace ScaleModeling.Domain.Concrete
{
    public class ProductCommentRepository : IRepository<ProductComment>
    {
        private ApplicationDbContext context = new ApplicationDbContext();

        public IQueryable<ProductComment> Get
        {
            get
            {
                return context.ProductComments;
            }
        }

        public async Task<int> SaveChanges()
        {
            return await context.SaveChangesAsync();
        }
    }
}