using System.Linq;
using System.Threading.Tasks;

using ScaleModeling.Domain.Abstract;
using ScaleModeling.Domain.Entities;
using ScaleModeling.Domain.EF;


namespace ScaleModeling.Domain.Concrete
{
    public class UserDetailRepository : IRepository<UserDetail>
    {
        private ApplicationDbContext context = new ApplicationDbContext();

        public IQueryable<UserDetail> Get
        {
            get
            {
                return context.UserDetails;
            }
        }

        public async Task<int> SaveChanges()
        {
            return await context.SaveChangesAsync();
        }
    }
}