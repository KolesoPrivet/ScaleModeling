using System.Linq;
using System.Threading.Tasks;
using System.Data.Entity;

using ScaleModeling.Domain.Abstract;
using ScaleModeling.Domain.Entities;
using ScaleModeling.Domain.EF;

namespace ScaleModeling.Domain.Repositories
{
    public class UserNotificationRepository : IRepository<UserNotification>
    {
        private ApplicationDbContext context = new ApplicationDbContext();

        public IQueryable<UserNotification> GetAll
        {
            get
            {
                return context.UserNotifications;
            }
        }


        public async Task Create(UserNotification item)
        {
            if (item != null)
            {
                await Task.Factory.StartNew( () => context.UserNotifications.Add( item ) );
            }
        }


        public async Task Delete(int id)
        {
            UserNotification notificationToDeletion = await context.UserNotifications.FindAsync( id );

            if (notificationToDeletion != null)
            {
                context.UserNotifications.Remove( notificationToDeletion );

                await context.SaveChangesAsync();
            }
        }


        public async Task<UserNotification> GetEntityById(int id)
        {
            return await context.UserNotifications.FindAsync( id );
        }


        public async Task Update(UserNotification item)
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