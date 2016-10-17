using System.Linq;
using System.Threading.Tasks;
using System.Data.Entity;

using ScaleModeling.Domain.Abstract;
using ScaleModeling.Domain.Entities;
using ScaleModeling.Domain.EF;

namespace ScaleModeling.Domain.Repositories
{
    public class WishListRepository : IRepository<WishList>
    {
        private ApplicationDbContext context = new ApplicationDbContext();

        public IQueryable<WishList> GetAll
        {
            get
            {
                return context.WishLists;
            }
        }


        public async Task Create(WishList item)
        {
            if (item != null)
            {
                await Task.Factory.StartNew( () => context.WishLists.Add( item ) );
            }
        }


        public async Task Delete(int id)
        {
            WishList wishlistToDeletion = await context.WishLists.FindAsync( id );

            if (wishlistToDeletion != null)
            {
                context.WishLists.Remove( wishlistToDeletion );

                await context.SaveChangesAsync();
            }
        }


        public async Task<WishList> GetEntityById(int id)
        {
            return await context.WishLists.FindAsync( id );
        }


        public async Task Update(WishList item)
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