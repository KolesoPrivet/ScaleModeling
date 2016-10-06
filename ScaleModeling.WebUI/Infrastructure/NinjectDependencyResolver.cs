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
            kernel.Bind<IRepository<User>>().To<UserRepository>();

            kernel.Bind<IRepository<UserDetail>>().To<UserDetailRepository>();

            kernel.Bind<IRepository<UserRole>>().To<UserRoleRepository>();


            //Forum
            kernel.Bind<IRepository<ForumCategory>>().To<ForumCategoryRepository>();

            kernel.Bind<IRepository<ForumTopic>>().To<ForumTopicRepository>();

            kernel.Bind<IRepository<ForumImage>>().To<ForumImageRepository>();

            kernel.Bind<IRepository<ForumComment>>().To<ForumCommentRepository>();
        }
    }
}