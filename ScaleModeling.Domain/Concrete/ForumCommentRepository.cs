using System.Linq;
using System.Threading.Tasks;

using ScaleModeling.Domain.Abstract;
using ScaleModeling.Domain.Entities;
using ScaleModeling.Domain.EF;

namespace ScaleModeling.Domain.Concrete
{
    public class ForumCommentRepository : IRepository<ForumComment>
    {
        private ApplicationDbContext context = new ApplicationDbContext();

        public IQueryable<ForumComment> Get
        {
            get
            {
                return context.ForumComments;
            }
        }

        public async Task SaveChangesAsync()
        {
            await context.SaveChangesAsync();
        }
    }
}