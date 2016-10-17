using System.Linq;
using System.Threading.Tasks;
using System.Data.Entity;

using ScaleModeling.Domain.Abstract;
using ScaleModeling.Domain.Entities;
using ScaleModeling.Domain.EF;

namespace ScaleModeling.Domain.Repositories
{
    public class VideoContentRepository : IRepository<VideoContent>
    {
        private ApplicationDbContext context = new ApplicationDbContext();

        public IQueryable<VideoContent> GetAll
        {
            get
            {
                return context.Videos;
            }
        }


        public async Task Create(VideoContent item)
        {
            if (item != null)
            {
                await Task.Factory.StartNew( () => context.Videos.Add( item ) );
            }
        }


        public async Task Delete(int id)
        {
            VideoContent videoToDeletion = await context.Videos.FindAsync( id );

            if (videoToDeletion != null)
            {
                context.Videos.Remove( videoToDeletion );

                await context.SaveChangesAsync();
            }
        }


        public async Task<VideoContent> GetEntityById(int id)
        {
            return await context.Videos.FindAsync( id );
        }


        public async Task Update(VideoContent item)
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