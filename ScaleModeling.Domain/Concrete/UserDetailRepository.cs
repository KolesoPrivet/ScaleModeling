using System.Linq;

using ScaleModeling.Domain.Abstract;
using ScaleModeling.Domain.Entities;

namespace ScaleModeling.Domain.Concrete
{
    class UserDetailRepository : IRepository<UserDetail>
    {
        private EntityFrameworkDBContext context = new EntityFrameworkDBContext();

        public IQueryable<UserDetail> Get
        {
            get
            {
                return context.UserDetails;
            }
        }
    }
}