

namespace api.Services
{
    public class GreaterThanServices : IGreaterThanServices
    {
        public bool Compare(int numOne, int numTwo)
        {
            return numOne > numTwo;
        }
    }
}