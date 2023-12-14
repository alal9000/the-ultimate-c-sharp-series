namespace HelloWorld
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var season = Season.AUTUMN;

            switch (season)
            {
                case Season.AUTUMN:
                case Season.SUMMER:
                    Console.WriteLine("we have got promotion");
                    break;

                default:
                    Console.WriteLine("I dont understand that season!");
                    break;
            }
        }

    }
}
