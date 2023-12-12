using static System.Runtime.InteropServices.JavaScript.JSType;

namespace HelloWorld
{
    internal class Program
    {
        static void Main(string[] args)
        {
            byte a = 1;

            {
                byte b = 2;
                
                {
                    byte c = 3;
                    Console.WriteLine(a);
                    Console.Beep();
                }
            }
            
        }
    }
}
