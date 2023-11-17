using Challenge1.API.Services;
using Microsoft.AspNetCore.Mvc;

namespace Challenge1.API.Controllers
{
	[ApiController]
	[Route("[controller]")]
	public class ProductsController : ControllerBase
	{
		private readonly IProductService _productService;

		public ProductsController(IProductService productService)
		{
			_productService = productService;
		}

		[HttpGet]
		[Route("list")]
		public IActionResult GetAll()
		{
			return Ok(_productService.GetAllProducts());
		}

		[HttpGet]
		[Route("{id}")]
		public IActionResult Get(int id)
		{
			var products = _productService.GetAllProducts();

			var product = products.Where(x => x.Id==id);

			if(product == null || !product.Any()) 
				return NotFound();

			return Ok(product.FirstOrDefault());
		}
	}
}
