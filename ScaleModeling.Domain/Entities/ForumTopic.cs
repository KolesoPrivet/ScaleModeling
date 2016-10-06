using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

using ScaleModeling.Domain.Abstract;

namespace ScaleModeling.Domain.Entities
{
    public class ForumTopic : IEntity
    {
        public int Id { get; set; }

        [Required( ErrorMessage = "Необходимо ввести заголовок темы" )]
        [StringLength( 100, MinimumLength = 10, ErrorMessage = "Количество символов заголовка должно быть в диапазоне от 10 до 100" )]
        public string Title { get; set; }

        [Required( ErrorMessage = "Необходимо ввести описание темы" )]
        public string Text { get; set; }

        public int Viewed { get; set; }

        public DateTime CreationDate { get; set; }

        public int AuthorId { get; set; }
        public virtual User Author { get; set; }

        public int CategoryId { get; set; }
        public virtual ForumCategory Category { get; set; }

        public virtual List<ForumImage> Images { get; set; }
        public virtual List<ForumComment> Comments { get; set; }
    }
}
