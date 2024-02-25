using FMData.Entity;
using FMRepository.Concrete.User;
using FMServices.UserService;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace FMApiProject.Controllers {
	[Route("api/[controller]")]
	[ApiController]
	public class UserController : ControllerBase {
		//private readonly IUserRepository _userRepository;
		private readonly IUserService _userService;

		public UserController(IUserService userService) {
			_userService = userService;
		}

		[HttpGet]
		public async Task<IEnumerable<User>> Get() {
			return await _userService.GetAllAsync();
		}
		[HttpGet("{id}")]
		public async Task<User> Get(int id) {
			return await _userService.GetByIdAsync(id);
		}
		[HttpPost]
		public async Task<User> Post([FromBody] User user) {
			return await _userService.InsertAsync(user);
		}
		[HttpPut]
		public async Task<User> Put([FromBody] User user) {
		return await _userService.UpdateAsync(user);
		}
		[HttpDelete("{id}")]
		public async Task<User> Delete(int id) {
			return await _userService.DeleteAsync(id);
		}
	}
}
