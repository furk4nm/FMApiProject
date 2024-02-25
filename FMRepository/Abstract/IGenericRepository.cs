using FMData.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FMRepository.Abstract {
	public interface IGenericRepository<T> where T:BaseEntity{
		Task<IEnumerable<T>> GetAllAsync();
		Task<T> GetByIdAsync(int id);
		Task<T>InsertAsync(T entity);
		Task<T> UpdateAsync(T entity);
        Task<T> DeleteAsync(int id);
	}
}
