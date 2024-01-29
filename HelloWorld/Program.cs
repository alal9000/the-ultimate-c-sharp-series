using System.Collections;

namespace HelloWorld
{

    internal partial class Program
    {
        
        
        public static void Main(string[] args)
        {
            //var shape = new Shape2();
            
            var circle = new Circle();
            circle.Draw();

            var rectangle = new Rectangle();
            rectangle.Draw();   
        }
    }
}
