namespace ScaleModeling.Domain.Abstract
{
    public interface IEntity<T>
    {
        T Id { get; set; }
    }

    /// <summary>
    /// Common interface for all entities.
    /// </summary>
    public interface IEntity: IEntity<int>
    {
        /// <summary>
        /// All entities must have id.
        /// </summary>
        new int Id { get; set; }
    }
}
