using Microsoft.AspNetCore.Mvc;

namespace Challenge1.API.Controllers
{
	public class HomeController : Controller
	{
		[HttpGet]
		[Route("/")]
		[ApiExplorerSettings(IgnoreApi = true)]
		public IActionResult Index()
		{
			return Ok("XLENT - Challenge 1 API");
		}
	}
}
