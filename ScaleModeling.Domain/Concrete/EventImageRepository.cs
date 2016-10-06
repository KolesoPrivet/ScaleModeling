using System.Linq;

using ScaleModeling.Domain.Abstract;
using ScaleModeling.Domain.Entities;

namespace ScaleModeling.Domain.Concrete
{
    public class EventImageRepository : IRepository<EventImage>
    {
        private EntityFrameworkDBContext context = new EntityFrameworkDBContext();

        public IQueryable<EventImage> Get
        {
            get
            {
                return context.EventImages;
            }
        }
    }
}