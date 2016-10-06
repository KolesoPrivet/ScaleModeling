using System;
using System.Collections.Generic;

using ScaleModeling.Domain.Abstract;

namespace ScaleModeling.Domain.Entities
{
    public class VideoContent : IEntity
    {
        public int Id { get; set; }

        public string Title { get; set; }

        public string Video { get; set; }

        public string Description { get; set; }

        public DateTime CreationDate { get; set; }

        public int AuthorId { get; set; }
        public virtual User Author { get; set; }

        public virtual List<VideoComment> Comments { get; set; }
    }
}
