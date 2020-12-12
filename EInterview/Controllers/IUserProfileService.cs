namespace EInterview.Controllers
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