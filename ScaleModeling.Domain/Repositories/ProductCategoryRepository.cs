using System.Linq;
using System.Threading.Tasks;
using System.Data.Entity;

using ScaleModeling.Domain.Abstract;
using ScaleModeling.Domain.Entities;
using ScaleModeling.Domain.EF;

namespace ScaleModeling.Domain.Repositories
{
    public class ProductCategoryRepository : IRepository<ProductCategory>
    {
        private ApplicationDbContext context = new ApplicationDbContext();

        public IQueryable<ProductCategory> GetAll
        {
            get
            {
                return context.ProductCategories;
            }
        }


        public async Task Create(ProductCategory item)
        {
            if (item != null)
            {
                await Task.Factory.StartNew( () => context.ProductCategories.Add( item ) );
            }
        }


        public async Task Delete(int id)
        {
            ProductCategory categoryToDeletion = await context.ProductCategories.FindAsync( id );

            if (categoryToDeletion != null)
            {
                context.ProductCategories.Remove( categoryToDeletion );

                await context.SaveChangesAsync();
            }
        }


        public async Task<ProductCategory> GetEntityById(int id)
        {
            return await context.ProductCategories.FindAsync( id );
        }


        public async Task Update(ProductCategory item)
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