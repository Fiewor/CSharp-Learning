﻿using System.Net.NetworkInformation;

public static class StringExtensions
{
    public static string Shorten(this String str, int numberOfWords)
    {
        if (numberOfWords < 0)
            throw new ArgumentOutOfRangeException("numberOfWords should be greater than or equal to 0.");
        if (numberOfWords == 0) return "";
        var words = str.Split(' ');
        if (words.Length < numberOfWords) return str;

        return String.Join(" ", words.Take(numberOfWords)) + "..."; // take is an extension method that can be applied on any class that inmplements IEnumerabele interface (in this case, the string array)
    }
}

public partial class Program
{

    public static void Exercise1()
    {
        Console.WriteLine("Type a number between 1 and 10");
        int number = Convert.ToInt32(Console.ReadLine());
        string result = number >= 1 && number <= 10 ? "Valid" : "Invalid";
        Console.WriteLine(result);
    }

    public static void Exercise2()
    {
        Console.WriteLine("Type first number");
        var num1 = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Type second number");
        var num2 = Convert.ToInt32(Console.ReadLine());
        var result = num1 > num2 ? num1 : num2;
        Console.WriteLine(string.Format("Maximum number: {0}", result));
    }

    public static void Exercise3()
    {
        // Landscape or Potrait
        Console.WriteLine("Input width: ");
        var width = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Input height: ");
        var height = Convert.ToInt32(Console.ReadLine());
        var result = width > height ? ImageOrientation.Landscape : ImageOrientation.Portrait;
    }
    public enum ImageOrientation
    {
        Landscape,
        Portrait
    }

    public static void Exercise4()
    {
        // speed camera
        Console.WriteLine("Enter speed limit: ");
        var limit = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Enter the speed of a car: ");
        var carSpeed = Convert.ToInt32(Console.ReadLine());
        var demeritPoints = 0;

        if (carSpeed < limit)
        {
            Console.WriteLine("Ok");
        }
        else
        {

            // my solution for the demerit points -  wrong idea
            while (carSpeed >= 5)
            {
                demeritPoints++;
                carSpeed -= 5;
            }
            if (demeritPoints > 12)
                Console.WriteLine("License Suspended");
            Console.WriteLine("Demerit points: " + demeritPoints);

            // right idea
            // const int kmPerDemeritPoint = 5;
            // var demeritPoints = (carSpeed - speedLimit) / kmPerDemeritPoint;
            // if (demeritPoints > 12)
            //     Console.WriteLine("License Suspended");
            // else
            //     Console.WriteLine("Demerit points: " + demeritPoints);
        }
    }

    public static void Exercise5()
    {
        var count = 0;
        for (int i = 1; i < 100; i++)
        {
            if (i % 3 == 0) count++;
        }
        Console.WriteLine("Total count of numbers between 1 and 100 that are divisible by 3 are: " + count);
    }

    public static void Exercise6()
    {
        var sum = 0;
        while (true)
        {
            Console.WriteLine("Enter a number. Type 'ok' to exit");
            var res = Console.ReadLine();
            if (res.ToLower() == "ok")
                break;
            sum++;
        }
        Console.WriteLine("sum is: " + sum);
    }

    public static void Exercise7()
    {
        Console.WriteLine("Enter a number: ");
        var num = Convert.ToInt32(Console.ReadLine());
        var fact = 1;
        for (int i = num; i > 0; i--)
        {
            fact *= i;
        }
        Console.WriteLine(string.Format("Factorial of {0} is {1}", num, fact));
    }

    public static void Exercise8()
    {
        var random = new Random();
        var rand = random.Next(1, 11);

        for (int i = 0; i < 4; i++)
        {
            Console.WriteLine("Guess the secret number");
            var guess = Convert.ToInt32(Console.ReadLine());

            if (guess == rand)
            {
                Console.WriteLine(string.Format("You won. The secret number was {0} and you guessed {1} correctly!", rand, guess));
                return;
            }
        }
        Console.WriteLine(string.Format("You lost. The secret number was {0}", rand));
    }

