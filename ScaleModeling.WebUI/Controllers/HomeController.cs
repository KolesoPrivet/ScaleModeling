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

        private IRepository<Product> productRepository;

        private IRepository<Work> workRepository;



        public HomeController(IRepository<Article> articleRepositoryParam, IRepository<Event> eventRepositoryParam,
                              IRepository<ForumTopic> topicRepositoryParam, IRepository<Product> productRepositoryParam,
                              IRepository<Work> workRepositoryParam)
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
                Articles = articleRepository.GetAll.OrderByDescending( a => a.CreationDate ).Take( 3 ).ToList(),
                Events = eventRepository.GetAll.OrderByDescending( e => e.CreationDate ).Take( 3 ).ToList(),
                Topics = topicRepository.GetAll.OrderByDescending(t => t.CreationDate).Take(3).ToList(),
                Products = productRepository.GetAll.OrderByDescending(p => p.AdditionDate).Take(6).ToList(),
                Works = workRepository.GetAll.OrderByDescending(w => w.CreationDate).Take(6).ToList()
            };



            return View( homeViewModel );
        }
    }
}