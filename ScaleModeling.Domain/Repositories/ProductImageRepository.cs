using System.Linq;
using System.Threading.Tasks;
using System.Data.Entity;

using ScaleModeling.Domain.Abstract;
using ScaleModeling.Domain.Entities;
using ScaleModeling.Domain.EF;

namespace ScaleModeling.Domain.Repositories
{
    public class ProductImageRepository : IRepository<ProductImage>
    {
        private ApplicationDbContext context = new ApplicationDbContext();

        public IQueryable<ProductImage> GetAll
        {
            get
            {
                return context.ProductImages;
            }
        }


        public async Task Create(ProductImage item)
        {
            if (item != null)
            {
                await Task.Factory.StartNew( () => context.ProductImages.Add( item ) );
            }
        }


        public async Task Delete(int id)
        {
            ProductImage productImageToDeletion = await context.ProductImages.FindAsync( id );

            if (productImageToDeletion != null)
            {
                context.ProductImages.Remove( productImageToDeletion );

                await context.SaveChangesAsync();
            }
        }


        public async Task<ProductImage> GetEntityById(int id)
        {
            return await context.ProductImages.FindAsync( id );
        }


        public async Task Update(ProductImage item)
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