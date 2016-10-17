using System.Linq;
using System.Web.Mvc;
using System.Threading.Tasks;

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
            return View( workRepository.GetAll.ToList() );
        }

        public async Task<ViewResult> GetConcreteWork(int id = 0)
        {
            if (id == 0)
            {
                return View( "Index", workRepository.GetAll.ToList() );
            }


            Work currentWork = workRepository.GetAll.Where( w => w.Id == id ).AsEnumerable().First();

            currentWork.Viewed += 1;


            await workRepository.Update( currentWork );

            await workRepository.SaveChangesAsync();


            return View( currentWork );
        }
    }
}