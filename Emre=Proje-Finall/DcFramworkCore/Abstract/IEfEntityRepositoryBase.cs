using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace DcFramworkCore.Abstract
{
	public interface IEfEntityRepositoryBase<TEntity> where TEntity : class
	{
		List<TEntity> GetList(Expression<Func<TEntity, bool>> fileter = null);

		void Add(TEntity entity);
		void Update(TEntity entity);
		void Delete(TEntity entity);
	}
}
