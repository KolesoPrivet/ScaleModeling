using System.Linq;
using System.Threading.Tasks;
using System.Data.Entity;

using ScaleModeling.Domain.Abstract;
using ScaleModeling.Domain.Entities;
using ScaleModeling.Domain.EF;

namespace ScaleModeling.Domain.Repositories
{
    public class ArticleRepository : IRepository<Article>
    {
        private ApplicationDbContext context = new ApplicationDbContext();

        public IQueryable<Article> GetAll
        {
            get
            {
                return context.Articles;
            }
        }


        public async Task Create(Article item)
        {
            if (item != null)
            {
                await Task.Factory.StartNew( () => context.Articles.Add( item ) );
            }
        }


        public async Task Delete(int id)
        {
            Article articleToDeletion = await context.Articles.FindAsync( id );

            if (articleToDeletion != null)
            {
                context.Articles.Remove( articleToDeletion );

                await context.SaveChangesAsync();
            }
        }


        public async Task<Article> GetEntityById(int id)
        {
            return await context.Articles.FindAsync( id );
        }


        public async Task Update(Article item)
        {
            if (item != null)
            {
                await Task.Factory.StartNew( () => context.Entry( item ).State = EntityState.Modified );
            }
        }


        public async Task SaveChangesAsync()
        {
            await context.SaveChangesAsync();
        }
    }
}