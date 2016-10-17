using System.Linq;
using System.Threading.Tasks;

using ScaleModeling.Domain.Abstract;
using ScaleModeling.Domain.Entities;
using ScaleModeling.Domain.EF;

namespace ScaleModeling.Domain.Concrete
{
    public class ForumTopicRepository : IRepository<ForumTopic>
    {
        private ApplicationDbContext context = new ApplicationDbContext();

        public IQueryable<ForumTopic> Get
        {
            get
            {
                return context.ForumTopics;
            }
        }

        public async Task SaveChangesAsync()
        {
            await context.SaveChangesAsync();
        }
    }
}