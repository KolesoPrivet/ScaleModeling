using System.Linq;
using System.Threading.Tasks;

using ScaleModeling.Domain.Abstract;
using ScaleModeling.Domain.Entities;
using ScaleModeling.Domain.EF;
using System.Threading.Tasks;

namespace ScaleModeling.Domain.Concrete
{
    public class ForumCategoryRepository : IRepository<ForumCategory, int>
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