using System.Linq;
using System.Threading.Tasks;

using ScaleModeling.Domain.Abstract;
using ScaleModeling.Domain.Entities;
using ScaleModeling.Domain.EF;
using System.Threading.Tasks;

namespace ScaleModeling.Domain.Concrete
{
    public class EventRepository : IRepository<Event, int>
    {
        private ApplicationDbContext context = new ApplicationDbContext();

        public IQueryable<Event> Get
        {
            get
            {
                return context.Events;
            }
        }

        public async Task<int> SaveChanges()
        {
            return await context.SaveChangesAsync();
        }
    }
}