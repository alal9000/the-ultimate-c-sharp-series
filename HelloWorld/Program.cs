namespace HelloWorld
{

    internal partial class Program
    {
        
        
        public static void Main(string[] args)
        {
            //number => number * number

            const int factor = 5;

            Func<int, int> multipler = n => n*factor;

            var result = multipler(10);
            Console.WriteLine(result);

            Func<int, int> square = number => number * number;

            //Console.WriteLine(square(5));
        }
    }
}
