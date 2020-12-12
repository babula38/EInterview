using EInterview.Dtos;
using EInterview.Services;
using Microsoft.AspNetCore.Mvc;
using System.Linq;

namespace EInterview.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class UserController : ControllerBase
    {
        private readonly IAuthService authService;

        public UserController(IAuthService authService)
        {
            this.authService = authService;
        }

        [HttpPost]
        public IActionResult Login(LoginRequest request)
            => Ok(authService.Authenticate(request.User, request.Password));

    }
}
