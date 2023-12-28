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

            // mosh solution
            //Console.Write("Enter a number: ");
            //var number1 = Convert.ToInt32(Console.ReadLine());

            //Console.Write("Enter another number: ");
            //var number2 = Convert.ToInt32(Console.ReadLine());

            //var max = (number1 > number2) ? number1 : number2;
            //Console.WriteLine("Max is " + max);


        }
    }
}
