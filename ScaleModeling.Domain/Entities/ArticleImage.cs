using ScaleModeling.Domain.Abstract;

namespace ScaleModeling.Domain.Entities
{
    public class ArticleImage : IEntity
    {
        public int Id { get; set; }

        public string Image { get; set; }

        public int ArticleId { get; set; }
        public virtual Article Article { get; set; }
    }
}
