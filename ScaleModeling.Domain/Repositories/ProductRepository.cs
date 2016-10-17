using System.Linq;
using System.Threading.Tasks;
using System.Data.Entity;

using ScaleModeling.Domain.Abstract;
using ScaleModeling.Domain.Entities;
using ScaleModeling.Domain.EF;

namespace ScaleModeling.Domain.Repositories
{
    public class ProductRepository : IRepository<Product>
    {
        private ApplicationDbContext context = new ApplicationDbContext();

        public IQueryable<Product> GetAll
        {
            get
            {
                return context.Products;
            }
        }


        public async Task Create(Product item)
        {
            if (item != null)
            {
                await Task.Factory.StartNew( () => context.Products.Add( item ) );
            }
        }


        public async Task Delete(int id)
        {
            Product productToDeletion = await context.Products.FindAsync( id );

            if (productToDeletion != null)
            {
                context.Products.Remove( productToDeletion );

                await context.SaveChangesAsync();
            }
        }


        public async Task<Product> GetEntityById(int id)
        {
            return await context.Products.FindAsync( id );
        }


        public async Task Update(Product item)
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
