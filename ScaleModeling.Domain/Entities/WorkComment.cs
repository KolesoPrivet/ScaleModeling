using System;

using ScaleModeling.Domain.Abstract;

namespace ScaleModeling.Domain.Entities
{
    public class WorkComment : IEntity
    {
        public int Id { get; set; }

        public string Text { get; set; }

        public DateTime CreationDate { get; set; }

        public int AuthorId { get; set; }
        public virtual User Author { get; set; }

        public int WorkId { get; set; }
        public virtual Work Work { get; set; }
    }
}
