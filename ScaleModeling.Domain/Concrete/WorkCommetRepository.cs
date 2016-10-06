using System.Linq;

using ScaleModeling.Domain.Abstract;
using ScaleModeling.Domain.Entities;

namespace ScaleModeling.Domain.Concrete
{
    public class WorkCommentRepository : IRepository<WorkComment>
    {
        private EntityFrameworkDBContext context = new EntityFrameworkDBContext();

        public IQueryable<WorkComment> Get
        {
            get
            {
                return context.WorkComments;
            }
        }
    }
}