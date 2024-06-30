using AuthServer.Core;

namespace AuthServer.Services
{
    public class UserService : IUserService
    {
        private readonly List<User> _users = new List<User>();

        public User GetUserByUsername(string username)
        {
            return _users.FirstOrDefault(u => u.Username == username);
        }

        public bool RegisterUser(User user)
        {
            if (_users.Any(u => u.Username == user.Username))
                return false;

            _users.Add(user);
            return true;
        }
    }
}
