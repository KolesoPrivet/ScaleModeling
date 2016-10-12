using System;
using System.ComponentModel.DataAnnotations;

using ScaleModeling.Domain.Abstract;

namespace ScaleModeling.Domain.Entities
{
    public class EventComment : IEntity
    {
        public int Id { get; set; }

        [Required( ErrorMessage = "Необходимо ввести текст комментария" )]
        public string Text { get; set; }

        public DateTime CreationDate { get; set; }

        public string AuthorId { get; set; }
        public virtual User Author { get; set; }

        public int EventId { get; set; }
        public virtual Event Event { get; set; }
    }
}
