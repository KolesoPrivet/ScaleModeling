using System.Linq;

using ScaleModeling.Domain.Abstract;
using ScaleModeling.Domain.Entities;
using ScaleModeling.Domain.EF;

namespace ScaleModeling.Domain.Concrete
{
    public class WorkRepository : IRepository<Work, int>
    {
        private ApplicationDbContext context = new ApplicationDbContext();

        public IQueryable<Work> Get
        {
            get
            {
                return context.Works;
            }
        }
    }
}