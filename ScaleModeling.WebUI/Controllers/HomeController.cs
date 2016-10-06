using System.Web.Mvc;
using System.Linq;

using ScaleModeling.Domain.Abstract;
using ScaleModeling.Domain.Entities;
using ScaleModeling.WebUI.Models;

namespace ScaleModeling.WebUI.Controllers
{
    public class HomeController : Controller
    {
        private IRepository<Article> articleRepository;
        private IRepository<Event> eventRepository;
        private IRepository<ForumTopic> topicRepository;

        public HomeController(IRepository<Article> articleRepositoryParam, IRepository<Event> eventRepositoryParam,
                              IRepository<ForumTopic> topicRepositoryParam)
        {
            this.articleRepository = articleRepositoryParam;
            this.eventRepository = eventRepositoryParam;
            this.topicRepository = topicRepositoryParam;
        }

        public ActionResult Index()
        {
            HomeViewModel homeViewModel = new HomeViewModel
            {
                Articles = articleRepository.Get.OrderByDescending( a => a.CreationDate ).Take( 3 ).ToList(),
                Events = eventRepository.Get.OrderByDescending( e => e.CreationDate ).Take( 3 ).ToList(),
                Topics = topicRepository.Get.OrderByDescending(t => t.CreationDate).Take(3).ToList()
            };

            return View( homeViewModel );
        }
    }
}