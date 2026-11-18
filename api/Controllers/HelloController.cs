using Microsoft.AspNetCore.Mvc;
using api.Services;

namespace api.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class HelloController : ControllerBase
    {
        private readonly IHelloServices _helloServices;

        public HelloController(IHelloServices helloServices)
        {
            _helloServices = helloServices;
        }

        [HttpGet("username")]
        public IActionResult UserName(string username)
        {
            string message = _helloServices.Username(username);
            return Ok(new { Message = message });
        }
    }
}
