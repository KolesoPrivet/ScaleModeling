using System.Linq;
using System.Threading.Tasks;

using ScaleModeling.Domain.Abstract;
using ScaleModeling.Domain.Entities;
using ScaleModeling.Domain.EF;

namespace ScaleModeling.Domain.Concrete
{
    public class WorkCommentRepository : IRepository<WorkComment>
    {
        private ApplicationDbContext context = new ApplicationDbContext();

        public IQueryable<WorkComment> Get
        {
            get
            {
                return context.WorkComments;
            }
        }

        public async Task SaveChangesAsync()
        {
            await context.SaveChangesAsync();
        }
    }
}