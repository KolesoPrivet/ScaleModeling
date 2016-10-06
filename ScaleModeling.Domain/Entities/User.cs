using System;
using System.Collections.Generic;

using ScaleModeling.Domain.Abstract;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ScaleModeling.Domain.Entities
{
    public class User : IEntity
    {
        [Key]
        [ForeignKey("UserDetail")]
        public int Id { get; set; }

        public string Login { get; set; }

        public string Password { get; set; }

        public string Email { get; set; }

        public DateTime LastLogin { get; set; }

        public int RoleId { get; set; }
        public virtual UserRole Role { get; set; }
        public virtual UserDetail UserDetail { get; set; }

        public virtual List<Article> Articles { get; set; }
        public virtual List<ArticleComment> ArticleComments { get; set; }

        public virtual List<Work> Works { get; set; }
        public virtual List<WorkComment> WorkComments { get; set; }

        public virtual List<Event> Events { get; set; }
        public virtual List<EventComment> EventComments { get; set; }

        public virtual List<VideoContent> Videos { get; set; }
        public virtual List<VideoComment> VideoComments { get; set; }

        public virtual List<ForumTopic> ForumTopics { get; set; }
        public virtual List<ForumComment> ForumComments { get; set; }
    }
}
