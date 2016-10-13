using System.Linq;
using System.Threading.Tasks;

using ScaleModeling.Domain.Abstract;
using ScaleModeling.Domain.Entities;
using ScaleModeling.Domain.EF;
using System.Threading.Tasks;

namespace ScaleModeling.Domain.Concrete
{
    public class ForumImageRepository : IRepository<ForumImage, int>
    {
        private ApplicationDbContext context = new ApplicationDbContext();

        public IQueryable<ForumImage> Get
        {
            get
            {
                return context.ForumImages;
            }
        }

        public async Task<int> SaveChanges()
        {
            return await context.SaveChangesAsync();
        }
    }
}