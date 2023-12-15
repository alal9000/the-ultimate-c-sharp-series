namespace HelloWorld
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int total = 0;
            while (true)
            {
                
                Console.Write("enter a number: ");
                var input = Console.ReadLine();

                if (input == "ok") 
                {
                    break;
                }

                var result = Convert.ToInt32(input);
                total += result;
                Console.WriteLine(total);

            }
            
        }
    }
}
