using System.Linq;

using ScaleModeling.Domain.Abstract;
using ScaleModeling.Domain.Entities;
using ScaleModeling.Domain.EF;

namespace ScaleModeling.Domain.Concrete
{
    public class EventCommentRepository : IRepository<EventComment, int>
    {
        private ApplicationDbContext context = new ApplicationDbContext();

        public IQueryable<EventComment> Get
        {
            get
            {
                return context.EventComments;
            }
        }
    }
}