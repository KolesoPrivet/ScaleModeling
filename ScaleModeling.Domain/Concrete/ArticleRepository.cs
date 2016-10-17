using System.Linq;
using System.Threading.Tasks;

using ScaleModeling.Domain.Abstract;
using ScaleModeling.Domain.Entities;
using ScaleModeling.Domain.EF;

namespace ScaleModeling.Domain.Concrete
{
    public class ArticleRepository : IRepository<Article>
    {
        private ApplicationDbContext context = new ApplicationDbContext();

        public IQueryable<Article> Get
        {
            get
            {
                return context.Articles;
            }
        }

        public async Task SaveChangesAsync()
        {
            await context.SaveChangesAsync();
        }
    }
}