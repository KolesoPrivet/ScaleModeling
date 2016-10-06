using System.Linq;

using ScaleModeling.Domain.Abstract;
using ScaleModeling.Domain.Entities;

namespace ScaleModeling.Domain.Concrete
{
    public class ArticleRepository : IRepository<Article>
    {
        private EntityFrameworkDBContext context = new EntityFrameworkDBContext();

        public IQueryable<Article> Get
        {
            get
            {
                return context.Articles;
            }
        }
    }
}