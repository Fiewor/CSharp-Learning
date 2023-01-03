public class Program
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

    // STRINGS
    public static void ExerciseD1()
    {
        Console.WriteLine("Enter numbers seperated by hyphen");
        var input = Console.ReadLine();
        if (input == null) return;
        var arr = input.Split('-');
        for (int i = 0; i < arr.Length - 1; i++)
        {
            var curr = Convert.ToInt32(arr[i]);
            var next = Convert.ToInt32(arr[i + 1]);
            var diff = curr - next;
            if (diff == -1 || diff == 1)
                continue;
            else
            {
                Console.WriteLine("Not Consecutive");
                return;
            }
        }
        Console.WriteLine("Consecutive");
    }

    public static void ExerciseD2()
    {
        Console.WriteLine("Enter numbers seperated by hyphen e.g. 1-2-3-4");
        var input = Console.ReadLine();
        if (String.IsNullOrWhiteSpace(input)) return;

        var numbers = input.Split('-');
        foreach (var num in numbers)
        {
            if (Array.IndexOf(numbers, num) != Array.LastIndexOf(numbers, num))
            {
                Console.WriteLine("Duplicate");
                return;
            }
        }
        Console.WriteLine("No Duplicate"); // wasn't part of the exercise
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
        var arr = input.Split(":");
        if (arr.Length != 2)
        {
            Console.WriteLine("Invalid Time");
            return;
        }
        var hours = Convert.ToInt32(arr[0]);
        var minutes = Convert.ToInt32(arr[1]);
        if (hours >= 0 && hours <= 23 && minutes >= 0 && minutes <= 59)
            Console.WriteLine("Ok");
        else
            Console.WriteLine("Invalid Time");
    }

    public static void ExerciseD4()
    {
        Console.WriteLine("Enter a few words separated by a space");
        var input = Console.ReadLine();
        if (String.IsNullOrWhiteSpace(input)) return;

        var words = input.Split(" ");
        var pascalized = "";
        foreach (var word in words)
        {
            var firstUpper = char.ToUpper(word[0]) + word.ToLower().Substring(1);
            pascalized += firstUpper;
        }
        Console.WriteLine(pascalized);

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
        // var vowels = "aeiou";
        // or use a char list instead of a string
        var vowels = new List<char>(new char[] { 'a', 'e', 'i', 'o', 'u' });
        var word = input.ToLower();
        var vowelCount = 0;
        foreach (var letter in word)
        {
            if (vowels.Contains(letter))
                vowelCount++;
        }
        Console.WriteLine(vowelCount);
    }
    private static void Main(string[] args)
    {
        ExerciseD5();
    }
}