using ScaleModeling.Domain.Abstract;

namespace ScaleModeling.Domain.Entities
{
    public class WorkImage : IEntity
    {
        public int Id { get; set; }

        public string Image { get; set; }

        public virtual Work Work { get; set; }
    }
}
