using System.Linq;
using System.Threading.Tasks;
using System.Data.Entity;

using ScaleModeling.Domain.Abstract;
using ScaleModeling.Domain.Entities;
using ScaleModeling.Domain.EF;

namespace ScaleModeling.Domain.Repositories
{
    public class EventRepository : IRepository<Event>
    {
        private ApplicationDbContext context = new ApplicationDbContext();

        public IQueryable<Event> GetAll
        {
            get
            {
                return context.Events;
            }
        }


        public async Task Create(Event item)
        {
            if (item != null)
            {
                await Task.Factory.StartNew( () => context.Events.Add( item ) );
            }
        }


        public async Task Delete(int id)
        {
            Event eventToDeletion = await context.Events.FindAsync( id );

            if (eventToDeletion != null)
            {
                context.Events.Remove( eventToDeletion );

                await context.SaveChangesAsync();
            }
        }


        public async Task<Event> GetEntityById(int id)
        {
            return await context.Events.FindAsync( id );
        }


        public async Task Update(Event item)
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