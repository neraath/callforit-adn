using System.Web.Mvc;
using callforit_adn.Models;

namespace callforit_adn.Controllers
{
    public class HomeController : Controller
    {
        private IEventRepository eventRepository;

        public HomeController() : this(new EventRepository(new EventContext()))
        {
        }

        public HomeController(IEventRepository eventRepo)
        {
            eventRepository = eventRepo;
        }

        //
        // GET: /Home/
        public ActionResult Index()
        {
            ViewBag.UpcomingConferences = eventRepository.Events;
            return View();
        }

    }
}
