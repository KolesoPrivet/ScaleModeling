using System;
using System.ComponentModel.DataAnnotations;

using ScaleModeling.Domain.Abstract;

namespace ScaleModeling.Domain.Entities
{
    public class ForumComment : IEntity
    {
        public int Id { get; set; }

        [Required( ErrorMessage = "Необходимо ввести текст комментария" )]
        public string Text { get; set; }

        public DateTime CreationDate { get; set; }

        public string AuthorId { get; set; }
        public virtual User Author { get; set; }

        public int TopicId { get; set; }
        public virtual ForumTopic Topic { get; set; }
    }
}
