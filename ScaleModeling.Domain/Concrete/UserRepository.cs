using System.Linq;

using ScaleModeling.Domain.Abstract;
using ScaleModeling.Domain.Entities;

namespace ScaleModeling.Domain.Concrete
{
    public class UserRepository : IRepository<User>
    {
        private EntityFrameworkDBContext context = new EntityFrameworkDBContext();

        public IQueryable<User> Get
        {
            get
            {
                return context.Users;
            }
        }
    }
}