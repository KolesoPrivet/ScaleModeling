using Ninject;
using System;
using System.Collections.Generic;
using System.Web.Mvc;

using ScaleModeling.Domain.Abstract;
using ScaleModeling.Domain.Entities;
using ScaleModeling.Domain.Repositories;
using Microsoft.AspNet.Identity;
using Microsoft.AspNet.Identity.EntityFramework;

namespace ScaleModeling.WebUI.Infrastructure
{
    public class NinjectDependencyResolver : IDependencyResolver
    {
        private IKernel kernel;

        public NinjectDependencyResolver(IKernel kernelParam)
        {
            kernel = kernelParam;
            AddBindings();
        }

        public object GetService(Type serviceType)
        {
            return kernel.TryGet( serviceType );
        }

        public IEnumerable<object> GetServices(Type serviceType)
        {
            return kernel.GetAll( serviceType );
        }


        private void AddBindings()
        {
            //Events
            kernel.Bind<IRepository<Event>>().To<EventRepository>();

            kernel.Bind<IRepository<EventComment>>().To<EventCommentRepository>();

            kernel.Bind<IRepository<EventImage>>().To<EventImageRepository>();


            //Articles
            kernel.Bind<IRepository<Article>>().To<ArticleRepository>();

            kernel.Bind<IRepository<ArticleComment>>().To<ArticleCommentRepository>();

            kernel.Bind<IRepository<ArticleImage>>().To<ArticleImageRepository>();


            //Works
            kernel.Bind<IRepository<Work>>().To<WorkRepository>();

            kernel.Bind<IRepository<WorkComment>>().To<WorkCommentRepository>();

            kernel.Bind<IRepository<WorkImage>>().To<WorkImageRepository>();


            //Videos
            kernel.Bind<IRepository<VideoContent>>().To<VideoContentRepository>();

            kernel.Bind<IRepository<VideoComment>>().To<VideoCommentRepository>();


            //Users
            kernel.Bind<IUserStore<User, int>>().To<UserStore<User, Role, int, UserLogin, UserRole, UserClaim>>();

            kernel.Bind<IRepository<UserDetail>>().To<UserDetailRepository>();

            kernel.Bind<IRepository<UserNotification>>().To<UserNotificationRepository>();

            kernel.Bind<IRepository<WishList>>().To<WishListRepository>();


            kernel.Bind<UserManager<User, int>>().ToSelf();

            //Forum
            kernel.Bind<IRepository<ForumCategory>>().To<ForumCategoryRepository>();

            kernel.Bind<IRepository<ForumTopic>>().To<ForumTopicRepository>();

            kernel.Bind<IRepository<ForumImage>>().To<ForumImageRepository>();

            kernel.Bind<IRepository<ForumComment>>().To<ForumCommentRepository>();


            //Products
            kernel.Bind<IRepository<Product>>().To<ProductRepository>();

            kernel.Bind<IRepository<ProductCategory>>().To<ProductCategoryRepository>();

            kernel.Bind<IRepository<ProductComment>>().To<ProductCommentRepository>();

            kernel.Bind<IRepository<ProductImage>>().To<ProductImageRepository>();
        }
    }
}