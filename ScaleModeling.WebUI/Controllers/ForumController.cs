using System.Linq;
using System.Web.Mvc;
using System.Threading.Tasks;

using ScaleModeling.Domain.Abstract;
using ScaleModeling.Domain.Entities;

namespace ScaleModeling.WebUI.Controllers
{
    public class ForumController : Controller
    {
        private IRepository<ForumTopic> forumTopicRepository;

        public ForumController(IRepository<ForumTopic> forumTopicRepositoryParam)
        {
            this.forumTopicRepository = forumTopicRepositoryParam;
        }

        public ActionResult Index()
        {
            return View( forumTopicRepository.GetAll.ToList() );
        }

        public async Task<ViewResult> GetConcreteTopic(int id = 0)
        {
            if (id == 0)
            {
                return View( "Index", forumTopicRepository.GetAll.ToList() );
            }


            ForumTopic currentTopic = forumTopicRepository.GetAll.Where( ft => ft.Id == id ).AsEnumerable().First();

            currentTopic.Viewed += 1;


            await forumTopicRepository.Update( currentTopic );

            await forumTopicRepository.SaveChangesAsync();


            return View( currentTopic );
        }
    }
}