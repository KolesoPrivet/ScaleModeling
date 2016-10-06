using System;
using System.ComponentModel.DataAnnotations;

using ScaleModeling.Domain.Abstract;

namespace ScaleModeling.Domain.Entities
{
    public class ArticleComment : IEntity
    {
        public int Id { get; set; }

        [Required( ErrorMessage = "Необходимо ввести текст комментария" )]
        public string Text { get; set; }

        public DateTime CreationDate { get; set; }

        public int AuthorId { get; set; }
        public virtual User Author { get; set; }

        public int ArticleId { get; set; }
        public virtual Article Article { get; set; }
    }
}
