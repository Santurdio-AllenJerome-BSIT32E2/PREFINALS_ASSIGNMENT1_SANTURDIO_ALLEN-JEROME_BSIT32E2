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
                Name = "Justine Ryu S. Perez",
                Section = "BSIT32E2",
                Course = "Infortmation Technology"
            };

            var funFacts = new[]
            {
                "I Eat.",
                "I Sleep.",
                "I Pray.",
            };

            return Ok(new { UserInfo = userInfo, FunFacts = funFacts });
        }
    }
}
