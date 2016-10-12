using System.Linq;

using ScaleModeling.Domain.Abstract;
using ScaleModeling.Domain.Entities;
using ScaleModeling.Domain.EF;

namespace ScaleModeling.Domain.Concrete
{
    public class UserNotificationRepository : IRepository<UserNotification, int>
    {
        private ApplicationDbContext context = new ApplicationDbContext();

        public IQueryable<UserNotification> Get
        {
            get
            {
                return context.UserNotifications;
            }
        }
    }
}