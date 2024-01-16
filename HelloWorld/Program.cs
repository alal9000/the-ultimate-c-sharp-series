namespace HelloWorld
{

    internal partial class Program
    {
        
        public static void Main(string[] args)
        {
            var cookie = new HttpCookie();
            cookie["name"] = "mosh";
            Console.WriteLine(cookie["name"]);
        }
    }
}
