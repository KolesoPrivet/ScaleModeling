using System.Linq;
using System.Threading.Tasks;
using System.Data.Entity;

using ScaleModeling.Domain.Abstract;
using ScaleModeling.Domain.Entities;
using ScaleModeling.Domain.EF;

namespace ScaleModeling.Domain.Repositories
{
    public class ProductCommentRepository : IRepository<ProductComment>
    {
        private ApplicationDbContext context = new ApplicationDbContext();

        public IQueryable<ProductComment> GetAll
        {
            get
            {
                return context.ProductComments;
            }
        }


        public async Task Create(ProductComment item)
        {
            if (item != null)
            {
                await Task.Factory.StartNew( () => context.ProductComments.Add( item ) );
            }
        }


        public async Task Delete(int id)
        {
            ProductComment productCommentToDeletion = await context.ProductComments.FindAsync( id );

            if (productCommentToDeletion != null)
            {
                context.ProductComments.Remove( productCommentToDeletion );

                await context.SaveChangesAsync();
            }
        }


        public async Task<ProductComment> GetEntityById(int id)
        {
            return await context.ProductComments.FindAsync( id );
        }


        public async Task Update(ProductComment item)
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