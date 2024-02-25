using FMRepository.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FMRepository.Concrete.User {
	public class UserRepository : IUserRepository {

		private readonly IGenericRepository<FMData.Entity.User> _genericRepository;

		public UserRepository(IGenericRepository<FMData.Entity.User> genericRepository) {
			_genericRepository = genericRepository;
		}

		public async Task<FMData.Entity.User> DeleteAsync(int id) {
			return await _genericRepository.DeleteAsync(id);
		}

		public async Task<IEnumerable<FMData.Entity.User>> GetAllAsync() {
			return await _genericRepository.GetAllAsync();
		}

		public async Task<FMData.Entity.User> GetByIdAsync(int id) {
			return await _genericRepository.GetByIdAsync(id);
		}

		public async Task<FMData.Entity.User> InsertAsync(FMData.Entity.User entity) {
			return await _genericRepository.InsertAsync(entity);
		}

		public async Task<FMData.Entity.User> UpdateAsync(FMData.Entity.User entity) {
			return await _genericRepository.UpdateAsync(entity);
		}
	}
}
