using System;
using System.Collections.Generic;
using System.Web;
using Microsoft.AspNet.Identity.Owin;
using System.Linq;
using System.Web.Mvc;
using System.Threading.Tasks;

using ScaleModeling.Domain.Abstract;
using ScaleModeling.Domain.Entities;


namespace ScaleModeling.WebUI.Controllers
{
    public class ArticleController : Controller
    {
        private IRepository<Article> articleRepository;
        private IRepository<ArticleComment> articleCommentsRepository;

        private ApplicationUserManager _userManager;

        public ApplicationUserManager UserManager
        {
            get
            {
                return _userManager ?? HttpContext.GetOwinContext().GetUserManager<ApplicationUserManager>();
            }

            private set
            {
                _userManager = value;
            }
        }

        public ArticleController(IRepository<Article> articleRepositoryParam, IRepository<ArticleComment> articleCommentsRepositoryParam)
        {
            this.articleRepository = articleRepositoryParam;

            this.articleCommentsRepository = articleCommentsRepositoryParam;
        }

        public ViewResult Index()
        {
            return View( articleRepository.GetAll.ToList() );
        }

        public async Task<ViewResult> GetConcreteArticle(int id = 0)
        {
            if (id == 0)
            {
                return View( "Index", articleRepository.GetAll.ToList() );
            }


            Article currentArticle = articleRepository.GetAll.Where( a => a.Id == id ).AsEnumerable().First();

            currentArticle.Viewed += 1;


            await articleRepository.Update( currentArticle );

            await articleRepository.SaveChangesAsync();


            return View( currentArticle );
        }

        public PartialViewResult CommentsOpen(int id = 0)
        {
            if (id == 0)
            {
                throw new Exception( "Article id = 0, article is undefined!" );
            }


            List<ArticleComment> articleComments = articleCommentsRepository.GetAll.Where(ac => ac.ArticleId == id).ToList();


            return PartialView( articleComments );
        }

        //public PartialViewResult CreateComment(int id = 0)
        //{
        //    if(id == 0)
        //    {
        //        throw new Exception( "Article id = 0, article is undefined!" );
        //    }

            
        //}

        public async Task<int> AddLike(int id = 0)
        {
            if (id == 0)
            {
                throw new Exception( "Article id = 0, article is undefined!" );
            }


            Article currentArticle = await articleRepository.GetEntityById(id);

            User userLiked = await UserManager.FindByNameAsync( User.Identity.Name );

            ArticleLiked currentLike = new ArticleLiked { ArticleId = currentArticle.Id, UserId = userLiked.Id, LikedDate = DateTime.Now };


            if (currentArticle.Likes.Any(a => a.ArticleId == currentLike.ArticleId && a.UserId == currentLike.UserId))
            {
                currentArticle.Likes.RemoveAll( a => a.ArticleId == currentLike.ArticleId && a.UserId == currentLike.UserId );
                await articleRepository.SaveChangesAsync();
            }

            else
            {
                currentArticle.Likes.Add( currentLike );
                await articleRepository.SaveChangesAsync();
            }


            return currentArticle.Likes.Count();
        }

        //public async Task<int> AddComment(int id = 0)
        //{
        //    if (id == 0)
        //    {
        //        throw new Exception( "Article id = 0, article is undefined!" );
        //    }

        //    Article currentArticle = articleRepository.Get.Where( a => a.Id == id ).AsEnumerable().First();

        //    User userCommented = await UserManager.FindByNameAsync( User.Identity.Name );

        //    ArticleComment currentComment = new ArticleComment { ArticleId = currentArticle.Id, AuthorId = userCommented.Id, CreationDate = DateTime.Now, Text}
        //}
    }
}