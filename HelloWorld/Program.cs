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

            // mosh solution
            //Console.Write("What is the speed limit? ");
            //var speedLimit = Convert.ToInt32(Console.ReadLine());

            //Console.Write("What is the speed of this car? ");
            //var carSpeed = Convert.ToInt32(Console.ReadLine());

            //if (carSpeed < speedLimit)
            //    Console.WriteLine("Ok");
            //else
            //{
            //    const int kmPerDemeritPoint = 5;
            //    var demeritPoints = (carSpeed - speedLimit) / kmPerDemeritPoint;
            //    if (demeritPoints > 12)
            //        Console.WriteLine("License Suspended");
            //    else
            //        Console.WriteLine("Demerit points: " + demeritPoints);
            //}
        }
    }
}
