using System.Linq;
using System.Web.Mvc;

using ScaleModeling.Domain.Abstract;
using ScaleModeling.Domain.Entities;

namespace ScaleModeling.WebUI.Controllers
{
    public class WorkController : Controller
    {
        private IRepository<Work> workRepository;

        public WorkController(IRepository<Work> workRepositoryParam)
        {
            this.workRepository = workRepositoryParam;
        }

        public ActionResult Index()
        {
            return View( workRepository.Get.ToList() );
        }

        public ViewResult GetConcreteWork(int id)
        {
            return View( workRepository.Get.Where( w => w.Id == id ).ToList() );
        }
    }
}