using System;
using System.Collections.Generic;

using ScaleModeling.Domain.Abstract;

namespace ScaleModeling.Domain.Entities
{
    public class Article : IEntity
    {
        public int Id { get; set; }

        public string Title { get; set; }

        public string Description { get; set; }

        public int Viewed { get; set; }

        public DateTime CreationDate { get; set; }

        public int AuthorId { get; set; }
        public virtual User Author { get; set; }

        public virtual List<ArticleImage> Images { get; set; }
        public virtual List<ArticleComment> Comments { get; set; }
    }
}
