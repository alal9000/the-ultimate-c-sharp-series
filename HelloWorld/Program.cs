namespace HelloWorld
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Console.Write("Enter width of image: ");
            //var width = Console.ReadLine();

            //int convertedWidth = Convert.ToInt32(width);

            //Console.Write("Enter height of image: ");
            //var height = Console.ReadLine();

            //int convertedHeight = Convert.ToInt32(height);

            //if (convertedWidth > convertedHeight)
            //{

            //    Console.WriteLine("landscape");
            //}
            //else if (convertedHeight > convertedWidth)
            //{
            //    Console.WriteLine("Portrait");
            //}
            //else
            //{
            //    Console.WriteLine("even");
            //}

            //mosh solution
            Console.Write("Image width: ");
            var width = Convert.ToInt32(Console.ReadLine());

            Console.Write("Image height: ");
            var height = Convert.ToInt32(Console.ReadLine());

            var orientation = width > height ? ImageOrientation.Landscape : ImageOrientation.Portrait;
            Console.WriteLine("Image orientation is " + orientation);

                


        }
        public enum ImageOrientation
        {
            Landscape,
            Portrait
        }
    }
}
