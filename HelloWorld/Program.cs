namespace HelloWorld
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter number between 1 and 10");
            var input = Console.ReadLine();

            int convertedInput = Convert.ToInt32(input);

            if (convertedInput > 0 && convertedInput < 11)
            {
                Console.WriteLine("Valid");
            }     
            else
            {
                Console.WriteLine("Invalid");
            }
                

        }
    }
}
