using System.Runtime.CompilerServices;
using Microsoft.AspNetCore.Mvc;

namespace api.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class GreaterThanController : ControllerBase
    {

        [HttpGet("compare/{numOne:int}/{numTwo:int}")]
        public IActionResult Compare(int numOne, int numTwo)
        {
            string result;
            if (numOne > numTwo)
            {
                result = $"{numOne} is greater than {numTwo}.\n {numTwo} is less than {numOne}. ";
            }
            else if (numTwo > numOne)
            {
                result = $"{numTwo} is greater than {numOne}.\n {numOne} is less than {numTwo}. ";
            }
            else
            {
                result = "The numbers are equal.";
            }

            return Ok(new { numOne, numTwo, Result = result });
        }
    }
}
