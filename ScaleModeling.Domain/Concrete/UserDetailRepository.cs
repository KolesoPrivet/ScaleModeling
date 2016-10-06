using System.Linq;

using ScaleModeling.Domain.Abstract;
using ScaleModeling.Domain.Entities;

namespace ScaleModeling.Domain.Concrete
{
    public class UserDetailRepository : IRepository<UserDetail>
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