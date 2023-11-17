using Challenge1.API.Models;

namespace Challenge1.API.Services
{
	public interface IProductService
	{
		List<ProductModel> GetAllProducts();
	}

	public class ProductService : IProductService
	{
		public List<ProductModel> GetAllProducts()
		{
			return new List<ProductModel> {
				new ProductModel
				{
					Id = 1,
					Name = "Piano"
				},
				new ProductModel
				{
					Id = 2,
					Name = "Guitar"
				},
				new ProductModel
				{
					Id = 3,
					Name = "Violin"
				},
				new ProductModel
				{
					Id = 4,
					Name = "Drums"
				},
				new ProductModel
				{
					Id = 5,
					Name = "Bass"
				}
			};
		}
	}
}