    public static void Exercise9()
    {
        Console.WriteLine("Enter a series of numbers. Seperate each number with a comma");
        var str = Console.ReadLine();
        string[] arr = str.Split(',');
        var max = Convert.ToInt32(arr[0]);
        // for (int i = 0; i < arr.Length; i++)
        // {
        //     var num = Convert.ToInt32(arr[i]);
        //     if (num > max) 
        //         max = num;
        // }
        foreach (var stri in arr)
        {
            var num = Convert.ToInt32(stri);
            if (num > max)
                max = num;
        }
        Console.WriteLine("Max is: " + max);
    }

    // arrays and lists exercises
    public static void ExerciseC1()
    {
        var friends = new List<string>();
        while (true)
        {
            Console.WriteLine("Enter a name");
            var str = Console.ReadLine();

            if (str == "")
                break;
            friends.Add(str);
        }
        if (friends.Count > 2)
            Console.WriteLine(string.Format("{0}, {1} and {2} others like your post", friends[0], friends[1], friends.Count - 2));
        if (friends.Count == 2)
            Console.WriteLine(string.Format("{0} and {1} like your post", friends[0], friends[1]));
        if (friends.Count == 1)
            Console.WriteLine(string.Format("{0} likes your post", friends[0]));
    }

    public static void ExerciseC2()
    {
        Console.WriteLine("enter your name: ");
        var name = Console.ReadLine();
        var chara = new char[name.Length];
        // test = "this is a test".Select(x => x.ToString()).ToArray();
        for (var i = name.Length; i > 0; i--)
        {
            chara[name.Length - i] = name[i - 1];
        }
        Console.WriteLine(new string(chara));
    }

    public static void ExerciseC3()
    {
        var numbs = new List<int>();
        while (numbs.Count < 5)
        {
            Console.WriteLine(string.Format("Enter {0} numbers", 5 - numbs.Count));
            var num = Convert.ToInt32(Console.ReadLine());
            if (numbs.Contains(num))
            {
                Console.WriteLine("Number has been entered previously. Try again");
                continue;
            }
            else
            {
                numbs.Add(num);
            }
        };
        numbs.Sort();
        foreach (var number in numbs)
            Console.WriteLine(number);
    }

    public static void ExerciseC4()
    {
        var numbers = new List<int>();
        while (true)
        {
            Console.WriteLine("Enter a number or type 'Quit' to exit");
            var input = Console.ReadLine();
            if (input.ToLower() == "quit") break;

            numbers.Add(Convert.ToInt32(input));
        }

        var unique = new List<int>();
        foreach (var el in numbers)
        {
            if (!unique.Contains(el))
                unique.Add(el);
        }

        Console.WriteLine("The unique elements are: ");
        foreach (var item in unique)
            Console.WriteLine(item);
    }

    public static void ExerciseC5()
    {

        string[] elements;
        while (true)
        {
            Console.WriteLine("Enter comma separated numbers: ");
            var str = Console.ReadLine();

            if (!String.IsNullOrWhiteSpace(str))
            {
                elements = str.Split(',');
                if (elements.Length >= 5)
                    break;
            }

            Console.WriteLine("Invalid List. Re-try");
        }

        var numbers = new List<int>();

        foreach (var item in elements)
            numbers.Add(Convert.ToInt32(item));

        numbers.Sort();

        Console.WriteLine("The 3 smallest numbers are: ");
        for (int i = 0; i < 3; i++)
        {
            Console.WriteLine(numbers[i]);
        }
    }

    public static string IsConsecutive(string[] arr)
    {
        for (int i = 0; i < arr.Length - 1; i++)
        {
            var curr = Convert.ToInt32(arr[i]);
            var next = Convert.ToInt32(arr[i + 1]);
            var diff = curr - next;
            if (diff == -1 || diff == 1)
                continue;
            else
                return "Not Consecutive";
        }
        return "Consecutive";
    }

