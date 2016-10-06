using System.Linq;

using ScaleModeling.Domain.Abstract;
using ScaleModeling.Domain.Entities;

namespace ScaleModeling.Domain.Concrete
{
    public class WorkRepository : IRepository<Work>
    {
        private EntityFrameworkDBContext context = new EntityFrameworkDBContext();

        public IQueryable<Work> Get
        {
            get
            {
                return context.Works;
            }
        }
    }
}