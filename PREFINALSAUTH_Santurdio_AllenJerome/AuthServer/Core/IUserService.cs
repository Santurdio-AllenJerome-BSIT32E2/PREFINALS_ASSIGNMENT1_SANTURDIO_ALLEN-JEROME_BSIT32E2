namespace AuthServer.Core
{
    public interface IUserService
    {
        User GetUserByUsername(string username);
        bool RegisterUser(User user);
        // Add any other user management methods as needed
    }
}
