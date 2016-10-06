using System.Collections.Generic;

using ScaleModeling.Domain.Abstract;

namespace ScaleModeling.Domain.Entities
{
    public class ForumCategory : IEntity
    {
        public int Id { get; set; }

        public string Title { get; set; }

        public string Description { get; set; }

        public virtual List<ForumTopic> Topics { get; set; }
    }
}
