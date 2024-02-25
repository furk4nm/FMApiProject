using FMData.Context;
using FMData.Entity;
using Microsoft.EntityFrameworkCore;

namespace FMRepository.Abstract {
	public class GenericRepository<T> : IGenericRepository<T> where T : BaseEntity {
		
		private readonly FmContext _context;
		private readonly DbSet<T> _dbset;
		public GenericRepository(FmContext context) {
			_context = context;
			_dbset = _context.Set<T>();
		}

		public async Task<IEnumerable<T>> GetAllAsync() {
			var allEntity = await _dbset.ToListAsync();
			return allEntity;
		}
		public async Task<T> GetByIdAsync(int id) {
		var entity = await _dbset.FindAsync(id);
			return entity;
		}
		public async Task<T> InsertAsync(T entity) {

			await _dbset.AddAsync(entity);
			await _context.SaveChangesAsync();
			return entity;
		}

		public async Task<T> UpdateAsync(T entity) {

			 _dbset.Update(entity);
			await _context.SaveChangesAsync();
			return entity;
		}
		public async Task<T> DeleteAsync(int id) {
		var entity = await _dbset.FindAsync(id);
			_dbset.Remove(entity);
			await _context.SaveChangesAsync();
			return entity;
		}

	}
}
