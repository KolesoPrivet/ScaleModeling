using System.Linq;

using ScaleModeling.Domain.Abstract;
using ScaleModeling.Domain.Entities;

namespace ScaleModeling.Domain.Concrete
{
    public class ArticleImageRepository : IRepository<ArticleImage>
    {
        private EntityFrameworkDBContext context = new EntityFrameworkDBContext();

        public IQueryable<ArticleImage> Get
        {
            get
            {
                return context.ArticleImages;
            }
        }
    }
}