using System;

using ScaleModeling.Domain.Abstract;

namespace ScaleModeling.Domain.Entities
{
    public class ProductComment : IEntity
    {
        public int Id { get; set; }

        public string Text { get; set; }

        public string Rating { get; set; }

        public DateTime CreationDate { get; set; }

        public int AuthorId { get; set; }
        public virtual User Author { get; set; }

        public int ProductId { get; set; }
        public virtual Product Product { get; set; }
    }
}
