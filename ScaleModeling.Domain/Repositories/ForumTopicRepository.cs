using System.Linq;
using System.Threading.Tasks;
using System.Data.Entity;

using ScaleModeling.Domain.Abstract;
using ScaleModeling.Domain.Entities;
using ScaleModeling.Domain.EF;

namespace ScaleModeling.Domain.Repositories
{
    public class ForumTopicRepository : IRepository<ForumTopic>
    {
        private ApplicationDbContext context = new ApplicationDbContext();

        public IQueryable<ForumTopic> GetAll
        {
            get
            {
                return context.ForumTopics;
            }
        }


        public async Task Create(ForumTopic item)
        {
            if (item != null)
            {
                await Task.Factory.StartNew( () => context.ForumTopics.Add( item ) );
            }
        }


        public async Task Delete(int id)
        {
            ForumTopic topicToDeletion = await context.ForumTopics.FindAsync( id );

            if (topicToDeletion != null)
            {
                context.ForumTopics.Remove( topicToDeletion );

                await context.SaveChangesAsync();
            }
        }


        public async Task<ForumTopic> GetEntityById(int id)
        {
            return await context.ForumTopics.FindAsync( id );
        }


        public async Task Update(ForumTopic item)
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