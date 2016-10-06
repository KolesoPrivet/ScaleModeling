using ScaleModeling.Domain.Abstract;

namespace ScaleModeling.Domain.Entities
{
    public class EventImage : IEntity
    {
        public int Id { get; set; }

        public string Image { get; set; }

        public int EventId { get; set; }
        public virtual Event Event { get; set; }
    }
}
