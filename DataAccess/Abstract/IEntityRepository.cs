using Entities.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Abstract
{
	//generic constraint
	//class: refers to referance type
	//IEntitiy: T can be IEntity or classes that is implemented by IEntity
	//new: T can not be interface but can be class 
	public interface IEntityRepository<T> where T : class,IEntity,new()
	{
		List<T> GetAll(Expression<Func<T, bool>> filter = null);
		T Get(Expression<Func<T, bool>> filter);
		void Add(T entity);
		void Delete(T entity);
		void Update(T entity);
	}
}
