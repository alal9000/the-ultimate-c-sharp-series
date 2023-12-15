namespace HelloWorld
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter speed limit: ");
            var speedLimit = Console.ReadLine();
            int convertedSpeedLimit = Convert.ToInt32(speedLimit);

            Console.Write("Enter speed of car: ");
            var speed = Console.ReadLine();
            int convertedSpeed = Convert.ToInt32(speed);

            if (convertedSpeed < convertedSpeedLimit)
                Console.WriteLine("OK");
            else if (convertedSpeed > convertedSpeedLimit)
            {
                int difference = convertedSpeed - convertedSpeedLimit;
                int demeritPoints = difference / 5;

                var result = demeritPoints >= 12 ? "suspended" : Convert.ToString(demeritPoints);
                Console.WriteLine(result);
            }
            else
                Console.WriteLine("even");
        }
    }
}
