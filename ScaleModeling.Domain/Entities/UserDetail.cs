using ScaleModeling.Domain.Abstract;

namespace ScaleModeling.Domain.Entities
{
    public class UserDetail : IEntity
    {
        public int Id { get; set; }

        public int Rating { get; set; }

        public string Avatar { get; set; }

        public string FirstName { get; set; } 

        public string SecondName { get; set; }

        public string About { get; set; }

        public string City { get; set; }

        public int UserId { get; set; }
        public virtual User User { get; set; }
    }
}
