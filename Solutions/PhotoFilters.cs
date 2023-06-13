public partial class Program
{
    public class PhotoFilters
    {
        public void ApplyBrightness(Photo photo)
        {
            Console.WriteLine("Apply brightness");
        }        
        public void ApplyContrast(Photo photo)
        {
            Console.WriteLine("Apply contrast");
        }        
        public void Resize(Photo photo)
        {
            Console.WriteLine("Resize photo");
        }
    }
}