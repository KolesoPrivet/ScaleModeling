using System.Linq;
using System.Web.Mvc;

using ScaleModeling.Domain.Abstract;
using ScaleModeling.Domain.Entities;

namespace ScaleModeling.WebUI.Controllers
{
    public class ArticleController : Controller
    {
        private IRepository<Article, int> articleRepository;

        public ArticleController(IRepository<Article, int> articleRepositoryParam)
        {
            this.articleRepository = articleRepositoryParam;
        }

        public ViewResult Index()
        {
            return View(articleRepository.Get.ToList());
        }

        public ViewResult GetConcreteArticle(int id)
        {
            return View( articleRepository.Get.Where( a => a.Id == id ).ToList() );
        }

    }
}