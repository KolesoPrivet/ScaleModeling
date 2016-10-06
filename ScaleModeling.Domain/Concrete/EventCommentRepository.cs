using System.Linq;

using ScaleModeling.Domain.Abstract;
using ScaleModeling.Domain.Entities;

namespace ScaleModeling.Domain.Concrete
{
    class EventCommentRepository : IRepository<EventComment>
    {
        private EntityFrameworkDBContext context = new EntityFrameworkDBContext();

        public IQueryable<EventComment> Get
        {
            get
            {
                return context.EventComments;
            }
        }
    }
}