using System.Linq;

using ScaleModeling.Domain.Abstract;
using ScaleModeling.Domain.Entities;

namespace ScaleModeling.Domain.Concrete
{
    public class UserNotificationRepository : IRepository<UserNotification>
    {
        private EntityFrameworkDBContext context = new EntityFrameworkDBContext();

        public IQueryable<UserNotification> Get
        {
            get
            {
                return context.UserNotifications;
            }
        }
    }
}