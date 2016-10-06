using System.Linq;

using ScaleModeling.Domain.Abstract;
using ScaleModeling.Domain.Entities;

namespace ScaleModeling.Domain.Concrete
{
    public class ForumCommentRepository : IRepository<ForumComment>
    {
        private EntityFrameworkDBContext context = new EntityFrameworkDBContext();

        public IQueryable<ForumComment> Get
        {
            get
            {
                return context.ForumComments;
            }
        }
    }
}