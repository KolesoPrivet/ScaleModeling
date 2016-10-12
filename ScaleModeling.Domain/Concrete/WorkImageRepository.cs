using System.Linq;

using ScaleModeling.Domain.Abstract;
using ScaleModeling.Domain.Entities;
using ScaleModeling.Domain.EF;

namespace ScaleModeling.Domain.Concrete
{
    public class WorkImageRepository : IRepository<WorkImage, int>
    {
        private ApplicationDbContext context = new ApplicationDbContext();

        public IQueryable<WorkImage> Get
        {
            get
            {
                return context.WorkImages;
            }
        }
    }
}