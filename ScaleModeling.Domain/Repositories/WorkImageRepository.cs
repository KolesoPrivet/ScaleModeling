using System.Linq;
using System.Threading.Tasks;
using System.Data.Entity;

using ScaleModeling.Domain.Abstract;
using ScaleModeling.Domain.Entities;
using ScaleModeling.Domain.EF;

namespace ScaleModeling.Domain.Repositories
{
    public class WorkImageRepository : IRepository<WorkImage>
    {
        private ApplicationDbContext context = new ApplicationDbContext();

        public IQueryable<WorkImage> GetAll
        {
            get
            {
                return context.WorkImages;
            }
        }


        public async Task Create(WorkImage item)
        {
            if (item != null)
            {
                await Task.Factory.StartNew( () => context.WorkImages.Add( item ) );
            }
        }


        public async Task Delete(int id)
        {
            WorkImage workImageToDeletion = await context.WorkImages.FindAsync( id );

            if (workImageToDeletion != null)
            {
                context.WorkImages.Remove( workImageToDeletion );

                await context.SaveChangesAsync();
            }
        }


        public async Task<WorkImage> GetEntityById(int id)
        {
            return await context.WorkImages.FindAsync( id );
        }


        public async Task Update(WorkImage item)
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