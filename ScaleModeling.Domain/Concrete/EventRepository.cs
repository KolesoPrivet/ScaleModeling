using System.Linq;

using ScaleModeling.Domain.Abstract;
using ScaleModeling.Domain.Entities;

namespace ScaleModeling.Domain.Concrete
{
    public class EventRepository : IRepository<Event>
    {
        private EntityFrameworkDBContext context = new EntityFrameworkDBContext();

        public IQueryable<Event> Get
        {
            get
            {
                return context.Events;
            }
        }
    }
}