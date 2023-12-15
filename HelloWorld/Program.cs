namespace HelloWorld
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a number: ");
            var input1 = Console.ReadLine();

            int convertedInput1 = Convert.ToInt32(input1);

            Console.WriteLine("Enter another number: ");
            var input2 = Console.ReadLine();

            int convertedInput2 = Convert.ToInt32(input2);

            if (convertedInput1 > convertedInput2)
            {
                Console.WriteLine(convertedInput1);
            }     
            else if (convertedInput2 > convertedInput1)
            {
                Console.WriteLine(convertedInput2);
            }
            else
            {
                Console.WriteLine("even");
            }
                

        }
    }
}
