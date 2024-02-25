using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FMServices.Abstract {
	public interface IGenericService<T> where T:class {
		Task<IEnumerable<T>> GetAllAsync();
		Task<T> GetByIdAsync(int id);
		Task<T> InsertAsync(T entity);
		Task<T> UpdateAsync(T entity);
		Task<T> DeleteAsync(int id);
	}
}
