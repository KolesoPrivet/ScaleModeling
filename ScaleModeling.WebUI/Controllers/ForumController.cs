using System.Linq;
using System.Web.Mvc;

using ScaleModeling.Domain.Abstract;
using ScaleModeling.Domain.Entities;

namespace ScaleModeling.WebUI.Controllers
{
    public class ForumController : Controller
    {
        private IRepository<ForumTopic, int> forumRepository;

        public ForumController(IRepository<ForumTopic, int> forumRepositoryParam)
        {
            this.forumRepository = forumRepositoryParam;
        }

        public ActionResult Index()
        {
            return View(forumRepository.Get.ToList());
        }

        public ViewResult GetConcreteTopic(int id)
        {
            return View( forumRepository.Get.Where( ft => ft.Id == id ).ToList() );
        }
    }
}