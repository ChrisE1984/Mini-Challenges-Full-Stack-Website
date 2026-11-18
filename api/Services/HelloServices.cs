namespace api.Services
{
    public class HelloServices : IHelloServices
    {
        public string Username(string username)
        {
            return $"Hello, {username}!";
        }
    }
}