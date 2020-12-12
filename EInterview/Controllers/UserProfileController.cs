using EInterview.Dtos;
using EInterview.Services;
using Microsoft.AspNetCore.Mvc;

namespace EInterview.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class UserProfileController : ControllerBase
    {
        private readonly IUserProfileService userProfileService;

        public UserProfileController(IUserProfileService userProfileService)
        {
            this.userProfileService = userProfileService;
        }

        [HttpPost]
        public IActionResult Post(UserProfileRequest request)
        {
            var userProfile = userProfileService.GetProfile(request.UserId);
            if (userProfile != null) return Ok(userProfile);
            else return BadRequest();
        }

    }
}
