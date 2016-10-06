using System.Collections.Generic;

using ScaleModeling.Domain.Abstract;

namespace ScaleModeling.Domain.Entities
{
    public class UserRole : IEntity
    {
        public int Id { get; set; }

        public string Role { get; set; }

        public string Description { get; set; }

        public virtual List<User> Users { get; set; }
    }
}
