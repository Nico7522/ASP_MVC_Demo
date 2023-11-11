using Microsoft.AspNetCore.Mvc;

namespace ASPMVC.Controllers
{
    public class DemoController : Controller
    {
        private readonly ILogger<DemoController> _logger;

        public DemoController(ILogger<DemoController> logger)
        {
            _logger = logger;

        }
        public IActionResult Index()
        {
            ViewData["name"] = "Nicolas";
            return View();
        }
    }
}
