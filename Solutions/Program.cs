public class Program
{

    public static void Exercise1()
    {
        Console.WriteLine("Type a number between 1 and 10");
        int number = Convert.ToInt32(Console.ReadLine());
        string result = number >= 1 && number <= 10 ? "Valid" : "Invalid";
        Console.WriteLine(result);
    }

    public static void Exercise2() {
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

    public static void Exercise7() {
        Console.WriteLine("Enter a number: ");
        var num = Convert.ToInt32(Console.ReadLine());
        var fact = 1;
        for(int i = num; i > 0; i--)
        {
            fact *= i;
        }
        Console.WriteLine(string.Format("Factorial of {0} is {1}", num, fact));
    }

    public static void Exercise8() { 
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

    private static void Main(string[] args)
    {
        Exercise9();
    }
}