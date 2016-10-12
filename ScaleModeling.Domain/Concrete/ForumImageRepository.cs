using System.Linq;

using ScaleModeling.Domain.Abstract;
using ScaleModeling.Domain.Entities;
using ScaleModeling.Domain.EF;

namespace ScaleModeling.Domain.Concrete
{
    public class ForumImageRepository : IRepository<ForumImage, int>
    {
        private ApplicationDbContext context = new ApplicationDbContext();

        public IQueryable<ForumImage> Get
        {
            get
            {
                return context.ForumImages;
            }
        }
    }
}