using System.Linq;

using ScaleModeling.Domain.Abstract;
using ScaleModeling.Domain.Entities;

namespace ScaleModeling.Domain.Concrete
{
    public class VideoCommentRepository : IRepository<VideoComment>
    {
        private EntityFrameworkDBContext context = new EntityFrameworkDBContext();

        public IQueryable<VideoComment> Get
        {
            get
            {
                return context.VideoComments;
            }
        }
    }
}