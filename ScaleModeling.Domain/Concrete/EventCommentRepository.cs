using System.Linq;
using System.Threading.Tasks;

using ScaleModeling.Domain.Abstract;
using ScaleModeling.Domain.Entities;
using ScaleModeling.Domain.EF;

namespace ScaleModeling.Domain.Concrete
{
    public class EventCommentRepository : IRepository<EventComment>
    {
        private ApplicationDbContext context = new ApplicationDbContext();

        public IQueryable<EventComment> Get
        {
            get
            {
                return context.EventComments;
            }
        }

        public async Task<int> SaveChanges()
        {
            return await context.SaveChangesAsync();
        }
    }
}