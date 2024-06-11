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
            
            var userInfo = new
            {
                Name = "Allen Jerome Santurdio",
                Section = "BSIT32E2",
                Course = "Infortmation Technology"
            };

            var funFacts = new[]
            {
                "I hate programming!",
                "I enjoy playing video games.",
                "I like watching anime/movies.",
            };

            return Ok(new { UserInfo = userInfo, FunFacts = funFacts });
        }
    }
}
