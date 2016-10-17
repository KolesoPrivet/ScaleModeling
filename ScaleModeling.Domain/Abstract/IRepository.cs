using System.Linq;
using System.Threading.Tasks;

namespace ScaleModeling.Domain.Abstract
{
    /// <summary>
    /// Common interface for all repositories.
    /// </summary>
    /// <typeparam name="T">T - concrete entity.</typeparam>
    public interface IRepository<T> where T: IEntity
    {
        /// <summary>
        /// Return T - entities.
        /// </summary>
        IQueryable<T> Get { get; }

        Task SaveChangesAsync(); 
    }
}
