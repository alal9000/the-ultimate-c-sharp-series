
using Amazon;

namespace HelloWorld
{

    internal partial class Program
    {
        
        public static void Main(string[] args)
        {
            var customer = new Customer2();
            Amazon.RateCalculator calculator = new Amazon.RateCalculator();
        }
    }
}
