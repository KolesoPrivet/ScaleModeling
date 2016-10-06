using System.Linq;

using ScaleModeling.Domain.Abstract;
using ScaleModeling.Domain.Entities;

namespace ScaleModeling.Domain.Concrete
{
    public class ForumImageRepository : IRepository<ForumImage>
    {
        private EntityFrameworkDBContext context = new EntityFrameworkDBContext();

        public IQueryable<ForumImage> Get
        {
            get
            {
                return context.ForumImages;
            }
        }
    }
}