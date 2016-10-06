using System.Linq;

using ScaleModeling.Domain.Abstract;
using ScaleModeling.Domain.Entities;

namespace ScaleModeling.Domain.Concrete
{
    public class ForumTopicRepository : IRepository<ForumTopic>
    {
        private EntityFrameworkDBContext context = new EntityFrameworkDBContext();

        public IQueryable<ForumTopic> Get
        {
            get
            {
                return context.ForumTopics;
            }
        }
    }
}