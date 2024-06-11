using PREFINALS_AUTH_Santurdio_Allen_Jerome.Models;

namespace PREFINALS_AUTH_Santurdio_Allen_Jerome.Services
{
    public class InMemoryUserService : IUserService
    {
        private readonly List<User> _users = new List<User>();

        public User GetUserByUsername(string username)
        {
            return _users.FirstOrDefault(u => u.Username == username);
        }

        public void CreateUser(User user)
        {
            _users.Add(user);
        }

        public void UpdateUser(User user)
        {
            var existingUser = GetUserByUsername(user.Username);
            if (existingUser != null)
            {
                existingUser.Name = user.Name;
                existingUser.Section = user.Section;
                existingUser.Course = user.Course;
            }
        }
    }
}
