namespace AuthServer.Core
{
    public interface IAuthService
    {
        string GenerateJwtToken(User user);
        // Add any other authentication-related methods as needed
    }
}
