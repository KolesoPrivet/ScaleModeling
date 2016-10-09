using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

using ScaleModeling.Domain.Abstract;

namespace ScaleModeling.Domain.Entities
{
    public class Article : IEntity
    {
        public int Id { get; set; }

        [Required( ErrorMessage = "Необходимо ввести заголовок статьи" )]
        [StringLength( 100, MinimumLength = 10, ErrorMessage = "Количество символов заголовка должно быть в диапазоне от 10 до 100" )]
        public string Title { get; set; }

        [Required( ErrorMessage = "Необходимо ввести описание статьи" )]
        public string Description { get; set; }

        public int Viewed { get; set; }

        public DateTime CreationDate { get; set; }

        public int Rating { get; set; }

        public int AuthorId { get; set; }
        public virtual User Author { get; set; }

        public virtual List<ArticleImage> Images { get; set; }
        public virtual List<ArticleComment> Comments { get; set; }
    }
}