    // STRINGS
    public static void ExerciseD1()
    {
        Console.WriteLine("Enter numbers seperated by hyphen");
        var input = Console.ReadLine();

        if (String.IsNullOrWhiteSpace(input)) return;

        var arr = input.Split('-');
        Console.WriteLine(IsConsecutive(arr));
    }

    public static string ContainsDuplicate(string[] numbers)
    {
        foreach (var num in numbers)
        {
            if (Array.IndexOf(numbers, num) != Array.LastIndexOf(numbers, num))
                return "Duplicate";
        }
        return "No Duplicate";
    }

    public static void ExerciseD2()
    {
        Console.WriteLine("Enter numbers seperated by hyphen e.g. 1-2-3-4");
        var input = Console.ReadLine();
        if (String.IsNullOrWhiteSpace(input)) return;

        var numbers = input.Split('-');
        Console.WriteLine(ContainsDuplicate(numbers));
    }

    public static string IsValidTime(string time)
    {
        var arr = time.Split(":");
        if (arr.Length != 2)
        {
            return "Invalid Time";
        }
        var hours = Convert.ToInt32(arr[0]);
        var minutes = Convert.ToInt32(arr[1]);
        if (hours >= 0 && hours <= 23 && minutes >= 0 && minutes <= 59)
            return "Ok";
        else
            return "Invalid Time";
    }

    public static void ExerciseD3()
    {
        Console.WriteLine("Enter a time value in the 24-hour time format (e.g. 19:00)");
        var input = Console.ReadLine();
        if (String.IsNullOrEmpty(input))
        {
            Console.WriteLine("Invalid Time");
            return;
        }
        Console.WriteLine(IsValidTime(input));
    }

    public static string ConvertToPascalCase(string input)
    {
        var words = input.Split(" ");
        var res = "";
        foreach (var word in words)
        {
            var firstUpper = char.ToUpper(word[0]) + word.ToLower().Substring(1);
            res += firstUpper;
        }
        return res;
    }

    public static void ExerciseD4()
    {
        Console.WriteLine("Enter a few words separated by a space");
        var input = Console.ReadLine();
        if (String.IsNullOrWhiteSpace(input)) return;

        Console.WriteLine(ConvertToPascalCase(input));
    }

    public static int VowelCount(string word)
    {
        // var vowels = "aeiou";
        // or use a char list instead of a string
        var vowels = new List<char>(new char[] { 'a', 'e', 'i', 'o', 'u' });
        var count = 0;
        foreach (var letter in word)
        {
            if (vowels.Contains(letter))
                count++;
        }
        return count;
    }

    public static void ExerciseD5()
    {
        Console.WriteLine("Enter an English word");
        var input = Console.ReadLine();
        if (String.IsNullOrWhiteSpace(input))
        {
            Console.WriteLine("Error");
            return;
        }
        var word = input.ToLower();
        Console.WriteLine(VowelCount(word));
    }

    public static List<int> GetSmallests(List<int> list, int count)
    {
        if (list == null)
            throw new ArgumentNullException("list");
        if (count > list.Count || count <= 0)
            throw new ArgumentOutOfRangeException("count", "Count should be between 1 and the number of elements in the list.");

        var buffer = new List<int>(list);
        var smallests = new List<int>();

        while (smallests.Count < count)
        {
            var min = GetSmallest(buffer);
            smallests.Add(min);
            buffer.Remove(min);
        }
        return smallests;
    }

    public static int GetSmallest(List<int> list)
    {
        var min = list[0];
        for (int i = 0; i < list.Count; i++)
        {
            if (list[i] < min)
                min = list[i];
        }
        return min;
    }

    //public class Customer
    //{
    //    public int Id;
    //    public string Name;
    //    public readonly List<Order> Orders = new List<Order>();

    //    public Customer(int id)
    //    {
    //        this.Id = id;
    //    }

