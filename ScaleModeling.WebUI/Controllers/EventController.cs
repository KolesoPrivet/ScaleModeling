using System.Linq;
using System.Web.Mvc;
using System.Threading.Tasks;

using ScaleModeling.Domain.Abstract;
using ScaleModeling.Domain.Entities;

namespace ScaleModeling.WebUI.Controllers
{
    public class EventController : Controller
    {
        private IRepository<Event> eventRepository;

        public EventController(IRepository<Event> eventRepositoryParam)
        {
            this.eventRepository = eventRepositoryParam;
        }

        public ViewResult Index()
        {
            return View( eventRepository.Get.ToList() );
        }

        public async Task<ViewResult> GetConcreteEvent(int id = 0)
        {
            if (id == 0)
            {
                return View( "Index", eventRepository.Get.ToList() );
            }

            Event currentEvent = eventRepository.Get.Where( e => e.Id == id ).AsEnumerable().First();

            currentEvent.Viewed += 1;

            await Task.Factory.StartNew( () => eventRepository.SaveChanges() );

            return View( currentEvent );
        }
    }
}