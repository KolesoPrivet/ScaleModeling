using System.Linq;
using System.Threading.Tasks;
using System.Data.Entity;

using ScaleModeling.Domain.Abstract;
using ScaleModeling.Domain.Entities;
using ScaleModeling.Domain.EF;

namespace ScaleModeling.Domain.Repositories
{
    public class VideoCommentRepository : IRepository<VideoComment>
    {
        private ApplicationDbContext context = new ApplicationDbContext();

        public IQueryable<VideoComment> GetAll
        {
            get
            {
                return context.VideoComments;
            }
        }


        public async Task Create(VideoComment item)
        {
            if (item != null)
            {
                await Task.Factory.StartNew( () => context.VideoComments.Add( item ) );
            }
        }


        public async Task Delete(int id)
        {
            VideoComment videoCommentToDeletion = await context.VideoComments.FindAsync( id );

            if (videoCommentToDeletion != null)
            {
                context.VideoComments.Remove( videoCommentToDeletion );

                await context.SaveChangesAsync();
            }
        }


        public async Task<VideoComment> GetEntityById(int id)
        {
            return await context.VideoComments.FindAsync( id );
        }


        public async Task Update(VideoComment item)
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