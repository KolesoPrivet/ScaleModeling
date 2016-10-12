using ScaleModeling.Domain.Abstract;

namespace ScaleModeling.Domain.Entities
{
    public class WishList : IEntity
    {
        public int Id { get; set; }

        public string UserId { get; set; }
        public virtual User User { get; set; }

        public int ProductId { get; set; }
        public virtual Product Product { get; set; }
    }
}
