using System.Runtime.CompilerServices;
using api.Services;
using Microsoft.AspNetCore.Mvc;

namespace api.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class GreaterThanController : ControllerBase
    {
        private readonly IGreaterThanServices _greaterThanServices;

        public GreaterThanController(IGreaterThanServices greaterThanServices)
        {
            _greaterThanServices = greaterThanServices;
        }

        [HttpGet("compare/{numOne:int}/{numTwo:int}")]
        public IActionResult Compare(int numOne, int numTwo)
        {
            string result;
            if (numOne > numTwo)
            {
                result = $"Your first number is {numOne} and your second number is {numTwo}.\n {numOne} is greater than {numTwo}. ";
            }
            else if (numTwo > numOne)
            {
                result = $"Your first number is {numOne} and your second number is {numTwo}.\n {numOne} is less than {numTwo}. ";
            }
            else
            {
                result = $"Your first number is {numOne} and your second number is {numTwo}.\n The numbers are equal.";
            }

            return Ok(new { numOne, numTwo, Result = result });
        }
    }
}
