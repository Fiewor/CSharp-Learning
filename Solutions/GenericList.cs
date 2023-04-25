public partial class Program
{
    public class GenericList<T> // <- generics take parameters
    {
        public void Add(T value)
        {

        }

        public T this[int index] // <- indexer
        {
            get { throw new NotImplementedException(); }
        }
    }
}