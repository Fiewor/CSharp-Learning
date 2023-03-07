using System.Text;


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
            // for (int i = 0; i < passwordLength; i++)
            //{
                // Console.WriteLine(random.Next());
                //Console.Write((char)random.Next(97, 122)); // return a random number in the ascii range for lowercase letters THEN cast to integer TO generate a random string 
                // note: uses Console.Write so that there's no line break

                // more readable rewrite of line 120
                // Console.Write((char)('a' +  random.Next(0, 26)));
                // this works cause 'a' is represented internally as a number and adding that character to a number RESULTS in a number

                //buffer[i] = (char)('a' + random.Next(0, 26));

            //}
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
            //foreach (var n in numbers)
                //Console.WriteLine(n);

            // Copy()
            int[] another = new int[3];
            Array.Copy(numbers, another, 3);

            Console.WriteLine("Effect of Copy()");
            foreach (var n in another)
                Console.WriteLine(n);

            // Sort()
            Array.Sort(numbers);
            Console.WriteLine("Effect of Sort()");

            // Reverse()
            Array.Reverse(numbers);

            // LISTS

            // Lists - atore objects of the same type just like an array, but it has DYNAMIC SIZE
            // created using the list generic type
            // specify a generic pqarameter between the angle brackets e.g. int. 
            // this specifies the tpe of the list
            // you can create a list of any non-primitve types
            // var numbersList = new List<int>();

            // can use object initialization if you know in advance the items you want to put in your list
            var numbersList = new List<int>() { 1, 2, 3, 4 };
            numbersList.Add(1);
            numbersList.AddRange(new int[3] { 5, 6, 7 }); // a type prefixed with I is an interface

            // TIP: whenever you see IENUMERABLE in the intellisense, you can use an array or a list

            foreach (var number in numbersList)
                Console.WriteLine(number);

            Console.WriteLine();
            Console.WriteLine("index of 1: " + numbersList.IndexOf(1));
            Console.WriteLine("last index of 1: " + numbersList.LastIndexOf(1));

            Console.WriteLine("count: " + numbers.Count());

            foreach (var number in numbersList)
            {
                if (number == 1)
                    numbersList.Remove(number); // this modifies the collection
                                                // in C#, we're not allowed to modify our collection inside a foreach loop
            }

            for (int i = 0; i < numbersList.Count; i++)
            {
                if (numbersList[i] == 1)
                    numbersList.Remove(numbersList[i]);
            }

            foreach (var number in numbersList)
                Console.WriteLine(number);

            numbersList.Clear();
            // removes all elements from an array

            // DateTime
            // represents an exact date and time value (a point in time)
            var dateTime = new DateTime(2015, 1, 1);
            var now = DateTime.Now;
            var today = DateTime.Today;

            Console.WriteLine("Hour: " + now.Hour);
            Console.WriteLine("Minute: " + now.Minute);

            // DateTime object is immutable
            // use .Add* methods to modify them
            var tomorrow = now.AddDays(1);
            var yesterday = now.AddDays(-1);

            var longDay = now.ToLongDateString();
            var shortDay = now.ToShortDateString();
            var longTime = now.ToLongTimeString();
            var shortTime = now.ToShortTimeString();

            var bothDayAndTime = now.ToString();
            // or use with format specifier
            var bothDayAndTime1 = now.ToString("yyyy-MM-dd HH:MM");

            // Time Span - represents a length of time (a duration)
            var timeSpan = new TimeSpan(1, 2, 3); // (hours, minutes, seconds)
            // if you don't have the values for miutes and seconds, just pass in zeros
            var timeSpan1 = new TimeSpan(1, 0, 0);

            // clearer syntax
            var timeSpan2 = TimeSpan.FromHours(1); // alternative to line 265

            var start = DateTime.Now;
            var end = DateTime.Now.AddMinutes(2);
            var duration = end - start; // returns a timespan

            // TimeSpan properties
            var minutes = timeSpan.Minutes; // returns the minutes component of your time span object
            var totalMinutes = timeSpan.TotalMinutes; // converts the time span object to mionutes

            // timespan is also immutable just like dateteime

            // add 8 minutes to the original timestamp
            Console.WriteLine(timeSpan.Add(TimeSpan.FromMinutes(8)));

            //subtract time
            Console.WriteLine(timeSpan.Subtract(TimeSpan.FromMinutes(2)));

            //ToString
            Console.WriteLine("ToString: " + timeSpan.ToString());
            // note that Console.WriteLine automatically calls ToString on any object passed to it

            // Parse -> conversion from a string to timespan object
            Console.WriteLine("Parse: " + TimeSpan.Parse("01:02:03"));

            // both DateTime and TimeSpan are structs. 
            // they're both immutable
            // calling a method on them returns a new instance

            // Strings

            // FORMATTING
            // ToLower()
            // ToUpper()
            // Trim() - remove whitespace at the beginning or end of a string

            // SEARCHING
            // IndexOf()
            // LastIndexOf()

            // SUBSTRING
            // Substring(startIndex) // retrieves al characters and returns everything from that point to the end of the string
            // Substring(startIndex, length) // limit the number of characters to retrieve

            // REPLACE
            // Replace('a', 'b')

            // NULL CHECKING
            // String.IsNullOrEmpty(str)
            // String.IsNullOrWhiteSpace(str)

            // SPLITTING
            // str.Split(' ') // split by word

            // Converting strings to numbers
            string s = "1234";
            int i = int.Parse(s); // throws an exception if string is null or empty
            int j = Convert.ToInt32(s); // if string is null or empty, it converts to default integer value i.e. 0

            int n = 1234;
            string s1 = i.ToString(); // "1234"
            string s2 = i.ToString("C"); // format using format string e.g. using C (currency) to get "$1,234.00" 
                                         // by default, this inserts a comma after every 4 digits and has 2 decimal places
            string s3 = i.ToString("C0"); // 0 representing the number of decimal places you want (in this case, none) <- $1,234

            // other format specifiers:
            // d or D <- decimal
            // e or E <- exponential
            // f or F <- Fixed Point
            // x or X <- Hexadecimal

            // each method returns a new string cause strings are immutable
            // you can chain methods
            var fullName = "John Fiewor ";
            Console.WriteLine("Trim and ToUppper: '{0}'", fullName.Trim().ToUpper());

            // split into firstname and lastname
            // using substring
            var ind = fullName.IndexOf(' ');
            var firstName = fullName.Substring(0, ind);
            var lastName = fullName.Substring(ind + 1); // end not explicitly specified so it will automatically so it will use default behaviour

            //using split
            var names = fullName.Split(' '); // returns a string array
            Console.WriteLine("FirstName: " + names[0]);
            Console.WriteLine("LastName: " + names[1]);

            fullName.Replace("John", "James");

            if (String.IsNullOrEmpty(null)) // deosn't check for whitespace
                Console.WriteLine("Invalid");
            if (String.IsNullOrWhiteSpace(" "))
                Console.WriteLine("Invalid"); // checks for whitespaces

            var stri = "25";
            // var age = Convert.ToInt32(stri);
            // can use ToByte instead of ToInt32 when converting from str to number cause 1 byte is enough to represent anyone's age (no one can be older than 250)
            var age = Convert.ToByte(stri);
            Console.WriteLine(age);

            // convert to string
            float price = 29.95f;
            price.ToString();

            var sentence = "This is going to be a really really really really really really really long text";
            StringUtility.SummarizeText(sentence, 25); // Class.Method

            // StringBuilder
            // defined in System.Text namespace
            // represents a mutable string
            // easy and fast to create and manipulate strings
            // unlike String class, it's not optimised for searching
            // no IndexOf(), LastIndexOf(). Contains(), StartsWith() etc..
            // provides string manipulation methods
            // append(), insert(), remove(), replace(), clear()

            var builder = new StringBuilder();
            // or specify a starting string
            var builder1 = new StringBuilder("Hello World");
            builder.Append('-', 10); // repeat '-' 10 times
            builder.AppendLine(); // apends a new line
            builder.Append("Header");
            builder.AppendLine();
            builder.Append('-', 10);

            builder.Replace('-', '+');

            builder.Remove(0, 10); // removes first 10 characters

            builder.Insert(0, new string('-', 10));

            // you can use an indexer to access individual characters in the string builder (just like in a string)
            Console.WriteLine("First Char" + builder[0]);

            // NOTE: we can chain the Append methods since they return a NEW StringBuilder
            // so, lines 387 - 397 can be re-written as:
            builder1
                .Append('-', 10) // repeat '-' 10 times
                .AppendLine() // apends a new line
                .Append("Header")
                .AppendLine()
                .Append('-', 10)
                .Replace('-', '+')
                .Remove(0, 10) // removes first 10 characters
                .Insert(0, new string('-', 10));

            // procedural programming
            // a programming paradigm based on procedure (functions, methods, routines, subroutines) calls
            // always seperate the code that runs in the console from the code that implements some logic

            // WORKING WITH FILES

            // System.IO namespace - where classes for working with files and directories are located

            // File, FileInfo -> provides methods for creating, copying, deleting, moving and opening of files
            // both similar interfaces
            // DIFFERENCES
            // file - static methods - useful if you have few number of operations e.g. get attributes about a file
            // problem with static method: every time you call a static method, OS does some security checking to make sure user has access to the file
            // this will affect performance if you have large number of operations

            // FileInfo - instance methods - better for large operations
            // security checking is done only once during creation of a fileInfo object
            // METHODS -> Create, Copy, Delete, Exists, GetAttibutes, Move, ReadAllText

            // Directory, DirectoryInfo - similar to File, FileInfo but fir directories 
            // Directory - provides static methods
            // DirectoryInfo - provides instance methods
            // METHODS => CreateDirectory, Delete, Exists, GetCurrentDirectory, GetFiles, Move, GetLogicalDrives

            // Path -  provides methods to work with a string that contains a file or directory path information
            // METHODS - GetDirectoryName, GetFileName, GetExtension, GetTempPath

            // WORKING WITH FILES
            var path = @"C:\Users\Public\temp\mlh_tweet.png";
            var file_path = @"C:\Users\Public\text.txt";
            // File.Copy("C:\\Users\\Public\\mlh_tweet.png", "C:\\Users\\Public\\temp\\mlh_tweet.png", true);
            // or use a verbatim string so there would be no need for double backslashes
            File.Copy(@"C:\Users\Public\mlh_tweet.png", @"C:\Users\Public\temp\mlh_tweet.png", true);
            File.Delete(path);
            if (File.Exists(file_path))
            {
                Console.WriteLine("File exists");
                Console.WriteLine("Reading file....");
                Console.WriteLine();
                var text = File.ReadAllText(file_path);
                Console.WriteLine("Read result: " + text);
                // File.ReadAllBytes // <- to read file as a binary
            }
            else
            {
                Console.WriteLine("File doesn't exist");
            }
            // remember, fileInfo is better for large applications cause it provides instance methods as opposed to File which uses static methods
            var fileInfo = new FileInfo(file_path);
            // fileInfo.CopyTo();
            // fileInfo.Delete();
            // fileInfo.Exists();

            // DIRECTORIES
            Console.WriteLine("Creating directory...");
            Directory.CreateDirectory(@"C:\Users\Public\temp\folder2");
            Console.WriteLine("Directory created...");

            // var files = Directory.GetFiles(@"C:\Users\Public\temp\folder2", "*", SearchOption.AllDirectories);
            var directory_path = @"C:\Users\John Fiewor\OneDrive\Documents\Code";
            var files = Directory.GetFiles(directory_path, "*.js", SearchOption.AllDirectories);
            foreach (var file in files)
            {
                Console.WriteLine("File: " + file);
            }

            var directories = Directory.GetDirectories(directory_path, "*.*", SearchOption.AllDirectories);
            foreach (var directory in directories)
            {
                Console.WriteLine("directory: " + directory);
            }
            // Directory.Exists();

            // var directory = new DirectoryInfo(path);
            // directoryInfo.GetFiles();
            // directoryInfo.GetDirectories();

            // PATH CLASS
            // provides methods that make it easy to work with a string that represents a path and extract different parts of that path
            var new_path = @"";

            // get extension
            // poor way
            var dotIndex = new_path.IndexOf('.');
            var extension = new_path.Substring(dotIndex);
            Console.WriteLine(extension);

            // better way
            Console.WriteLine("Extension: " + Path.GetExtension(new_path));

            // other useful methods
            Console.WriteLine("File Name: " + Path.GetFileName(new_path));
            Console.WriteLine("File Name without extension: " + Path.GetFileNameWithoutExtension(new_path));
            Console.WriteLine("Directory Name: " + Path.GetDirectoryName(new_path));

            // DEBUGGING

            // debugging process
            // put one or more breakpoints in your code
            // run the app in debug mode
            // continue execution 
            // inspect values of different variables 

            // F10 - step over
            // F11 - step into
            // Shift + F11 - step into

            // F5 - run in debug mode
            // shift + F5 - stop the debug mode
            // ctrl + F5 - run without degbugging

            // F9 - insert breakpoint at current line

            // defensive programming - handling errors and edgecases preemptively by checking the input first before doing any processing
            // side effects make your methods unreliable and introduce hard-to-find bugs

            // watch - monitor specific values and how they change as the code runs

            // call stack - shows order in which calls are made including the respective methods that were called
            // auto window - like watch but with an automatic list of variables auto-detected by VS based on where you are in the code
            // local window - only shows variables in the local scope


            // CLASSES
            // Applications typically consist of multiple classes (building blocks) each responsible for a particular behaviour in the app

            // Sample blog post app
            // Layered architecture - consists of 3 layers:
            // Presentation (PostView class - responsible for displaying a post to a user )
            // Business Logic/Domain (Post class)
            // Data Access / Persistence (Post Repository - save/load to/from database)
            // we can have classes in each of these layers that would be responsible for particular tasks

            // anatomy
            // -> data - fields
            // -> behaviour - methods/functions

            // Unified Modelling Language (UML) - graphical language for communicating classes.
            // Consists of name of class, class fields, and class methods.

            // OBJECT is an instance of a class that resides in memory.
            // A class defines a blueprint from which you can create an object.

            // classes are named using Pascal Case (also used for parameters of methods)
            // the fields and methods of a class are the classes' MEMBERS

            // there are two types of class members
            // 1. instance: accessible from an object
            // Example:
            // var person = new Person();
            // person.Introduce();

            // 2. static: accessible from the class (not an object)
            // Example: Console.Writeline(); DateTime.Now();
            // use static members to represent concepts that are singleton i.e. we should have only one instance of that concept in the memory

            // var person = new Person();
            // var p = person.parse("John"); // returns a Person object

            // or Person person  = new Person
            // person.Name = "john";
            // person.Introduce("Jane");

            // when parse is declared as a static method, you no longer have to create a person object first in other to parse a stringvar
            // var person = Person.parse("John");
            // person.Introduce("John");


            // OBJECT INITIALIZERS
            // you use constructors to initialize an object and put it in an early state
            // there's another way to initalize an object - object initializer
            // object initializer is a syntax for quickly initializing an object without the need to call one of its constructors
            // useful to avoid creating multiple constructors

            // example of object initialization syntax:
            var person = new Person
            {
                FirstName = "John",
                LastName = "Fiewor"
            };

            // basically, you specify the name of the propertirs and assign them values
            // behind the scenes, the default/parameterless constructor is called and any property you set here is going to be initialized
            // so, this way ,you only use constructor when you really need to use them
        }

        // METHODS
        // a mthod with varying number of parameters using method overloading
        public class Calculator
        {
            // this is not an efficeient way to overload the Add method
            // public int Add(int n1, int n2) { }
            // public int Add(int n1, int n2, int n3) { }
            // public int Add(int n1, int n2, int n3, int n4) { }

            // a better way
            // public int Add(int[] numbers) { }
            // problem with this is that you would have to create an initialize an array anytime you want to pass a number of arguments to this method

            // much better way - params modifier
            // useful in situation where your method might need a varying number of parameters. makes it easier for the consumer of that method to call that method
            //public int Add(params int[] numbers) { }

        }

        // var result = calculator.Add(new int[] { 1, 2, 3, 4 }); // traditional form
        // thanks to params modifier in args() on line 611, you can use params modifier like done below:
        // var result = calculator.Add(1, 2, 3, 4); // you don't need to create and initialize an array when using params modifier
        // useful when your method might need a varying number of parameters

        // the ref modifier
        //public class MyClass
        //{
        //    //public void MyMethod(int a)
        //    public void MyMethod(ref int a)
        //    {
        //        a += 2;
        //    }
        //}

        // var a = 1;
        // MyClass.MyMethod(a);

        // the original 'a' variable won't be changed because the method will create and work on a local copy of 'a'

        // you can change this behaviour by adding 'ref' keyword before the parameters (line 624)
        // you can now use the method as shown below
        // MyClass.MyMethod(ref a);
        // in this case, the original 'a' will be passed to the method and hence be modified after returning from the method

        // the out modifier -> returns a value to the caller 
        // we can have mutliple parameters, and they all can return a value to the caller
        // this is a 'code smell' because if a method is to return mutliple values to the caller, it is better to encapsulate all these values into a specific class which could be the return type of that method

        // example of using the out modifier
        //public class MyClass
        //{
        //    public void MyMethod(out int result)
        //    {
        //        result = 1;
        //    }
        //}

        //int a;
        //myClass.MyMethod(out a);


    }
}
