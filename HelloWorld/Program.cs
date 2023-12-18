using static System.Runtime.InteropServices.JavaScript.JSType;

namespace HelloWorld
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var secretNumber = new Random().Next(1, 11);
            Console.WriteLine(secretNumber);

            var input = "";
            var convertedInput = 0;
            int count = 0;
            while (count < 4) 
            {
                Console.Write("Pick a number: ");
                input = Console.ReadLine();
                convertedInput = Convert.ToInt32(input);
                Console.WriteLine(convertedInput);

                if (convertedInput == secretNumber)
                    break;

                count++;   
            }
            var result = (convertedInput != secretNumber) ? "lost" : "won";
            Console.WriteLine(result);
        }
    }
}
