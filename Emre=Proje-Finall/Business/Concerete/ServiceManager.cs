using Business.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Concerete
{
	public class ServiceManager : IService
	{
		private readonly Lazy<IProductService> _productService;

        public ServiceManager(IRepositoryManager manager)
        {
            _productService = new Lazy<IProductService>(() => new ProductManager(manager));
        }
        public IProductService ProductService => _productService.Value;
	}
}
