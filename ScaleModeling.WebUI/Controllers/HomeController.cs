using System.Web.Mvc;
using System.Linq;

using ScaleModeling.Domain.Abstract;
using ScaleModeling.Domain.Entities;
using System;

namespace ScaleModeling.WebUI.Controllers
{
    public class HomeController : Controller
    {
        private IRepository<Article> eventRepository;

        public HomeController(IRepository<Article> eventRepositoryParam)
        {
            this.eventRepository = eventRepositoryParam;
        }

        public ActionResult Index()
        {
            return View( eventRepository.Get.ToList() );
        }
    }
}