    //    public Customer(int id, string name)
    //        : this(id)
    //    {
    //        this.Name = name;
    //    }

    //    public void Promote()
    //    {
    //        // ...
    //    }
    //}

    public class Person
    {
        // put all auto-implemented properties at the top
        // followed by the constructors
        // then the calculated properties at the bottom


        //private DateTime _birthdate;
        //public void SetBirthDate(DateTime birthdate)
        //{
        //    this._birthdate = birthdate;
        //}
        //public DateTime GetBirthDate()
        //{
        //    return this._birthdate;
        //}

        public string Name { get; set; }
        public string Username { get; set; }

        // the BirthDate property below is an auto-implemented property
        public DateTime BirthDate { get; private set; } // adding 'private' to the set property makes it so we can only set the birthdate once and it can't be changed
        // it can only be changed now via a constructor

        public Person(DateTime birthdate)
        {
            BirthDate = birthdate;
        }

        public int Age
        {
            get
            {
                var timeSpan = DateTime.Today - BirthDate;
                var years = timeSpan.Days / 365;

                return years;
            }
        }
    }

    static void RemoveRedEyeFilter(Photo photo)
    {
        Console.WriteLine("Apply RemoveRedEye");
    }

    // example of predicate method
    static bool IsCheaperThan10Dollars(Book book)
    {
        return book.Price < 10;
    }

    public static int MaxLevelSum(TreeNode root)
    {
        Queue<TreeNode> q = new Queue<TreeNode>();
        q.Enqueue(root);
        int level = 1, maxLevel = 1, maxSum = int.MaxValue;

        while (q.Count > 0)
        {
            TreeNode node = q.Dequeue();
            int nodeSize = q.Count, levelSum = 0;

            for (int i = 0; i < nodeSize; i++)
            {
                levelSum += node.val;

                if (node.left != null) q.Enqueue(node.left);
                if (node.right != null) q.Enqueue(node.right);
            }
            if (levelSum > maxSum)
            {
                (maxSum, maxLevel) = (levelSum, level);
            }
            level++;
        }
        return maxLevel;
    }

    public class Video
    {
        public string Title { get; set; }
    }

