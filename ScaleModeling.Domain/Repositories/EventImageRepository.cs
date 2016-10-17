using System.Linq;
using System.Threading.Tasks;
using System.Data.Entity;

using ScaleModeling.Domain.Abstract;
using ScaleModeling.Domain.Entities;
using ScaleModeling.Domain.EF;

namespace ScaleModeling.Domain.Repositories
{
    public class EventImageRepository : IRepository<EventImage>
    {
        private ApplicationDbContext context = new ApplicationDbContext();

        public IQueryable<EventImage> GetAll
        {
            get
            {
                return context.EventImages;
            }
        }


        public async Task Create(EventImage item)
        {
            if (item != null)
            {
                await Task.Factory.StartNew( () => context.EventImages.Add( item ) );
            }
        }


        public async Task Delete(int id)
        {
            EventImage eventImageToDeletion = await context.EventImages.FindAsync( id );

            if (eventImageToDeletion != null)
            {
                context.EventImages.Remove( eventImageToDeletion );

                await context.SaveChangesAsync();
            }
        }


        public async Task<EventImage> GetEntityById(int id)
        {
            return await context.EventImages.FindAsync( id );
        }


        public async Task Update(EventImage item)
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