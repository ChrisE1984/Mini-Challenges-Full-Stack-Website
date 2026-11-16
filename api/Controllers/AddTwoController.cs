using Microsoft.AspNetCore.Mvc;

namespace api.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class AddTwoController : ControllerBase
    {
        [HttpGet("addition/{numOne}/{numTwo}")]
        public IActionResult Addition(int numOne, int numTwo)
        {
            int sum = numOne + numTwo;
            return Ok(new
            {
                numOne,
                numTwo,
                result = sum,
                message = $"The numbers you entered add up to {sum}."
            });
        }
    }
}