namespace ScaleModeling.Domain.Abstract
{
    /// <summary>
    /// Common interface for all entities.
    /// </summary>
    public interface IEntity
    {
        /// <summary>
        /// All entities must have id.
        /// </summary>
        int Id { get; set; }
    }
}
