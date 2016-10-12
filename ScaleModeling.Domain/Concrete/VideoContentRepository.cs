using System.Linq;

using ScaleModeling.Domain.Abstract;
using ScaleModeling.Domain.Entities;
using ScaleModeling.Domain.EF;

namespace ScaleModeling.Domain.Concrete
{
    public class VideoContentRepository : IRepository<VideoContent, int>
    {
        private ApplicationDbContext context = new ApplicationDbContext();

        public IQueryable<VideoContent> Get
        {
            get
            {
                return context.Videos;
            }
        }
    }
}