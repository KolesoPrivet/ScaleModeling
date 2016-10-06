using System.Linq;

using ScaleModeling.Domain.Abstract;
using ScaleModeling.Domain.Entities;

namespace ScaleModeling.Domain.Concrete
{
    class WorkImageRepository : IRepository<WorkImage>
    {
        private EntityFrameworkDBContext context = new EntityFrameworkDBContext();

        public IQueryable<WorkImage> Get
        {
            get
            {
                return context.WorkImages;
            }
        }
    }
}