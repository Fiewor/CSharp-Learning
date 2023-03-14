public partial class Program
{
    public class PresentationObject
    {
        public int Width { get; set; }
        public int Height { get; set; }

        public void Copy()
        {
            Console.WriteLine("Object copied to clipboard.");
        }

        public void Duplicated()
        {
            Console.WriteLine("Object was duplicated.");
        }
    }
}