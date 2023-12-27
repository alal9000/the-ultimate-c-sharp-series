namespace HelloWorld
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter number between 1 and 10");
            var input = Console.ReadLine();

            int convertedInput = Convert.ToInt32(input); // try to be consistent with variable conventions and change int to var here

            if (convertedInput > 0 && convertedInput < 11) // by making the condition (number >= 1 && number <= 10) makes your code slightly more readable
            {
                Console.WriteLine("Valid"); // we can remove curly braces to reduce an extra 4 lines of code as we only have one expression here 
            }     
            else
            {
                Console.WriteLine("Invalid");
            }
                

        }
    }
}
