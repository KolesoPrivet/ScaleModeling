using System.Linq;
using System.Threading.Tasks;

namespace ScaleModeling.Domain.Abstract
{
    /// <summary>
    /// Common interface for all repositories.
    /// </summary>
    /// <typeparam name="TEntity">T - concrete entity.</typeparam>
    public interface IRepository<TEntity> where TEntity: IEntity
    {

        /// <summary>
        /// Return T - entities.
        /// </summary>
        IQueryable<TEntity> GetAll { get; }


        /// <summary>
        /// Return entity by id.
        /// </summary>
        Task<TEntity> GetEntityById(int id);


        /// <summary>
        /// Create T - entitiy.
        /// </summary>
        Task Create(TEntity item);


        /// <summary>
        /// Update T - entitiy.
        /// </summary>
        Task Update(TEntity item);


        /// <summary>
        /// Delete entity by id.
        /// </summary>
        Task Delete(int id);


        /// <summary>
        /// Asyncronosly saves changes in context.
        /// </summary>
        /// <returns></returns>
        Task SaveChangesAsync(); 
    }
}
