
namespace api.Services
{
    public class RestaurantServices : IRestaurantServices
    {
        private static readonly string[] MexicanRestaurants =
        [
            "El Pollo Loco",
            "Chipotle",
            "La Campana",
            "Taco Bell",
            "Tacos Rincon",
            "Tacos Chapalla",
            "El Pazcifico",
            "Agave",
            "El Chaparro",
            "La Dona"
        ];

        private static readonly string[] AmericanRestaurants =
        [
            "Lodi Beer Company",
            "The Oxford",
            "Avenue Grill",
            "Brick House",
            "Big Kahuna Burger",
            "The Habit",
            "The Dancing Fox",
            "Market Tavern",
            "BJ's Grill",
            "The Graduate"
        ];

        private static readonly string[] ItalianRestaurants =
        [
            "Pietro's",
            "Nonas",
            "Jimmys",
            "Guantonio's",
            "Strings",
            "DaVinci's",
            "Pi Bar",
            "Ruby's and Roses",
            "Franco's Pizza",
            "Mountain Mike's"
        ];

        public string MexicanRestaurant() => PickRestaurant(MexicanRestaurants);

        public string AmericanRestaurant() => PickRestaurant(AmericanRestaurants);

        public string ItalianRestaurant() => PickRestaurant(ItalianRestaurants);

        private static string PickRestaurant(string[] restaurants)
        {
            int randomNumber = Random.Shared.Next(restaurants.Length);
            return restaurants[randomNumber];
        }
    }
}