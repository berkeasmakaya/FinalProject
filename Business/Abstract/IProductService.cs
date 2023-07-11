using Entities.Concrete;
using Entities.DTO_s;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Abstract
{
	public interface IProductService
	{
		List<Product> GetAll();
		List<Product> GetAllByCategoryId(int categoryId);
		List<Product> GetByUnitPrice(decimal min, decimal max);
		List<ProductDetailDto> GetProductDetails();
	}
}
