using ASPMVC.Models;
using Microsoft.AspNetCore.Mvc;

namespace ASPMVC.Controllers
{
	public class AccountController : Controller
	{
		private readonly ILogger<AccountController> _logger;

        public AccountController(ILogger<AccountController> logger)
        {
            _logger = logger;
        }
        public IActionResult Index()
		{
			return View();
		}

		public IActionResult Login()
		{
			return View();
		}

		[HttpPost]
		public IActionResult Login(LoginFormModels loginForm)
		{
			//LoginFormModels.ValidateLoginForm(loginForm, ModelState);
			if (!ModelState.IsValid)
			{
				ViewData["errors"] = "Des erreurs se sont produites";
			return View();

			} else
			{
				return RedirectToAction("Index", "Home");
			}
		}
		//public IActionResult Login(IFormCollection formCollection) {

		//	formCollection.ToList().ForEach(x =>
		//	{
		//		_logger.LogInformation($"{x.Key} : {x.Value}");

		//	});
		//	return View();
		//}

		public IActionResult Register()
		{
			return View();
		}
	}
}
