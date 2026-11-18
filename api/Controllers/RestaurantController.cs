using api.Services;
using Microsoft.AspNetCore.Mvc;

namespace api.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class RestaurantController : ControllerBase
    {
        private readonly IRestaurantServices _restaurantServices;

        public RestaurantController(IRestaurantServices restaurantServices)
        {
            _restaurantServices = restaurantServices;
        }

        [HttpGet("mexican")]
        public IActionResult MexicanRestaurant()
        {
            return Ok(new { message = _restaurantServices.MexicanRestaurant() });
        }

        [HttpGet("american")]
        public IActionResult AmericanRestaurant()
        {
            return Ok(new { message = _restaurantServices.AmericanRestaurant() });
        }

        [HttpGet("italian")]
        public IActionResult ItalianRestaurant()
        {
            return Ok(new { message = _restaurantServices.ItalianRestaurant() });
        }
    }
}