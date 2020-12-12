using EInterview.Services;
using Microsoft.AspNetCore.Mvc;
using System.Linq;

namespace EInterview.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class LoginController : ControllerBase
    {
        private readonly IAuthService authService;

        public LoginController(IAuthService authService)
        {
            this.authService = authService;
        }

        [HttpPost]
        public IActionResult Login(LoginRequest request)
            => Ok(authService.Authenticate(request.User, request.Password));

    }
}
