using System.Linq;

using ScaleModeling.Domain.Abstract;
using ScaleModeling.Domain.Entities;
using ScaleModeling.Domain.EF;

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
    }
}