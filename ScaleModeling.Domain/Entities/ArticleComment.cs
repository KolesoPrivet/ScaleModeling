﻿using System;

using ScaleModeling.Domain.Abstract;
using System.ComponentModel.DataAnnotations.Schema;

namespace ScaleModeling.Domain.Entities
{
    public class ArticleComment : IEntity
    {
        [DatabaseGenerated( DatabaseGeneratedOption.Identity )]
        public int Id { get; set; }

        public string Text { get; set; }

        public DateTime CreationDate { get; set; }

        public int AuthorId { get; set; }
        public virtual User Author { get; set; }

        public int ArticleId { get; set; }
        public virtual Article Article { get; set; }
    }
}
