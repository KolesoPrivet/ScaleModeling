using System.Linq;

using ScaleModeling.Domain.Abstract;
using ScaleModeling.Domain.Entities;
using ScaleModeling.Domain.EF;

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
    }
}