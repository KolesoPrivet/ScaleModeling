using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

using ScaleModeling.Domain.Abstract;

namespace ScaleModeling.Domain.Entities
{
    public class VideoContent : IEntity
    {
        public int Id { get; set; }

        [Required( ErrorMessage = "Необходимо ввести заголовок видео" )]
        [StringLength( 100, MinimumLength = 10, ErrorMessage = "Количество символов заголовка должно быть в диапазоне от 10 до 100" )]
        public string Title { get; set; }

        public string Video { get; set; }

        public string Description { get; set; }

        public DateTime CreationDate { get; set; }

        public int AuthorId { get; set; }
        public virtual User Author { get; set; }

        public virtual List<VideoLiked> Likes { get; set; }
        public virtual List<VideoComment> Comments { get; set; }
    }
}
