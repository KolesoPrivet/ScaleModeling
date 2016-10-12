using System.Linq;

using ScaleModeling.Domain.Abstract;
using ScaleModeling.Domain.Entities;
using ScaleModeling.Domain.EF;

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
    }
}