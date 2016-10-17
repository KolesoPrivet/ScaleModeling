using System.Linq;
using System.Threading.Tasks;
using System.Data.Entity;

using ScaleModeling.Domain.Abstract;
using ScaleModeling.Domain.Entities;
using ScaleModeling.Domain.EF;

namespace ScaleModeling.Domain.Repositories
{
    public class WorkRepository : IRepository<Work>
    {
        private ApplicationDbContext context = new ApplicationDbContext();

        public IQueryable<Work> GetAll
        {
            get
            {
                return context.Works;
            }
        }


        public async Task Create(Work item)
        {
            if (item != null)
            {
                await Task.Factory.StartNew( () => context.Works.Add( item ) );
            }
        }


        public async Task Delete(int id)
        {
            Work workToDeletion = await context.Works.FindAsync( id );

            if (workToDeletion != null)
            {
                context.Works.Remove( workToDeletion );

                await context.SaveChangesAsync();
            }
        }


        public async Task<Work> GetEntityById(int id)
        {
            return await context.Works.FindAsync( id );
        }


        public async Task Update(Work item)
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