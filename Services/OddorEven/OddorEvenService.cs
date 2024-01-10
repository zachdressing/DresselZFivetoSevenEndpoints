using DresselZFivetoSevenEndpoints.Services.OddorEven;

namespace DresselZFivetoSevenEndpoints.Services.MadLib.OddorEven
{
    public class OddorEvenService : IOddorEvenService
    {
        public string OddorEven(int num1)
        {
            if (num1 % 2 != 0)
            {
                return $"{num1} is odd";
            }
            else
            {
                return $"{num1} is even";
            }
        }
    }
}