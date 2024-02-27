using Business.Abstract;
using Entity.Concreate;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Concerete
{
	public class ProductManager : IProductService
	{

		private readonly IRepositoryManager _repositoryManager;

        public ProductManager(IRepositoryManager repositoryManager)
        {
			_repositoryManager = repositoryManager;
        }
		public void Add(Product product) {
			_repositoryManager.IProductDal.Add(product);
			_repositoryManager.save();
		}


		public void Delete(Product product)
		{
			_repositoryManager.IProductDal.Delete(product);
			_repositoryManager.save();
		}

		public List<Product> GetAll()
		{
			return _repositoryManager.IProductDal.GetList();
		}

		public void Update(Product product)
		{
			_repositoryManager.IProductDal.Update(product);
			_repositoryManager.save();
		}
	}
}
