namespace HelloWorld
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter a number: ");
            var input = Console.ReadLine();
            var conversion = Convert.ToInt32(input);

            int total = 1;
            for (int i = conversion; i > 0; i--)
            {
                total = i * total;
            }
            
            var result = String.Format("{0}! = {1}", input, total);
            Console.WriteLine(result);

        }
    }
}
