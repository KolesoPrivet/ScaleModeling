using System.Linq;
using System.Web.Mvc;

using ScaleModeling.Domain.Abstract;
using ScaleModeling.Domain.Entities;

namespace ScaleModeling.WebUI.Controllers
{
    public class EventController : Controller
    {
        private IRepository<Event, int> eventRepository;

        public EventController(IRepository<Event, int> eventRepositoryParam)
        {
            this.eventRepository = eventRepositoryParam;
        }

        public ViewResult Index()
        {
            return View( eventRepository.Get.ToList() );
        }

        public ViewResult GetConcreteEvent(int id)
        {
            return View( eventRepository.Get.Where( ev => ev.Id == id ).ToList() );
        }
    }
}