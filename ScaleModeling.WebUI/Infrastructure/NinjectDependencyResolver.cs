using Ninject;
using System;
using System.Collections.Generic;
using System.Web.Mvc;

using ScaleModeling.Domain.Abstract;
using ScaleModeling.Domain.Entities;
using ScaleModeling.Domain.Concrete;

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
            kernel.Bind<IRepository<Event, int>>().To<EventRepository>();

            kernel.Bind<IRepository<EventComment, int>>().To<EventCommentRepository>();

            kernel.Bind<IRepository<EventImage, int>>().To<EventImageRepository>();


            //Articles
            kernel.Bind<IRepository<Article, int>>().To<ArticleRepository>();

            kernel.Bind<IRepository<ArticleComment, int>>().To<ArticleCommentRepository>();

            kernel.Bind<IRepository<ArticleImage, int>>().To<ArticleImageRepository>();


            //Works
            kernel.Bind<IRepository<Work, int>>().To<WorkRepository>();

            kernel.Bind<IRepository<WorkComment, int>>().To<WorkCommentRepository>();

            kernel.Bind<IRepository<WorkImage, int>>().To<WorkImageRepository>();


            //Videos
            kernel.Bind<IRepository<VideoContent, int>>().To<VideoContentRepository>();

            kernel.Bind<IRepository<VideoComment, int>>().To<VideoCommentRepository>();


            //Users
            kernel.Bind<IRepository<UserDetail, string>>().To<UserDetailRepository>();

            kernel.Bind<IRepository<UserNotification, int>>().To<UserNotificationRepository>();

            kernel.Bind<IRepository<WishList, int>>().To<WishListRepository>();


            //Forum
            kernel.Bind<IRepository<ForumCategory, int>>().To<ForumCategoryRepository>();

            kernel.Bind<IRepository<ForumTopic, int>>().To<ForumTopicRepository>();

            kernel.Bind<IRepository<ForumImage, int>>().To<ForumImageRepository>();

            kernel.Bind<IRepository<ForumComment, int>>().To<ForumCommentRepository>();


            //Products
            kernel.Bind<IRepository<Product, int>>().To<ProductRepository>();

            kernel.Bind<IRepository<ProductCategory, int>>().To<ProductCategoryRepository>();

            kernel.Bind<IRepository<ProductComment, int>>().To<ProductCommentRepository>();

            kernel.Bind<IRepository<ProductImage, int>>().To<ProductImageRepository>();
        }
    }
}