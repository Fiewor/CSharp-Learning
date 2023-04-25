public partial class Program
{
    public class Nullable<T> where T : struct
    {
        // remember that in C3, value types cannot be null
        // we can use this class to give our value types the ability to be nullable
        private object _value;

        // default constructor, in case value is not set
        public Nullable()
        {

        }
        public Nullable(T value)
        {
            _value = value; // boxingis done to convert value of type T to an object
        }

        public bool HasValue
        {
            get { return _value != null; }
        }

        public T GetValueOrDefault()
        {
            if (HasValue)
            {
                return (T)_value; // unboxing to give back value of type object in type T
            }
            return default(T); // this returns the default value for the type
        }
    }
}