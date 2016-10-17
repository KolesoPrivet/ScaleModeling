using System.Linq;
using System.Threading.Tasks;

using ScaleModeling.Domain.Abstract;
using ScaleModeling.Domain.Entities;
using ScaleModeling.Domain.EF;


namespace ScaleModeling.Domain.Concrete
{
    public class UserNotificationRepository : IRepository<UserNotification>
    {
        private ApplicationDbContext context = new ApplicationDbContext();

        public IQueryable<UserNotification> Get
        {
            get
            {
                return context.UserNotifications;
            }
        }

        public async Task SaveChangesAsync()
        {
            await context.SaveChangesAsync();
        }
    }
}