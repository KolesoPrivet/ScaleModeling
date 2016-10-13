using System.Linq;
using System.Web.Mvc;
using System.Threading.Tasks;

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
            return View( forumRepository.Get.ToList() );
        }

        public async Task<ViewResult> GetConcreteTopic(int id = 0)
        {
            if (id == 0)
            {
                return View( "Index", forumRepository.Get.ToList() );
            }

            ForumTopic currentTopic = forumRepository.Get.Where( ft => ft.Id == id ).AsEnumerable().First();

            currentTopic.Viewed += 1;

            await Task.Factory.StartNew( () => forumRepository.SaveChanges() );

            return View( currentTopic );
        }
    }
}