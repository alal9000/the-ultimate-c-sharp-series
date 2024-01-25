using System.Collections;

namespace HelloWorld
{

    internal partial class Program
    {
        
        
        public static void Main(string[] args)
        {
            var shapes = new List<Shape>();
            shapes.Add(new Circle());
            shapes.Add(new Rectangle());

            var canvas = new Canvas();
            canvas.DrawShapes(shapes);

        }
    }
}
