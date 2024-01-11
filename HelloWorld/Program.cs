using System.Text;

namespace HelloWorld
{
    internal class Program
    {
        
        static void Main(string[] args)
        {
            var path = @"c:\Users\aaron\functions.php";

            var dotIndex = path.IndexOf('.');
            var extension = path.Substring(dotIndex);

            Console.WriteLine("Path: " + Path.GetExtension(path));
            Console.WriteLine("File name: " + Path.GetFileName(path));
            Console.WriteLine("File name: " + Path.GetFileNameWithoutExtension(path));
            Console.WriteLine("Directory name: " + Path.GetDirectoryName(path));



        }
        
    }
}
