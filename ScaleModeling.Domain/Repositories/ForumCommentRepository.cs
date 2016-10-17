using System.Linq;
using System.Threading.Tasks;
using System.Data.Entity;

using ScaleModeling.Domain.Abstract;
using ScaleModeling.Domain.Entities;
using ScaleModeling.Domain.EF;

namespace ScaleModeling.Domain.Repositories
{
    public class ForumCommentRepository : IRepository<ForumComment>
    {
        private ApplicationDbContext context = new ApplicationDbContext();

        public IQueryable<ForumComment> GetAll
        {
            get
            {
                return context.ForumComments;
            }
        }


        public async Task Create(ForumComment item)
        {
            if (item != null)
            {
                await Task.Factory.StartNew( () => context.ForumComments.Add( item ) );
            }
        }


        public async Task Delete(int id)
        {
            ForumComment forumCommentToDeletion = await context.ForumComments.FindAsync( id );

            if (forumCommentToDeletion != null)
            {
                context.ForumComments.Remove( forumCommentToDeletion );

                await context.SaveChangesAsync();
            }
        }


        public async Task<ForumComment> GetEntityById(int id)
        {
            return await context.ForumComments.FindAsync( id );
        }


        public async Task Update(ForumComment item)
        {
            if (item != null)
            {
                await Task.Factory.StartNew( () => context.Entry( item ).State = EntityState.Modified );
            }
        }


        public async Task SaveChangesAsync()
        {
            await context.SaveChangesAsync();
        }
    }
}