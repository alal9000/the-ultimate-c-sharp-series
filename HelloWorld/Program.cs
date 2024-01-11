using System.Text;

namespace HelloWorld
{
    internal class Program
    {
        
        static void Main(string[] args)
        {
            Directory.CreateDirectory(@"c:\temp\folder1");

            //var files = Directory.GetFiles(@"c:\Users\aaron", "*.sln");

            //foreach (var item in files)
            //    Console.WriteLine(item);

            var directories = Directory.GetDirectories(@"c:\Users\aaron", "*.*", SearchOption.AllDirectories);

            foreach (var item in directories)       
                Console.WriteLine(item);

            Directory.Exists("...");

            var diretoryInfo = new DirectoryInfo("...");
            diretoryInfo.GetFiles();
            diretoryInfo.GetDirectories();

        }
        
    }
}
