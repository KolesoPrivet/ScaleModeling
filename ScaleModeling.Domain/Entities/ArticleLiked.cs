using System;

using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ScaleModeling.Domain.Entities
{
    public class ArticleLiked
    {
        [Key]
        [ForeignKey( "User" )]  
        [Column( Order = 1 )]
        public int UserId { get; set; }
        public virtual User User { get; set; }

        [Key]
        [ForeignKey( "Article" )]
        [Column( Order = 2 )]
        public int ArticleId { get; set; }
        public virtual Article Article { get; set; }

        public DateTime LikedDate { get; set; }
    }
}
