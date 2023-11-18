using Microsoft.AspNetCore.Mvc;

namespace Challenge1.API.Controllers
{
	public class HomeController : Controller
	{
		[HttpGet]
		[Route("/")]
		public IActionResult Index()
		{
			return Ok("XLENT - Challenge 1 API");
		}
	}
}
