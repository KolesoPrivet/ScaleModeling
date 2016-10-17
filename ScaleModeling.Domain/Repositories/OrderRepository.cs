using System.Linq;
using System.Threading.Tasks;
using System.Data.Entity;

using ScaleModeling.Domain.Abstract;
using ScaleModeling.Domain.Entities;
using ScaleModeling.Domain.EF;

namespace ScaleModeling.Domain.Repositories
{
    public class OrderRepository : IRepository<Order>
    {
        private ApplicationDbContext context = new ApplicationDbContext();

        public IQueryable<Order> GetAll
        {
            get
            {
                return context.Orders;
            }
        }


        public async Task Create(Order item)
        {
            if (item != null)
            {
                await Task.Factory.StartNew( () => context.Orders.Add( item ) );
            }
        }


        public async Task Delete(int id)
        {
            Order orderToDeletion = await context.Orders.FindAsync( id );

            if (orderToDeletion != null)
            {
                context.Orders.Remove( orderToDeletion );

                await context.SaveChangesAsync();
            }
        }


        public async Task<Order> GetEntityById(int id)
        {
            return await context.Orders.FindAsync( id );
        }


        public async Task Update(Order item)
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