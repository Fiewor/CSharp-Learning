public partial class Program
{
    public class Circle : Shape
    {
        public override void Draw()
        {
            Console.WriteLine("Draw a circle");
            // base.Draw(); // <- reference to the parent class
        }
    }
    public class Rectangle : Shape
    {
        public override void Draw()
        {
            Console.WriteLine("Draw a rectangle");
        }
    }

    public class Canvas
    {
        public void DrawShapes(List<Shape> shapes)
        {
            foreach (var shape in shapes)
            {
                shape.Draw();
            }
    }
    }
    public class Shape
    { 
        public int Width { get; set; }
        public int Height { get; set; }
        //public Position Position { get; set; }
        //public int X { get; set; }
        //public int Y { get; set; }
        public virtual void Draw()
        {

        }
    }
}