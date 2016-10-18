using System;
using System.Collections.Generic;
using System.Web;
using Microsoft.AspNet.Identity.Owin;
using Microsoft.AspNet.Identity;
using System.Linq;
using System.Web.Mvc;
using System.Threading.Tasks;

using ScaleModeling.Domain.Abstract;
using ScaleModeling.Domain.Entities;
using ScaleModeling.WebUI.Models;

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


            List<ArticleComment> articleComments = articleCommentsRepository.GetAll.Where( ac => ac.ArticleId == id ).ToList();


            return PartialView( articleComments );
        }

        public PartialViewResult CommentField(int id = 0)
        {
            if (User.Identity.IsAuthenticated)
            {
                User currentUser = UserManager.FindById( User.Identity.GetUserId<int>() );

                return PartialView( new CommenterInfoViewModel { UserName = User.Identity.Name,
                                                                 CommentedEntityId = id,
                                                                 Rating = currentUser.UserDetail.Rating,
                                                                 ArticleCount = currentUser.Articles.Count,
                                                                 WorksCount = currentUser.Works.Count, } );
            }

            return PartialView( "NotAuthenticated" );
        }



        [HttpPost]
        public async Task<ViewResult> CreateComment(CommentViewModel comment, int id)
        {
            await articleCommentsRepository.Create( new ArticleComment { ArticleId = id, AuthorId = User.Identity.GetUserId<int>(), CreationDate = DateTime.Now, Text = comment.CommentText } );

            await articleCommentsRepository.SaveChangesAsync();

            return View( "GetConcreteArticle", articleRepository.GetAll.Where( a => a.Id == id ).AsEnumerable().First() );
        }




        public async Task<int> AddLike(int id = 0)
        {
            if (id == 0)
            {
                throw new Exception( "Article id = 0, article is undefined!" );
            }


            Article currentArticle = await articleRepository.GetEntityById( id );

            int userLikedId = User.Identity.GetUserId<int>();

            if (userLikedId != default( int ))
            {
                ArticleLiked currentLike = new ArticleLiked { ArticleId = currentArticle.Id, UserId = userLikedId, LikedDate = DateTime.Now };


                if (currentArticle.Likes.Any( a => a.ArticleId == currentLike.ArticleId && a.UserId == currentLike.UserId ))
                {
                    currentArticle.Likes.RemoveAll( a => a.ArticleId == currentLike.ArticleId && a.UserId == currentLike.UserId );
                    await articleRepository.SaveChangesAsync();
                }

                else
                {
                    currentArticle.Likes.Add( currentLike );
                    await articleRepository.SaveChangesAsync();
                }

            }

            return currentArticle.Likes.Count();
        }
    }
}