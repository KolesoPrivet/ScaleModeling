﻿using System.Data.Entity;

using ScaleModeling.Domain.Entities;

namespace ScaleModeling.Domain.Concrete
{
    public class EntityFrameworkDBContext : DbContext
    {
        public EntityFrameworkDBContext() : base( "name = ScaleModeling_Content" )
        {
        }

        public virtual DbSet<User> Users { get; set; }
        public virtual DbSet<UserDetail> UserDetails { get; set; }
        public virtual DbSet<UserRole> UserRoles { get; set; }
        public virtual DbSet<UserNotification> UserNotifications { get; set; }

        public virtual DbSet<Article> Articles { get; set; }
        public virtual DbSet<ArticleComment> ArticleComments { get; set; }
        public virtual DbSet<ArticleImage> ArticleImages { get; set; }

        public virtual DbSet<Event> Events { get; set; }
        public virtual DbSet<EventComment> EventComments { get; set; }
        public virtual DbSet<EventImage> EventImages { get; set; }

        public virtual DbSet<Work> Works { get; set; }
        public virtual DbSet<WorkComment> WorkComments { get; set; }
        public virtual DbSet<WorkImage> WorkImages { get; set; }

        public virtual DbSet<VideoContent> Videos { get; set; }
        public virtual DbSet<VideoComment> VideoComments { get; set; }

        public virtual DbSet<ForumTopic> ForumTopics { get; set; }
        public virtual DbSet<ForumCategory> ForumCategories { get; set; }
        public virtual DbSet<ForumComment> ForumComments { get; set; }
        public virtual DbSet<ForumImage> ForumImages { get; set; }

        public virtual DbSet<Product> Products { get; set; }
        public virtual DbSet<ProductCategory> ProductCategories { get; set; }
        public virtual DbSet<ProductComment> ProductComments { get; set; }
        public virtual DbSet<ProductImage> ProductImages { get; set; }

        public virtual DbSet<WishList> WishLists { get; set; }

        public virtual DbSet<Order> Orders { get; set; }
    }
}
