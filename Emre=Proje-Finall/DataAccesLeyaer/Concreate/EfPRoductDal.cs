using DataAccesLeyaer.Abstract;
using DcFramworkCore.DataAccesLeyar.EntityFramework;
using DcFramworkCore.DbContext;
using Entity.Concreate;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccesLeyaer.Concreate
{
	public class EfPRoductDal : EfEntityRepository<Product>, IProductDal
	{
		public EfPRoductDal(Context context) : base(context)
		{
		}

		public void CreateOneProduct(Product product)
		{
			Add(product);
		}

		public void DeleteOnePRoduct(Product product)
		{
			Delete(product);
		}

		public List<Product> GetAllProducts()
		{
			return GetList();
		}




		public void UpdateOneProduct(Product product)
		{
			Update(product);
		}
	}
}
