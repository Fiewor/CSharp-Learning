public partial class Program
{
    //in C#, a class can have only one parent

    public class Text : PresentationObject
    {
        public int FontSize { get; set; }
        public int FontName { get; set; }
        public void AddHyperLink(string url)
        {
            Console.WriteLine("Added a link to " + url);
        }
    }
}