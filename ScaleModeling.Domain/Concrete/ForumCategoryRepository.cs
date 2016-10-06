using System.Linq;

using ScaleModeling.Domain.Abstract;
using ScaleModeling.Domain.Entities;

namespace ScaleModeling.Domain.Concrete
{
    class ForumCategoryRepository : IRepository<ForumCategory>
    {
        private EntityFrameworkDBContext context = new EntityFrameworkDBContext();

        public IQueryable<ForumCategory> Get
        {
            get
            {
                return context.ForumCategories;
            }
        }
    }
}