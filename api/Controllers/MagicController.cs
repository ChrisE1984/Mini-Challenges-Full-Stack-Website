using Microsoft.AspNetCore.Mvc;
using api.Services;

namespace api.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class MagicController : ControllerBase
    {
        private readonly IMagicServices _magicServices;

        public MagicController(IMagicServices magicServices)
        {
            _magicServices = magicServices;
        }

        [HttpGet("answer")]
        public IActionResult Answer(string input)
        {
            string answer = _magicServices.Answer(input);
            return Ok(new { input, message = answer });
        }
    }
}