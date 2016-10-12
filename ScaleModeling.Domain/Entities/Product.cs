using System.Collections.Generic;

using ScaleModeling.Domain.Abstract;
using System;

namespace ScaleModeling.Domain.Entities
{
    public class Product : IEntity
    {
        public int Id { get; set; }

        public string Name { get; set; }

        public string Description { get; set; }

        public decimal Price { get; set; }

        public int Rating { get; set; }

        public int? ProductCount { get; set; }

        public DateTime AdditionDate { get; set; }

        public int CategoryId { get; set; }
        public virtual ProductCategory Category { get; set; }

        public virtual List<Order> Orders { get; set; }

        public virtual List<ProductComment> ProductComments { get; set; }

        public virtual List<ProductImage> ProductImages { get; set; }

        public virtual List<UserNotification> UserNotifications { get; set; }

        public virtual List<WishList> WishLists { get; set; }
    }
}
