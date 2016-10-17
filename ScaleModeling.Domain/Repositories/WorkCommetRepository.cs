using System.Linq;
using System.Threading.Tasks;
using System.Data.Entity;

using ScaleModeling.Domain.Abstract;
using ScaleModeling.Domain.Entities;
using ScaleModeling.Domain.EF;

namespace ScaleModeling.Domain.Repositories
{
    public class WorkCommentRepository : IRepository<WorkComment>
    {
        private ApplicationDbContext context = new ApplicationDbContext();

        public IQueryable<WorkComment> GetAll
        {
            get
            {
                return context.WorkComments;
            }
        }


        public async Task Create(WorkComment item)
        {
            if (item != null)
            {
                await Task.Factory.StartNew( () => context.WorkComments.Add( item ) );
            }
        }


        public async Task Delete(int id)
        {
            WorkComment workCommentToDeletion = await context.WorkComments.FindAsync( id );

            if (workCommentToDeletion != null)
            {
                context.WorkComments.Remove( workCommentToDeletion );

                await context.SaveChangesAsync();
            }
        }


        public async Task<WorkComment> GetEntityById(int id)
        {
            return await context.WorkComments.FindAsync( id );
        }


        public async Task Update(WorkComment item)
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