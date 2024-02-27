using DcFramworkCore.Abstract;
using Entity.Concreate;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccesLeyaer.Abstract
{
	public interface IProductDal : IEfEntityRepositoryBase<Product>
	{

		List<Product> GetAllProducts();

		void CreateOneProduct(Product product);
		void DeleteOnePRoduct(Product product);
		void UpdateOneProduct(Product product);
	}
}
