using System.Collections.Generic;
using System.Security.Claims;
using System.Threading.Tasks;
using Microsoft.AspNet.Identity;
using Microsoft.AspNet.Identity.EntityFramework;

using ScaleModeling.Domain.Abstract;


namespace ScaleModeling.Domain.Entities
{
    public class User : IdentityUser<int, UserLogin, UserRole, UserClaim>, IEntity
    {
        //public DateTime LastLogin { get; set; }

        public async Task<ClaimsIdentity> GenerateUserIdentityAsync(UserManager<User, int> manager)
        {
            // Обратите внимание, что authenticationType должен совпадать с типом, определенным в CookieAuthenticationOptions.AuthenticationType
            var userIdentity = await manager.CreateIdentityAsync( this, DefaultAuthenticationTypes.ApplicationCookie );
            // Здесь добавьте утверждения пользователя
            return userIdentity;
        }

        public virtual UserDetail UserDetail { get; set; }
        public virtual List<UserNotification> UserNotifications { get; set; }

        public virtual List<Article> Articles { get; set; }
        public virtual List<ArticleComment> ArticleComments { get; set; }
        public virtual List<ArticleLiked> ArticleLikes { get; set; }

        public virtual List<Work> Works { get; set; }
        public virtual List<WorkComment> WorkComments { get; set; }
        public virtual List<WorkLiked> WorkLikes { get; set; }

        public virtual List<Event> Events { get; set; }
        public virtual List<EventComment> EventComments { get; set; }

        public virtual List<VideoContent> Videos { get; set; }
        public virtual List<VideoComment> VideoComments { get; set; }
        public virtual List<VideoLiked> VideoLikes { get; set; }

        public virtual List<ForumTopic> ForumTopics { get; set; }
        public virtual List<ForumComment> ForumComments { get; set; }

        public virtual List<Order> Orders { get; set; }

        public virtual List<ProductComment> ProductComments { get; set; }

        public virtual List<WishList> WishLists { get; set; }
    }
}
