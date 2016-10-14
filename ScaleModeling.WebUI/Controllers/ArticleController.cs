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

        public ArticleController(IRepository<Article> articleRepositoryParam)
        {
            this.articleRepository = articleRepositoryParam;
        }

        public ViewResult Index()
        {
            return View( articleRepository.Get.ToList() );
        }

        public async Task<ViewResult> GetConcreteArticle(int id = 0)
        {
            if (id == 0)
            {
                return View( "Index", articleRepository.Get.ToList() );
            }

            Article currentArticle = articleRepository.Get.Where( a => a.Id == id ).AsEnumerable().First();

            currentArticle.Viewed += 1;

            await articleRepository.SaveChanges();

            return View( currentArticle );
        }
    }
}