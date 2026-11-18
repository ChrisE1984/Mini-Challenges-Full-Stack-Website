

namespace api.Services
{
    public class AddTwoServices : IAddTwoServices
    {
        public int Addition(int numOne, int numTwo)
        {
            int sum = numOne + numTwo;
            return sum;
        }
    }
}