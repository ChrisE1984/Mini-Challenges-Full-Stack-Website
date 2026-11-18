using api.Services;
using Microsoft.AspNetCore.Mvc;

namespace api.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class MadLibsController : ControllerBase
    {
        private readonly IMadLibsServices _madLibsServices;

        public MadLibsController(IMadLibsServices madLibsServices)
        {
            _madLibsServices = madLibsServices;
        }


         [HttpGet("game/{adjective1}/{noun1}/{pluralnoun}/{verb}/{color}/{adjective2}/{number}/{exclamation}/{noun2}/{sillyword}")]
        public IActionResult Game(string adjective1, string noun1, string pluralnoun, string verb, string color, string adjective2, string number, string exclamation, string noun2, string sillyword)
        
        {
            string message = _madLibsServices.Game(adjective1, noun1, pluralnoun, verb, color, adjective2, number, exclamation, noun2, sillyword );
            return Ok(new { Message = message });
        }
    }
}