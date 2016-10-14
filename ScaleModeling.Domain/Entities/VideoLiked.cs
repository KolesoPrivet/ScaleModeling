using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ScaleModeling.Domain.Entities
{
    public class VideoLiked
    {
        [Key]
        [ForeignKey("User")]
        [Column(Order = 1)]
        public int UserId { get; set; }
        public virtual User User { get; set; }

        [Key]
        [ForeignKey( "VideoContent" )]
        [Column( Order = 2 )]
        public int VideoId { get; set; }
        public virtual VideoContent VideoContent { get; set; }
    }
}
