using System.Linq;

using ScaleModeling.Domain.Abstract;
using ScaleModeling.Domain.Entities;

namespace ScaleModeling.Domain.Concrete
{
    class ArticleCommentRepository : IRepository<ArticleComment>
    {
        private EntityFrameworkDBContext context = new EntityFrameworkDBContext();

        public IQueryable<ArticleComment> Get
        {
            get
            {
                return context.ArticleComments;
            }
        }
    }
}