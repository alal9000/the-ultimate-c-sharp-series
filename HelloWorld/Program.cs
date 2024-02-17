namespace HelloWorld
{

    internal partial class Program
    {
        
        
        public static void Main(string[] args)
        {
            try
            {
                var api = new YouTubeApi();
                var videos = api.GetVideos("Mosh");
                //using(var streamReader = new StreamReader(@"c:\file.zip"))
                //{
                //    var content = streamReader.ReadToEnd();
                //}
                //var calculator = new Calculator1();
                //var result = calculator.Divide(5, 0);
                //throw new Exception("Oops");
            }
            //catch (DivideByZeroException ex)
            //{
            //    Console.WriteLine("You cannot divide by 0");
            //}
            //catch (ArithmeticException ex)
            //{

            //}
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            //finally
            //{
            //    if (streamReader != null)
            //        streamReader.Dispose();
            //}
        }
    }
}
