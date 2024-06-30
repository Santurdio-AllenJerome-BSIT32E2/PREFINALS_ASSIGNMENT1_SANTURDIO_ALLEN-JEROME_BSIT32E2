using AuthServer.Core;
using Microsoft.IdentityModel.Tokens;
using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;
using System.Text;

namespace AuthServer.Services
{
    public class AuthService : IAuthService
    {
        private readonly IUserService _userService;
        private readonly string _issuer;
        private readonly string _audience;
        private readonly int _expiryInMinutes;

        public AuthService(IUserService userService, IConfiguration configuration)
        {
            _userService = userService;

            var jwtSettings = configuration.GetSection("Jwt");
            _issuer = jwtSettings.GetValue<string>("Issuer");
            _audience = jwtSettings.GetValue<string>("Audience");
            _expiryInMinutes = jwtSettings.GetValue<int>("ExpiryInMinutes");
        }

        public string GenerateJwtToken(User user)
        {
            var claims = new[]
            {
            new Claim(ClaimTypes.NameIdentifier, user.Username),
            // Add any other claims as needed
        };

            var securityKey = new SymmetricSecurityKey(Encoding.UTF8.GetBytes(Secret.SecretKey));
            var credentials = new SigningCredentials(securityKey, SecurityAlgorithms.HmacSha256);

            var token = new JwtSecurityToken(
                issuer: _issuer,
                audience: _audience,
                claims: claims,
                expires: DateTime.Now.AddMinutes(_expiryInMinutes),
                signingCredentials: credentials
            );

            return new JwtSecurityTokenHandler().WriteToken(token);
        }
    }
}
