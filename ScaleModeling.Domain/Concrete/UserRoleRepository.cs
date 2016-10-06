using System.Linq;

using ScaleModeling.Domain.Abstract;
using ScaleModeling.Domain.Entities;

namespace ScaleModeling.Domain.Concrete
{
    public class UserRoleRepository : IRepository<UserRole>
    {
        private EntityFrameworkDBContext context = new EntityFrameworkDBContext();

        public IQueryable<UserRole> Get
        {
            get
            {
                return context.UserRoles;
            }
        }
    }
}