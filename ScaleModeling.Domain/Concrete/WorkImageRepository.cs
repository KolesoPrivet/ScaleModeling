using System.Linq;
using System.Threading.Tasks;

using ScaleModeling.Domain.Abstract;
using ScaleModeling.Domain.Entities;
using ScaleModeling.Domain.EF;

namespace ScaleModeling.Domain.Concrete
{
    public class WorkImageRepository : IRepository<WorkImage>
    {
        private ApplicationDbContext context = new ApplicationDbContext();

        public IQueryable<WorkImage> Get
        {
            get
            {
                return context.WorkImages;
            }
        }

        public async Task<int> SaveChanges()
        {
            return await context.SaveChangesAsync();
        }
    }
}