using PREFINALS_AUTH_Santurdio_Allen_Jerome.Models;

namespace PREFINALS_AUTH_Santurdio_Allen_Jerome.Services
{
    public interface IAuthService
    {
        string GenerateJwtToken(User user);
        bool ValidateJwtToken(string token);
    }
}
