using DcFramworkCore.Abstract;
using DcFramworkCore.DbContext;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace DcFramworkCore.DataAccesLeyar.EntityFramework
{
	public class EfEntityRepository<TEntity>:IEfEntityRepositoryBase<TEntity> where TEntity :class
	{
		protected readonly Context _context;
        public EfEntityRepository(Context context)
        {
            _context = context;
        }

		public void Add(TEntity entity)
		{
			_context.Set<TEntity>().Add(entity);
		}

		public void Delete(TEntity entity)
		{
			_context.Set<TEntity>().Remove(entity);
		}

		public List<TEntity> GetList(Expression<Func<TEntity, bool>> fileter = null)
		{
			return fileter == null
				? _context.Set<TEntity>().ToList()
				: _context.Set<TEntity>().Where(fileter).ToList();
		}

		public void Update(TEntity entity)
		{
			_context.Set<TEntity>().Update(entity);
		}
	}
}
