using System.Linq;
using System.Threading.Tasks;
using System.Data.Entity;

using ScaleModeling.Domain.Abstract;
using ScaleModeling.Domain.Entities;
using ScaleModeling.Domain.EF;

namespace ScaleModeling.Domain.Repositories
{
    public class ArticleCommentRepository : IRepository<ArticleComment>
    {
        private ApplicationDbContext context;


        public ArticleCommentRepository()
        {
            context = new ApplicationDbContext();
        }


        public IQueryable<ArticleComment> GetAll
        {
            get
            {
                return context.ArticleComments;
            }
        }


        public async Task Create(ArticleComment item)
        {
            if (item != null)
            {
                await Task.Factory.StartNew( () => context.ArticleComments.Add( item ) );
            }
        }


        public async Task Delete(int id)
        {
            ArticleComment articleCommentToDeletion = await context.ArticleComments.FindAsync( id );

            if (articleCommentToDeletion != null)
            {
                context.ArticleComments.Remove( articleCommentToDeletion );

                await context.SaveChangesAsync();
            }
        }


        public async Task<ArticleComment> GetEntityById(int id)
        {
            return await context.ArticleComments.FindAsync( id );
        }


        public async Task SaveChangesAsync()
        {
            await context.SaveChangesAsync();
        }


        public async Task Update(ArticleComment item)
        {
            if (item != null)
            {
                await Task.Factory.StartNew( () => context.Entry( item ).State = EntityState.Modified );
            }
        }
    }
}