using Business.Abstract;
using E_Hosting.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace E_Hosting.Controllers
{
	public class HomeController : Controller
	{
		private readonly IService _service;

        public HomeController(IService service)
        {
			_service = service;
        }

        public IActionResult Index()
		{
			return View();
		}

		
		



	}
}