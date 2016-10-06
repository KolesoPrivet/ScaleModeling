using System;

using ScaleModeling.Domain.Abstract;

namespace ScaleModeling.Domain.Entities
{
    public class EventComment : IEntity
    {
        public int Id { get; set; }

        public string Text { get; set; }

        public DateTime CreationDate { get; set; }

        public int AuthorId { get; set; }
        public virtual User Author { get; set; }

        public int EventId { get; set; }
        public virtual Event Event { get; set; }
    }
}
