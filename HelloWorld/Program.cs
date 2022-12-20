internal class Program
{
    private static void Main(string[] args)
    {
        // C# is a statically typed language
        // meaning when you declare a variable, you need to declare its type
        // that type cannot change durig the lifecycle of that variable

        // byte number = 2; // can replace types with var keyword
        // int count = 10;
        // float totalPrice = 20.95f;
        // char character = 'A'; // single quote for characters
        // string firstName = "John"; // double quote for string
        // bool isWorking = true;

        // Console.WriteLine(number);
        // global::System.Console.WriteLine(count);
        // global::System.Console.WriteLine(totalPrice);

        // Console.WriteLine("{0} {1}", byte.MinValue, byte.MaxValue); // using format string
        // const float Pi = 3.14f;

        //--- implicit type conversion
        // happens between compatible types
        // byte b = 1;
        // int i = b;

        // int a = 1;
        // float f = a;

        //--- explicit type conversion
        // int i = 1;
        // byte b = i; // won't compile if there's chance of data lose
        // byte b = (byte)i; // this is called casting

        // float f = 1.0f;
        // int i = (int)f; // casting is basically us telling the compiler that we are aware of the data loss and we still want to convert to another data type

        // string s = "l";
        // int i = (int)s; // won't cast and compile cause string and int are not compatible

        // use convert class or parse methos in cases like this
        // string s = "1";
        // int i = Convert.ToInt32(s); // Int32 is a .NET framework type which maps to a C# int type
        // int j = int.Parse(s); // all primitive types (int, long, float, boolean) have this parse method
        // this method takes a string and tries to convert to the target type

        //--- Convert - below are some methods you find in the convert class
        // ToByte() - to byte
        // ToInt16() - to short
        // ToInt32() - to int
        // ToInt64() - to long

        //--- using a try catch block to handle an exception (in this case, an overflow)
        // this prevents your app from crashing
        // if you don't handle the exception, the exception will be propagated to the .NET runtime which will stop your app and display the error

        // try
        // {
        // var number = "1234";
        // byte b = Convert.ToByte(number);
        // global::System.Console.WriteLine(b);

        // another example
        // string s = "true";
        // bool b = Convert.ToBoolean(s);
        // global::System.Console.WriteLine(b);
        // }
        // catch (global::System.Exception)
        // {
        // handling the exception prevents the eror from being propagated to the .NET runtime
        // instead we display a friendly message to user
        // global::System.Console.WriteLine("The number could not be converted to a byte");
        // }

        // arithmetic operations
        // var a = 1; // the compiler infers the types of a and b to be integers
        // var b = 2;
        // var c = 3;
        // global::System.Console.WriteLine(a/b); // so, the result will also be an integer
        // to get value of division to be a float, use type casting
        // global::System.Console.WriteLine((float)a / (float)b);

        // global::System.Console.WriteLine(a + b * c);
        // global::System.Console.WriteLine(a == b);
        // global::System.Console.WriteLine(c > b || c == a);

        /*
         multi-line comment
        use comments to explain whys, hows, constraints...not the whats
        code should be self-explanatory
         */

        // CLASSES

        // Classes combine related variables (fields) and functions (methods)

        // A clas is a type or a blueprint from which we create objects
        // An object is an instance of a class

        // create a class by starting with an access modifier e.g. public
        // this determines who can access the class
        // public makes the class accessible anywhere in your app

        // then 'class' keyword and an identifer

        // we can have variables called 'fields' in the class
        // you also need to specify an access modifier and end with smeicolon -;
        // use new operator to allocate memory for an object
        // you need to explicitly allocate memory for classes in C# 
        // CLR has garbabge collection which auto-removes all object that are not used so no need to deallocate memory unlike languages like C#

        // how to allocate memory to an object -> Person person = new Person();
        //can also use var -> var Person = new Person();

        // STATIC MODIFIER
        // public class Calculator
        // {
        //     public static int Add(int a, int b)
        //     {
        //         return a + b;
        //     }
        // }

        // as a result of the 'static' keyword, you can access the 'Add' method directly by the calculator itself
        // int result = Calculator.Add(1, 2);
        // global::System.Console.WriteLine('result: ', result);
        // we don't have create an object to access a static member
        // we CAN'T even access static members from objects
        // use STATIC modifier when we want a concept that only a single insance of it should in memory

        // we also have the STRUCTURE or STRUCT
        // similar to a class, but uses a 'struct' keyword instead of 'class' keyword
        // use a struct when you want to define a small lightweight object e.g.
        // public struct RgbColor
        // {
        //     public int Red;
        //     public int Green;
        //     public int Blue;
        // }

        // ARRAY
        // store collecion of variables of the same type;
        int[] numbers = new int[3] { 1, 2, 3 };
        // first bracket tells the compiler that you would like to declare an arry
        // second sets the size of the array
        // array have fixed size in C# and the size cannot be changed
        // use 'new' keyword cause you have to allocate memory
        // an array is an object internally
        // numbers[0] = 1;
        // numbers[1] = 2;
        // numbers[2] = 3;
        // if you know the values ahead of time, supply them in curly places

        // when you declare an array, all the elements are set to the default values of the data type for that array
        // for numbers, taht is 0
        // for booleans, that is false

        // var flags = new bool[3];
        // flags[0] = true;

        // Console.WriteLine(flags[0]);
        // Console.WriteLine(flags[1]);
        // Console.WriteLine(flags[2]);

        // var names = new string[3] { "John", "Joan", "James" };
        // this method of supplying the values for each element of the array during initialization is called 'object initialization syntax'

        // ENUMS

        // Enum is a data type that represents a set of name / value pairs or constants
        // Use enums when you have a numer of related constants.
        // Instead of declaring multiple constants like
        const int RegularAirMail = 1;
        const int RegiteredAirMail = 2;
        const int Express = 3
        // declare an enum, like this:
        // public enum ShippingMethod
        // {
        //     RegularAirMail = 1,
        //     RegiteredAirMail = 2,
        //     Express = 3;

        // }
        // this will be a new type in your app, just like we have classes or structs
        // can now use the enum with the dot notation
        var method = ShippingMethod.Express;
        // an enum is internally an int
        // if you have a reason, you can change it and use a byte instead like:
        public enum ShippingMethod : byte
        {
            RegularAirMail = 1,
            RegiteredAirMail = 2,
            Express = 3;
        }
        // you could do this if, perhaps, it could be easier for you to map in your database columns.

}
}