using ScaleModeling.Domain.Abstract;

namespace ScaleModeling.Domain.Entities
{
    public class ProductImage : IEntity
    {
        public int Id { get; set; }

        public string Image { get; set; }

        public int ProductId { get; set; }
        public virtual Product Product { get; set; }
    }
}