    private static void Main(string[] args)
    {
        // ------- extension methods ------- //
        string post = "This is a supposedly long blog post about me and you and me and you and me...";
        var shortenedPost = post.Shorten(5);

        IEnumerable<int> numbers = new List<int>() { 1, 5, 3, 10, 2, 18 } ;
        var max = numbers.Max();

        Console.WriteLine(max);

        // ------- events and delegates --------- //
        //var video = new Video() { Title = "Video 1" };
        //var videoEncoder = new VideoEncoder(); // publisher
        //// now we need to subscribe this mail service to the VideoEncoded event of the VideoEncoder
        //var mailService = new MailService(); // subscriber
        //var messageService = new MessageService(); // new subscriber

        //// do the subscription
        //videoEncoder.VideoEncoded += mailService.OnVideoEncoded; // register an handler for that event 
        //// the handler is that method in the MailService

        //// Behind the scene, VideoEncoded is a list of pointers to methods.
        //// when the VideoEncoded wants to publish an event, it looks at that list (VideoEncoder.cs, line 24), and if it's not empty, that means someone has subscribed to that event, which means we have a pointer to an event handler method and we'll cal it (VideoEncoder.cs, line 25)

        //videoEncoder.VideoEncoded += messageService.OnVideoEncoded;

        //// note that we need to do the subscription before calling the Encode method, otherwise the subscriber will not be notified about the event
        //videoEncoder.Encode(video);




        //TreeNode root = new TreeNode(1);
        //root.left = new TreeNode(7);
        //root.right = new TreeNode(0);
        //root.left.left = new TreeNode(7);
        //root.left.right = new TreeNode(-8);

        //// Call the MaxLevelSum function
        //int maxSumLevel = MaxLevelSum(root);
        //Console.WriteLine(maxSumLevel);
        // ------- lambda expressions --------
        //() => ... // no argument
        //x => ... // one argument
        //(x, y, z) => ... // multiple arguments
        //Func<int, int> square = number => number * number;
        // lambda expression has access to all the args passed as well as any variables defined in the method where it(the lambda expression) is defined
        //Console.WriteLine(square(5));

        //const int factor = 5;

        //Func<int, int> multiplier = n => n * factor;

        //var result = multiplier(10);

        //Console.WriteLine(result);

        //var books = new BookRepository().GetBooks();

        ////var cheapBooks = books.FindAll(IsCheaperThan10Dollars); // using a method
        //var cheapBooks = books.FindAll(book => book.Price < 10); // using a lambda expression

        //foreach (var book in cheapBooks)
        //{
        //    Console.WriteLine(book.Title);
        //}

        // ------- delegates --------

        //var processor = new PhotoProcesssor();
        //var filters = new PhotoFilters();
        ////PhotoProcesssor.PhotoFilterHandler filterHandler = filters.ApplyBrightness; // - using a custom delegate
        //Action<Photo> filterHandler = filters.ApplyBrightness; // using the action delegate that comes with .NET
        //filterHandler += filters.ApplyContrast; // adding another filter (really, adding another pointer)
        //filterHandler += RemoveRedEyeFilter;
        //// because we're appending multiple function pointers to our delegate, our delegate is a multicast delegate

        //processor.Process("photo.jpg", filterHandler);

        // ------- generics --------
        //! note that Nullable class already exists under System namespace -> System.Nullable
        //var number = new Nullable<int>();
        //Console.WriteLine("Has Value ? " + number.HasValue);
        //Console.WriteLine("Value: " + number.GetValueOrDefault());

        //var numbers = new GenericList<int>();
        //numbers.Add(10);

        //var books = new GenericList<Book>();
        //books.Add(new Book());

        //var dictionary = new GenericDictionary<string, Book>();
        //dictionary.Add('1234', new Book());

        // ------- interfaces exercise -------
        //var workflow = new WorkFlow();
        //workflow.AddActivityToWorkflow(new VideoUploadActivity());
        //workflow.AddActivityToWorkflow(new ChangeStatusOfVideoRecordActivity());
        //var workflowengine = new WorkFlowEngine();
        //workflowengine.Run(workflow);

        //// ------- interfaces and polymorphism
        //var encoder = new VideoEncoder();
        //encoder.RegisterNotificationChannel(new MailNotificationChannel()); // <- here we register the concrete classes
        //encoder.RegisterNotificationChannel(new SMSNotificationChannel());
        //encoder.Encode(new VideoEncoder());

        // ------- interfaces and extensibility -------
        //var dbMigrator = new DbMigrator(new FileLogger("C:\\Users\\John Fiewor\\OneDrive\\Documents\\log.txt"));

        //var dbMigrator = new DbMigrator(new ConsoleLogger()); // <- in the constructor of DbMigrator, we specified ConsoleLogger which is a concrete implementation of ILogger
        //dbMigrator.Migrate();


        // ------- interfaces and testability -------
        //var orderProcessor =  new OrderProcessor(); // <- OrderProcessor now takes an argument - an instance of IShippingCalculator
        //var orderProcessor =  new OrderProcessor(new ShippingCalculator());
        //var order = new Order { DatePlaced = DateTime.Now, TotalPrice = 100f };
        //orderProcessor.Process(order);

        // ------- testing polymorphism exercises solution --------
        //var sqlConnection = new SqlConnection("sql connection string");
        //var oracleConnection = new OracleConnection("oracle connection string");
        //var dbCommand = new DbCommand("open", sqlConnection);
        //dbCommand.Execute();

        //var shapes = new List<Shape>();
        //shapes.Add(new Shape());
        //shapes.Add(new Rectangle());

        //var canvas = new Canvas();
        //canvas.DrawShapes(shapes);


        //code test for stack
        //var stack = new Stack();
        //stack.Push(1);
        //stack.Push(2);
        //stack.Push(3);
        //Console.WriteLine(stack.Pop());
        //Console.WriteLine(stack.Pop());
        //Console.WriteLine(stack.Pop());

        // Car car = new Car("ansdfondfpanif20932");


        //var customer = new Customer();
        //var dbMigrator = new DbMigrator(new Logger());

        //var logger = new Logger();
        //var installer = new Installer(logger);

        //dbMigrator.Migrate();

        //installer.Install();

        //------- testing inheritance example -------
        //var text = new Text();
        //text.Width = 100;
        //text.Copy();

        //------- test post class implementation -------
        //var post = new Post();
        //post.UpVote();
        //post.UpVote();
        //post.UpVote();
        //post.UpVote();
        //post.DownVote();
        //Console.WriteLine("Current vote value: {0}", post.Vote);

        //------- test stopwatch class implementation -------
        //try
        //{
        //    var stopwatch = new Stopwatch();
        //    stopwatch.Start();
        //    stopwatch.Start();
        //    for (int i = 0; i < 10000000; i++){}
        //    stopwatch.Stop();
        //    Console.WriteLine("Duration is {0}", stopwatch.Duration);
        //}
        //catch (Exception)
        //{
        //    Console.WriteLine("An error occured");
        //}

        //var person = new Person(new DateTime(1998, 10, 27));
        //Console.WriteLine(person.Age);

        //var cookie = new HttpCookie();
        //cookie["name"] = "Mosh";
        //Console.WriteLine(cookie["name"]); ;


        //var person = new Person();
        //person.SetBirthDate(new DateTime(1982, 1, 1));
        //Console.WriteLine(person.GetBirthDate());
        // var numbers = new List<int> { 1, 2, 3, 4, 5 };
        // var smallests = GetSmallests(numbers, 3);
        // foreach (var number in smallests)
        //      Console.WriteLine(number); 

        //var customer = new Customer(1, "John");
        //Console.WriteLine(customer.Id);
        //Console.WriteLine(customer.Name);

        //var order = new Order();
        //customer.Orders.Add(order);

        // var person = new Person();
        // person.Name = "John";
        // person.Introduce("Mosh");


        //var num = int.Parse("abc"); // throws a FormatExcetion
        // use a try/catch block to handle exception if using the Parse() method

        //int number;
        //var result = int.TryParse("abc", out number); // TryParse() does not throw an exception unlike Parse()
        //// instead it returns a boolean showing whether the conversion was successful or not
        //if(result)
        //    Console.WriteLine(number);
        //else
        //    Console.WriteLine("Conversion failed.");

        //var customer = new Customer(1);
        //customer.Orders.Add(new Order());
        //customer.Orders.Add(new Order());

        //customer.Promote();

        //Console.WriteLine(customer.Orders.Count);
    }

    static void UseParams()
    {
        var calculator = new Calculator();
        Console.WriteLine(calculator.Add(1, 1, 2));
        Console.WriteLine(calculator.Add(new int[] { 1, 2, 3, 4, 5 }));
    }

    static void UsePoints()
    {
        // adding a global exception handling mechanism
        // this is better cause the application won't crash in this case
        // instead it just returns a friendly error
        try
        {
            var point = new Point(10, 30);
            point.Move(null);
            Console.WriteLine("Point is at ({0}, {1})", point.X, point.Y);

            point.Move(100, 200);
            Console.WriteLine("Point is at ({0}, {1})", point.X, point.Y);
        }
        catch (Exception)
        {
            Console.WriteLine("An unexpected error occured");
        }

        //var point = new Point(10, 20);
        //point.Move(new Point(40, 60)); // second overload
        //Console.WriteLine("Point is at {0} and {1}", point.X, point.Y);

        //point.Move(100, 200); // first overload
        //Console.WriteLine("Point is at {0} and {1}", point.X, point.Y);
    }
}