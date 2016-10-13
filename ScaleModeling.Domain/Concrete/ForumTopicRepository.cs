using System.Linq;
using System.Threading.Tasks;

using ScaleModeling.Domain.Abstract;
using ScaleModeling.Domain.Entities;
using ScaleModeling.Domain.EF;
using System.Threading.Tasks;

namespace ScaleModeling.Domain.Concrete
{
    public class ForumTopicRepository : IRepository<ForumTopic, int>
    {
        private ApplicationDbContext context = new ApplicationDbContext();

        public IQueryable<ForumTopic> Get
        {
            get
            {
                return context.ForumTopics;
            }
        }

        public async Task<int> SaveChanges()
        {
            return await context.SaveChangesAsync();
        }
    }
}