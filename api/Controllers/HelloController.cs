using Microsoft.AspNetCore.Mvc;

namespace api.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class HelloController : ControllerBase
    {

        [HttpGet("username")]
        public IActionResult UserName(string username)
        {
            return Ok (new {Message = $"Hello {username}!"});
        }
    }
}
