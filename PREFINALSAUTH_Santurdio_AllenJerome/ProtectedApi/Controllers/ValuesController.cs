using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace ProtectedApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ValuesController : ControllerBase
    {
        [HttpGet]
        [Authorize]
        public IActionResult Get()
        {
            // Replace with your own user information and fun facts
            var userInfo = new
            {
                Name = "John Doe",
                Section = "Section A",
                Course = "Computer Science"
            };

            var funFacts = new[]
            {
                "I love programming!",
                "I enjoy playing video games.",
                "I'm a big fan of sci-fi movies.",
                // Add more fun facts here
            };

            return Ok(new { UserInfo = userInfo, FunFacts = funFacts });
        }
    }
}
