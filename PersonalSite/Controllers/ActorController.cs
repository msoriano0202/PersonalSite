using Microsoft.AspNetCore.Mvc;

namespace PersonalSite.Controllers
{
    public class ActorController : Controller
    {
        private readonly ILogger<ActorController> _logger;

        public ActorController(ILogger<ActorController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            return View();
        }
    }
}
