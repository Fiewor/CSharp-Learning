public partial class Program
{

    // where T : IComparable => applying a constraint to an interface
    // where T : Product => apply constraint to a class (in this class, we're saying if T is a Product, or any of its children/subclasses)
    // where T : struct => basically saying T should be a 'value type'
    // where T : class => iterator has to be a 'reference type'
    // where T : new() => T is an object that has a default constructor

    // you can create a generic method inside a non-generic class
    public class Utilities<T> where T : IComparable, new() //<- moved template here instead, so need to have it in the method. This is one type of constraint
        // also add a constraint to a default constructor i.e. new()
    {
        //public int Max(int a, int b) 
        public int Max(int a, int b)
        {
            return a > b ? a : b;
        }

        // how to do the max, but this time, using generics
        public T Max(T a, T b) 
        //public T Max<T>(T a, T b) where T : IComparable // <- to ensure you can actually compare parameters a and b
        {
            return a.CompareTo(b) > 0 ? a : b;
        }

        public void DoSomething(T value)
        {
            var obj = new T();
        }
    }
}