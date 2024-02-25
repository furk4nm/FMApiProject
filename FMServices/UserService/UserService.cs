using FMData.Entity;
using FMRepository.Concrete.User;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FMServices.UserService {
	public class UserService : IUserService {
		private readonly IUserRepository _userRepository;

		public UserService(IUserRepository userRepository) {
			_userRepository = userRepository;
		}
		public async Task<User> DeleteAsync(int id) {
		return await _userRepository.DeleteAsync(id);

		}

		public async Task<IEnumerable<User>> GetAllAsync() {
		return await _userRepository.GetAllAsync();
		}

		public async Task<User> GetByIdAsync(int id) {
			return await _userRepository.GetByIdAsync(id);
		}

		public async Task<User> InsertAsync(User entity) {
			return await _userRepository.InsertAsync(entity);
		}

		public async Task<User> UpdateAsync(User entity) {
			return await _userRepository.UpdateAsync(entity);
		}
	}
}
