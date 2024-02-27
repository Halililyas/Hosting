using Business.Abstract;
using DataAccesLeyaer.Abstract;
using DataAccesLeyaer.Concreate;
using DcFramworkCore.DbContext;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Concerete
{
	public class RepositoryManager:IRepositoryManager
	{
		protected readonly Context _context;
		protected readonly Lazy<IProductDal> _productDal;
		

		public RepositoryManager(Context context)
		{
			_context = context;
			_productDal = new Lazy<IProductDal>(() => new EfPRoductDal(_context));
		}

		public IProductDal IProductDal => _productDal.Value;

	

		public void save()
		{
			_context.SaveChanges();
		}
	}
}
