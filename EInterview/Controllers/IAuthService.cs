namespace EInterview.Controllers
{
    public interface IAuthService
    {
        bool Authenticate(string user, string password);
    }

    public class AuthService : IAuthService
    {
        public bool Authenticate(string user, string password) => user == "user" & password == "password";
    }
}