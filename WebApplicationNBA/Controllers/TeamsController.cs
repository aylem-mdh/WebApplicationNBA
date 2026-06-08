using Microsoft.AspNetCore.Mvc;

namespace NBAApi.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class TeamsController : ControllerBase
    {
        [HttpGet]
        public IActionResult Get()
        {
            return Ok(new[]
            {
                new { Id = 1, Name = "Lakers" },
                new { Id = 2, Name = "Warriors" }
            });
        }
    }
}