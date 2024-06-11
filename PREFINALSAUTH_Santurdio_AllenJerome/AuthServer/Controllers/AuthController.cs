using AuthServer.Core;
using Microsoft.AspNetCore.Mvc;

namespace AuthServer.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AuthController : ControllerBase
    {
        private readonly IUserService _userService;
        private readonly IAuthService _authService;

        public AuthController(IUserService userService, IAuthService authService)
        {
            _userService = userService;
            _authService = authService;
        }

        [HttpPost("register")]
        public IActionResult Register(User user)
        {
            // Hash the password before storing it
            user.PasswordHash = BCrypt.Net.BCrypt.HashPassword(user.PasswordHash);

            if (!_userService.RegisterUser(user))
                return BadRequest("Username already exists.");

            return Ok();
        }

        [HttpPost("login")]
        public IActionResult Login(User credentials)
        {
            var user = _userService.GetUserByUsername(credentials.Username);

            if (user == null || !BCrypt.Net.BCrypt.Verify(credentials.PasswordHash, user.PasswordHash))
                return Unauthorized();

            var token = _authService.GenerateJwtToken(user);
            return Ok(new { Token = token });
        }
    }
}
