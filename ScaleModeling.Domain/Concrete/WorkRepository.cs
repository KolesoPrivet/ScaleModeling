using System.Linq;
using System.Threading.Tasks;

using ScaleModeling.Domain.Abstract;
using ScaleModeling.Domain.Entities;
using ScaleModeling.Domain.EF;

namespace ScaleModeling.Domain.Concrete
{
    public class WorkRepository : IRepository<Work>
    {
        private ApplicationDbContext context = new ApplicationDbContext();

        public IQueryable<Work> Get
        {
            get
            {
                return context.Works;
            }
        }

        public async Task<int> SaveChanges()
        {
            return await context.SaveChangesAsync();
        }
    }
}