using System.Linq;
using System.Threading.Tasks;
using System.Data.Entity;

using ScaleModeling.Domain.Abstract;
using ScaleModeling.Domain.Entities;
using ScaleModeling.Domain.EF;

namespace ScaleModeling.Domain.Repositories
{
    public class ForumImageRepository : IRepository<ForumImage>
    {
        private ApplicationDbContext context = new ApplicationDbContext();

        public IQueryable<ForumImage> GetAll
        {
            get
            {
                return context.ForumImages;
            }
        }


        public async Task Create(ForumImage item)
        {
            if (item != null)
            {
                await Task.Factory.StartNew( () => context.ForumImages.Add( item ) );
            }
        }


        public async Task Delete(int id)
        {
            ForumImage forumImageToDeletion = await context.ForumImages.FindAsync( id );

            if (forumImageToDeletion != null)
            {
                context.ForumImages.Remove( forumImageToDeletion );

                await context.SaveChangesAsync();
            }
        }


        public async Task<ForumImage> GetEntityById(int id)
        {
            return await context.ForumImages.FindAsync( id );
        }


        public async Task Update(ForumImage item)
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