using EInterview.Controllers;
using EInterview.Domain.Entities;
using EInterview.Infra;

namespace EInterview.Services
{
    public interface IUserProfileService
    {
        UserProfile GetProfile(int userId);
    }

    public class UserProfileService : IUserProfileService
    {
        public UserProfile GetProfile(int userId)
        {
            return DbStorage.GetProfile(userId);
        }
    }
}