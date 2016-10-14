using System.Linq;
using System.Threading.Tasks;

using ScaleModeling.Domain.Abstract;
using ScaleModeling.Domain.Entities;
using ScaleModeling.Domain.EF;

namespace ScaleModeling.Domain.Concrete
{
    public class EventImageRepository : IRepository<EventImage>
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