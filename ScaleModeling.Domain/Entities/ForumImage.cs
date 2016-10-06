using ScaleModeling.Domain.Abstract;

namespace ScaleModeling.Domain.Entities
{
    public class ForumImage : IEntity
    {
        public int Id { get; set; }

        public string Image { get; set; }

        public int TopicId { get; set; }
        public virtual ForumTopic Topic { get; set; }
    }
}
