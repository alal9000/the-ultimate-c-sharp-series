using System.Text.RegularExpressions;

namespace HelloWorld
{
    public class StopWatch
    {
        
        private DateTime start;
        private DateTime stop;
        private TimeSpan _duration;

        public TimeSpan Duration
        {
            get
            {
                // Calculate and return the duration based on the difference between start and stop
                return stop - start;
            }
        }



        public void Start()
        {
            start = DateTime.Now;
        }

        public void Stop()
        {
            stop = DateTime.Now;
        }
    }

    internal partial class Program
    {
        
        public static void Main(string[] args)
        {
            StopWatch watch = new StopWatch();
            watch.Start();
            TimeSpan delay = TimeSpan.FromSeconds(10);
            watch.Stop();
            Console.WriteLine(watch.Duration + delay);
        }
    }
}
