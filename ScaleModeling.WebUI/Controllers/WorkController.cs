using System.Linq;
using System.Web.Mvc;
using System.Threading.Tasks;

using ScaleModeling.Domain.Abstract;
using ScaleModeling.Domain.Entities;

namespace ScaleModeling.WebUI.Controllers
{
    public class WorkController : Controller
    {
        private IRepository<Work, int> workRepository;

        public WorkController(IRepository<Work, int> workRepositoryParam)
        {
            this.workRepository = workRepositoryParam;
        }

        public ActionResult Index()
        {
            return View( workRepository.Get.ToList() );
        }

        public async Task<ViewResult> GetConcreteWork(int id = 0)
        {
            if (id == 0)
            {
                return View( "Index", workRepository.Get.ToList() );
            }

            Work currentWork = workRepository.Get.Where( w => w.Id == id ).AsEnumerable().First();

            currentWork.Viewed += 1;

            await Task.Factory.StartNew( () => workRepository.SaveChanges() );

            return View( currentWork );
        }
    }
}