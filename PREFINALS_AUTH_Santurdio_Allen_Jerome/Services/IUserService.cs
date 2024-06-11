using PREFINALS_AUTH_Santurdio_Allen_Jerome.Models;

namespace PREFINALS_AUTH_Santurdio_Allen_Jerome.Services
{
    public interface IUserService
    {
        User GetUserByUsername(string username);
        void CreateUser(User user);
        void UpdateUser(User user);
    }
}
