using Microsoft.AspNetCore.Mvc;

namespace FirstAspNetCoreServer.Controllers
{
	public class AppController : Controller
	{
		public IActionResult Index()
		{
			return View();
		}

		public IActionResult About()
		{
			return View();
		}
	}
}
