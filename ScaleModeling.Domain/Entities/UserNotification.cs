using System.ComponentModel.DataAnnotations;

using ScaleModeling.Domain.Abstract;

namespace ScaleModeling.Domain.Entities
{
    public class UserNotification : IEntity
    {
        public int Id { get; set; }

        [Required( ErrorMessage = "Необходимо ввести электронную почту" )]
        [DataType( DataType.EmailAddress )]
        public string Email { get; set; }

        public int UserId { get; set; }
        public virtual User User { get; set; }

        public int ProductId { get; set; }
        public virtual Product Product { get; set; }
    }
}
