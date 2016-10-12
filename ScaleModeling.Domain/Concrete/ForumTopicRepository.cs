using System.Linq;

using ScaleModeling.Domain.Abstract;
using ScaleModeling.Domain.Entities;
using ScaleModeling.Domain.EF;

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
    }
}