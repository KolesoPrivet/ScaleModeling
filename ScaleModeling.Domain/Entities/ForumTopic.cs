using System;
using System.Collections.Generic;

using ScaleModeling.Domain.Abstract;

namespace ScaleModeling.Domain.Entities
{
    public class ForumTopic : IEntity
    {
        public int Id { get; set; }

        public string Title { get; set; }

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
