using api.Services;
using Microsoft.AspNetCore.Mvc;

namespace api.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class AddTwoController : ControllerBase
    {
        private readonly IAddTwoServices _addTwoServices;

        public AddTwoController(IAddTwoServices addTwoServices)
        {
            _addTwoServices = addTwoServices;
        }


        [HttpGet("addition/{numOne}/{numTwo}")]
        public IActionResult Addition(int numOne, int numTwo)
        {
            int sum = _addTwoServices.Addition(numOne, numTwo);
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