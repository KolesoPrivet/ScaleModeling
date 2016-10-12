using System;
using System.ComponentModel.DataAnnotations;

using ScaleModeling.Domain.Abstract;

namespace ScaleModeling.Domain.Entities
{
    public class Order : IEntity
    {
        public int Id { get; set; }

        public int ProductCount { get; set; }

        public decimal TotalPrice { get; set; }

        public DateTime OrderDate { get; set; }

        [Required]
        public string DeliveryAddress { get; set; }

        public string UserId { get; set; }
        public virtual User User { get; set; }

        public int ProductId { get; set; }
        public virtual Product Product { get; set; }
    }
}
