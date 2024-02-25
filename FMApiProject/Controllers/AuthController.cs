using FMApiProject.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace FMApiProject.Controllers {
	[Route("api/[controller]")]
	[ApiController]
	public class AuthController : ControllerBase {

		[HttpPost]
		public ResponseModel login(LoginModel loginmodel) {

			if(loginmodel.Name == "fmungan" && loginmodel.Password=="123") {
				return new ResponseModel() {
					Message="Login Başarılı",
					Code="200",
					Data=null
				};
			}

				return new ResponseModel() {
					Message = "Login Başarısız",
					Code = "401",
					Data = null
				};
		}

	}
}
