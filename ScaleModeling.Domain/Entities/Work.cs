using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

using ScaleModeling.Domain.Abstract;

namespace ScaleModeling.Domain.Entities
{
    public class Work : IEntity
    {
        public int Id { get; set; }

        [StringLength( 100, MinimumLength = 10, ErrorMessage = "Количество символов заголовка должно быть в диапазоне от 10 до 100" )]
        public string Title { get; set; }

        public string Description { get; set; }

        public int Viewed { get; set; }

        public DateTime CreationDate { get; set; }

        public int Rating { get; set; }

        public string AuthorId { get; set; }
        public virtual User Author { get; set; }

        public virtual List<WorkImage> Images { get; set; }
        public virtual List<WorkComment> Comments { get; set; }
    }
}
