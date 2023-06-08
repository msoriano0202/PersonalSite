using Microsoft.AspNetCore.Mvc;

namespace PersonalSite.Controllers
{
    public class SystemsEngineerController : Controller
    {
        private readonly ILogger<SystemsEngineerController> _logger;

        public SystemsEngineerController(ILogger<SystemsEngineerController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            return View();
        }
    }
}
