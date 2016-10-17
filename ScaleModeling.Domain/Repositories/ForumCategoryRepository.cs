using System.Linq;
using System.Threading.Tasks;
using System.Data.Entity;

using ScaleModeling.Domain.Abstract;
using ScaleModeling.Domain.Entities;
using ScaleModeling.Domain.EF;

namespace ScaleModeling.Domain.Repositories
{
    public class ForumCategoryRepository : IRepository<ForumCategory>
    {
        private ApplicationDbContext context = new ApplicationDbContext();

        public IQueryable<ForumCategory> GetAll
        {
            get
            {
                return context.ForumCategories;
            }
        }


        public async Task Create(ForumCategory item)
        {
            if (item != null)
            {
                await Task.Factory.StartNew( () => context.ForumCategories.Add( item ) );
            }
        }


        public async Task Delete(int id)
        {
            ForumCategory categoryToDeletion = await context.ForumCategories.FindAsync( id );

            if (categoryToDeletion != null)
            {
                context.ForumCategories.Remove( categoryToDeletion );

                await context.SaveChangesAsync();
            }
        }


        public async Task<ForumCategory> GetEntityById(int id)
        {
            return await context.ForumCategories.FindAsync( id );
        }


        public async Task Update(ForumCategory item)
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