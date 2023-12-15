namespace HelloWorld
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter width of image: ");
            var width = Console.ReadLine();

            int convertedWidth = Convert.ToInt32(width);

            Console.Write("Enter height of image: ");
            var height = Console.ReadLine();

            int convertedHeight = Convert.ToInt32(height);

            if (convertedWidth > convertedHeight)
            {
                
                Console.WriteLine("landscape");
            }     
            else if (convertedHeight > convertedWidth)
            {
                Console.WriteLine("Portrait");
            }
            else
            {
                Console.WriteLine("even");
            }
                

        }
    }
}
