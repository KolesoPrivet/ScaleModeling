using System.Linq;
using System.Threading.Tasks;

using ScaleModeling.Domain.Abstract;
using ScaleModeling.Domain.Entities;
using ScaleModeling.Domain.EF;
using System.Threading.Tasks;

namespace ScaleModeling.Domain.Concrete
{
    public class EventImageRepository : IRepository<EventImage, int>
    {
        private ApplicationDbContext context = new ApplicationDbContext();

        public IQueryable<EventImage> Get
        {
            get
            {
                return context.EventImages;
            }
        }

        public async Task<int> SaveChanges()
        {
            return await context.SaveChangesAsync();
        }
    }
}