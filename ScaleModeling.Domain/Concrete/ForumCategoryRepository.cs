using System.Linq;

using ScaleModeling.Domain.Abstract;
using ScaleModeling.Domain.Entities;
using ScaleModeling.Domain.EF;

namespace ScaleModeling.Domain.Concrete
{
    public class ForumCategoryRepository : IRepository<ForumCategory, int>
    {
        private ApplicationDbContext context = new ApplicationDbContext();

        public IQueryable<ForumCategory> Get
        {
            get
            {
                return context.ForumCategories;
            }
        }
    }
}