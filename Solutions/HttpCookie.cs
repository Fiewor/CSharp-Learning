public partial class Program
{
    public class HttpCookie
    {
        private readonly Dictionary<string, string> _dictionary;

        // expiring property
        public DateTime Expiry { get; set; }

        public HttpCookie()
        {
            _dictionary = new Dictionary<string, string>();
        }

        public string this[string key]
        {
            get { return _dictionary[key]; }
            set { _dictionary[key] = value; }
        }
    }
}