using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ScaleModeling.Domain.Entities
{
    public class WorkLiked
    {
        [Key]
        [ForeignKey( "User" )]
        [Column( Order = 1 )]
        public int UserId { get; set; }
        public virtual User User { get; set; }

        [Key]
        [ForeignKey( "Work" )]
        [Column( Order = 2 )]
        public int WorkId { get; set; }
        public virtual Work Work { get; set; }
    }
}
