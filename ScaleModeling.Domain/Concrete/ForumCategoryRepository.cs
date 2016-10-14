using System.Linq;
using System.Threading.Tasks;

using ScaleModeling.Domain.Abstract;
using ScaleModeling.Domain.Entities;
using ScaleModeling.Domain.EF;

namespace ScaleModeling.Domain.Concrete
{
    public class ForumCategoryRepository : IRepository<ForumCategory>
    {
        private ApplicationDbContext context = new ApplicationDbContext();

        public IQueryable<ForumCategory> Get
        {
            get
            {
                return context.ForumCategories;
            }
        }

        public async Task<int> SaveChanges()
        {
            return await context.SaveChangesAsync();
        }
    }
}