using System.Web.Mvc;
using System.Linq;

using ScaleModeling.Domain.Abstract;
using ScaleModeling.Domain.Entities;
using ScaleModeling.WebUI.Models;

namespace ScaleModeling.WebUI.Controllers
{
    public class HomeController : Controller
    {
        private IRepository<Article, int> articleRepository;
        private IRepository<Event, int> eventRepository;
        private IRepository<ForumTopic, int> topicRepository;
        private IRepository<Product, int> productRepository;
        private IRepository<Work, int> workRepository;

        public HomeController(IRepository<Article, int> articleRepositoryParam, IRepository<Event, int> eventRepositoryParam,
                              IRepository<ForumTopic, int> topicRepositoryParam, IRepository<Product, int> productRepositoryParam,
                              IRepository<Work, int> workRepositoryParam)
        {
            this.articleRepository = articleRepositoryParam;
            this.eventRepository = eventRepositoryParam;
            this.topicRepository = topicRepositoryParam;
            this.productRepository = productRepositoryParam;
            this.workRepository = workRepositoryParam;
        }

        public ActionResult Index()
        {
            HomeViewModel homeViewModel = new HomeViewModel
            {
                Articles = articleRepository.Get.OrderByDescending( a => a.CreationDate ).Take( 3 ).ToList(),
                Events = eventRepository.Get.OrderByDescending( e => e.CreationDate ).Take( 3 ).ToList(),
                Topics = topicRepository.Get.OrderByDescending(t => t.CreationDate).Take(3).ToList(),
                Products = productRepository.Get.OrderByDescending(p => p.AdditionDate).Take(6).ToList(),
                Works = workRepository.Get.OrderByDescending(w => w.CreationDate).Take(6).ToList()
            };

            return View( homeViewModel );
        }
    }
}