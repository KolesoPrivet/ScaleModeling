using System.Linq;

using ScaleModeling.Domain.Abstract;
using ScaleModeling.Domain.Entities;
using ScaleModeling.Domain.EF;

namespace ScaleModeling.Domain.Concrete
{
    public class ArticleRepository : IRepository<Article, int>
    {
        private ApplicationDbContext context = new ApplicationDbContext();

        public IQueryable<Article> Get
        {
            get
            {
                return context.Articles;
            }
        }
    }
}