using System.Linq;
using System.Threading.Tasks;
using System.Data.Entity;

using ScaleModeling.Domain.Abstract;
using ScaleModeling.Domain.Entities;
using ScaleModeling.Domain.EF;

namespace ScaleModeling.Domain.Repositories
{
    public class EventCommentRepository : IRepository<EventComment>
    {
        private ApplicationDbContext context = new ApplicationDbContext();

        public IQueryable<EventComment> GetAll
        {
            get
            {
                return context.EventComments;
            }
        }

        public async Task Create(EventComment item)
        {
            if (item != null)
            {
                await Task.Factory.StartNew( () => context.EventComments.Add( item ) );
            }
        }


        public async Task Delete(int id)
        {
            EventComment eventCommentToDeletion = await context.EventComments.FindAsync( id );

            if (eventCommentToDeletion != null)
            {
                context.EventComments.Remove( eventCommentToDeletion );

                await context.SaveChangesAsync();
            }
        }


        public async Task<EventComment> GetEntityById(int id)
        {
            return await context.EventComments.FindAsync( id );
        }


        public async Task Update(EventComment item)
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