using Microsoft.AspNetCore.Mvc;

namespace E_Hosting.Controllers
{
	public class AboutController : Controller
	{
		public IActionResult Index()
		{
			return View();
		}
	}
}
