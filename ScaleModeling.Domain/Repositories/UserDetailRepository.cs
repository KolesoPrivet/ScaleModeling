using System.Linq;
using System.Threading.Tasks;
using System.Data.Entity;

using ScaleModeling.Domain.Abstract;
using ScaleModeling.Domain.Entities;
using ScaleModeling.Domain.EF;

namespace ScaleModeling.Domain.Repositories
{
    public class UserDetailRepository : IRepository<UserDetail>
    {
        private ApplicationDbContext context = new ApplicationDbContext();

        public IQueryable<UserDetail> GetAll
        {
            get
            {
                return context.UserDetails;
            }
        }


        public async Task Create(UserDetail item)
        {
            if (item != null)
            {
                await Task.Factory.StartNew( () => context.UserDetails.Add( item ) );
            }
        }


        public async Task Delete(int id)
        {
            UserDetail detailToDeletion = await context.UserDetails.FindAsync( id );

            if (detailToDeletion != null)
            {
                context.UserDetails.Remove( detailToDeletion );

                await context.SaveChangesAsync();
            }
        }


        public async Task<UserDetail> GetEntityById(int id)
        {
            return await context.UserDetails.FindAsync( id );
        }


        public async Task Update(UserDetail item)
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