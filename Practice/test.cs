using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Practice

    // ENUMS
{
    // enum is a new type so we define it at the namesapce level
    public enum ShippingMethod
    {
        RegularAirMail = 1,
        RegisteredAirMail = 2,
        Express = 3
            // if you don't set any values for the members of this enum, the first member is going to be automatically set to 0
            // and every other member's value will be incrememnted by 1
            // best practice: always explicitly set values for enums 
    }
    internal class test
    {
        static void Main(string[] args)
        {
            // var method = ShippingMethod.Express;
            // Console.WriteLine((int) method);

            // say you receive a value and want to convert it to an enum
            // var methodId = 3;
            // Console.WriteLine((ShippingMethod)methodId); // casting to an enum - this returns 'Express' based on the ShippingMethod enum above

            // tip: by default, Console.WriteLine() calls toString() on any value you pass to it.
           //  Console.WriteLine(method.ToString());

            // string to enum
            // var methodName = "Express"; // say we need to convert (i.e. parse) this method name to a ShippingMethod Enum
            // parsing, in programming, means converting a string to a different type

            // var shippingMethod = (ShippingMethod)Enum.Parse(typeof(ShippingMethod), methodName); // also casting to a ShippingMethod instead of the normal return type which was an object.

            // REFERENCE TYPES AND VALUE TYPES

            // in C#, arrays (System.Array) and strings(System.String ) are classes

            // we hvae 2 MAIN TYPES from which we create new types
            // - classes e.g arrays and strings
            // - structure
            // all primitve types are internatlly defined as structures in .NET
            // this is because structs are used for small types and primtive types take no more than 8 bytes (pretty small)

            // classes and structs are treated differently at runtime in terms of memory management

            // structures are values types
            // when you create a variable that is a value type, a part of memory called stack is allocated for that variable
            // this is done automatically
            // variable is immediately removed when out of scope by runtime or CLR

            // classes are reference types
            // you need to allocate memory (using the new operator)
            // memory is allocated on heap (it is more sustainable and if you can create an object and that object goes out of scope, it will continue to reamin on the heap for a little while)
            // there is a process called garbage collection that takes cares of removing objects on heap that are no longer used

            var a = 10;
            var b = a;
            b++;
            // a is 10, b becomes 11
            // Console.WriteLine(string.Format("a: {0}, b: {1}", a, b));
            // when we copy a value type to another variable, a *copy* of that value is taken and stored in the target location in memory

            var array1 = new int[3] { 1, 2, 3 };
            var array2 = array1;
            array2[0] = 0;

            // Console.WriteLine(string.Format("array1[0]: {0}, array2[0]: {1}", array1[0], array2[0]));

            // CONTROL FLOW
            // for(initialization clause; condition clause; iteration clause){  }
            // foreach (var number in numbers) {  } // used for enumerables e.g. arrays and strings
            // do // loop is executed at least once
            // {
            //     if++
            // } while (if < 10);
            // better to use a 'while loop' when you don't know ahead of time the number of iterations

            // var numbers = new int[] { 1, 2, 3, 4 };
            // foreach (var number in numbers)
            // {
            //     Console.WriteLine(number);
            
            // }
            while (true)
            {
                // program runs until you enter (i.e. no name is typed)
                Console.Write("Type your name: ");
                // Console.Write() <- for this the cursor will be on the same line instead of a new line as is the case with Console.WriteLine()
                var input = Console.ReadLine();
                // if (String.IsNullOrWhiteSpace(input)) // user doesn't type in a name
                //     break;
                // Console.WriteLine("@Echo: " + input);

                // rewrite using continue
                if (!String.IsNullOrWhiteSpace(input))
                {
                    Console.WriteLine("@Echo: " + input);
                    continue;
                }

                break;
            }

            // Random Class
            var random = new Random();
            // more improvement to line 120
            
            const int passwordLength = 10;
            char[] buffer = new char[passwordLength];
            // instead of displaying each character in the console, we can store it in the buffer
            for (int i = 0; i < passwordLength; i++)
            {
                // Console.WriteLine(random.Next());
                //Console.Write((char)random.Next(97, 122)); // return a random number in the ascii range for lowercase letters THEN cast to integer TO generate a random string 
                // note: uses Console.Write so that there's no line break

                // more readable rewrite of line 120
                // Console.Write((char)('a' +  random.Next(0, 26)));
                // this works cause 'a' is represented internally as a number and adding that character to a number RESULTS in a number

                buffer[i] = (char)('a' + random.Next(0, 26));

            }
            var password = new string(buffer);
            Console.WriteLine(password);
            // Console.WriteLine((int)'a'); // will return 97

            // array - fixed number of variables of a particular type
            // there are 2 types of arrays
            // single-dimensional array -  the normal ones we've used
            // multi-dimensional e.g matrices
            // there are 2 types :
            // rectangular: each row has the exact number of columns
            // jagged: the number of columns in each row can be different

            // syntax for a rectangular 2D array
            // var matrix = new int[3, 5];
            var matrix = new int[3, 5] // you can use object initialization
            {
                { 1, 2, 3, 4, 5 },
                { 6, 7, 8, 9, 10 },
                { 11, 12, 13, 14, 15 }
            };
            var element = matrix[0, 0];

            // syntax for a rectangular 3D array
            var colors = new int[3, 5, 4];

            // syntax for jagged array
            var array = new int[3][]; // first square contains number of elements in top-level array
            // initialize each element of this array to a different array
            array[0] = new int[4];
            array[1] = new int[5];
            array[2] = new int[3];

            array[0][0] = 1;

            // int[] numbers = new int[] { 3, 7, 9, 2, 1 }; same as
            var numbers = new[] { 3, 7, 9, 2, 1 };

            var index = Array.IndexOf(numbers, 9);
            Console.WriteLine("Index of 9: " + index);

            // Clear - sets cleared values to default value for specified array
            // 0 for int array
            // false for boolean array
            // null for boolean array
            Array.Clear(numbers, 0, 2);
            foreach(var n in numbers)
                Console.WriteLine(n);

            // Copy()
            int[] another = new int[3];
            Array.Copy(numbers, another, 3);

            Console.WriteLine("Effect of Copy(");
            foreach(var n in another)
                Console.WriteLine(n);

            // Sort()
            Array.Sort(numbers);
            Console.WriteLine("Effect of Sort()");

            // Reverse()
            Array.Reverse(numbers);

            // Lists - atore objects of the same type just like an array, but it has DYNAMIC SIZE
            // created using the list generic type
                // specify a generic pqarameter between the angle brackets e.g. int. 
            // this specifies the tpe of the list
            // you can create a list of any non-primitve types
            var numbersList = new List<int>();
            // can use object initialization if you know in advance the items you want to put in your list
        }
    }
}
