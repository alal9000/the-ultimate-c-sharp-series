namespace HelloWorld
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int total = 0;      // use var here
            while (true)
            {

                Console.Write("enter a number: ");
                var input = Console.ReadLine();

                if (input == "ok")
                {       // can remove left and right curly brace as only one expression for if block
                    break;
                }

                var result = Convert.ToInt32(input); // this and bottom line can be converted to one and we dont need the extra variable result, we can re-use total ie: total += Convert.ToInt32(input);
                total += result;
                Console.WriteLine(total);

            }

            // mosh solution

            //var sum = 0;
            //while (true)
            //{
            //    Console.Write("Enter a number (or 'ok' to exit): ");
            //    var input = Console.ReadLine();

            //    if (input.ToLower() == "ok")
            //        break;

            //    sum += Convert.ToInt32(input);
            //}
            //Console.WriteLine("Sum of all numbers is: " + sum);

        }
    }
}
