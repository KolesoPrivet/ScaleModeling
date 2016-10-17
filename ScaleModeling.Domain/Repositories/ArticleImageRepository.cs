using System.Linq;
using System.Threading.Tasks;
using System.Data.Entity;

using ScaleModeling.Domain.Abstract;
using ScaleModeling.Domain.Entities;
using ScaleModeling.Domain.EF;

namespace ScaleModeling.Domain.Repositories
{
    public class ArticleImageRepository : IRepository<ArticleImage>
    {
        private ApplicationDbContext context = new ApplicationDbContext();

        public IQueryable<ArticleImage> GetAll
        {
            get
            {
                return context.ArticleImages;
            }
        }


        public async Task Create(ArticleImage item)
        {
            if (item != null)
            {
                await Task.Factory.StartNew( () => context.ArticleImages.Add( item ) );
            }
        }


        public async Task Delete(int id)
        {
            ArticleImage articleImageToDeletion = await context.ArticleImages.FindAsync( id );

            if (articleImageToDeletion != null)
            {
                context.ArticleImages.Remove( articleImageToDeletion );

                await context.SaveChangesAsync();
            }
        }


        public async Task<ArticleImage> GetEntityById(int id)
        {
            return await context.ArticleImages.FindAsync( id );
        }


        public async Task Update(ArticleImage item)
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