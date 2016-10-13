using System.Linq;
using System.Threading.Tasks;

using ScaleModeling.Domain.Abstract;
using ScaleModeling.Domain.Entities;
using ScaleModeling.Domain.EF;
using System.Threading.Tasks;

namespace ScaleModeling.Domain.Concrete
{
    public class ForumCommentRepository : IRepository<ForumComment, int>
    {
        private ApplicationDbContext context = new ApplicationDbContext();

        public IQueryable<ForumComment> Get
        {
            get
            {
                return context.ForumComments;
            }
        }

        public async Task<int> SaveChanges()
        {
            return await context.SaveChangesAsync();
        }
    }
}