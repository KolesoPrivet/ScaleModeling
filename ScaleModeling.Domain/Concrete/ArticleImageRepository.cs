using System.Linq;

using ScaleModeling.Domain.Abstract;
using ScaleModeling.Domain.Entities;
using ScaleModeling.Domain.EF;

namespace ScaleModeling.Domain.Concrete
{
    public class ArticleImageRepository : IRepository<ArticleImage, int>
    {
        private ApplicationDbContext context = new ApplicationDbContext();

        public IQueryable<ArticleImage> Get
        {
            get
            {
                return context.ArticleImages;
            }
        }
    }
}