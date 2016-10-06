using System.Linq;

using ScaleModeling.Domain.Abstract;
using ScaleModeling.Domain.Entities;

namespace ScaleModeling.Domain.Concrete
{
    public class VideoContentRepository : IRepository<VideoContent>
    {
        private EntityFrameworkDBContext context = new EntityFrameworkDBContext();

        public IQueryable<VideoContent> Get
        {
            get
            {
                return context.Videos;
            }
        }
    }
}