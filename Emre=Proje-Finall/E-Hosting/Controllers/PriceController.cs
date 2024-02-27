using Business.Abstract;
using Microsoft.AspNetCore.Mvc;

namespace E_Hosting.Controllers
{
	public class PriceController : Controller
	{
		private readonly IService _service;
        public PriceController(IService service)
        {
			_service = service;
        }
        public IActionResult Index()
		{
			var urun = _service.ProductService.GetAll();

			return View(urun);
		}
	}
}
