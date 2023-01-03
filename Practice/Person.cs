namespace Practice
{

    // can't create a class inside the Main methos cause it's a function/method
    // so you create a class at the namespace level
    public class Person
    {
        public string? FirstName;
        public string? LastName;

        public void Introduce()
        {
            // Console.WriteLine("My name is " + FirstName + " " + LastName);
        }
    }

    class Program1
    {
        static void Main(string[] args)
        {
            Person john = new Person();
            john.FirstName = "John";
            john.LastName = "Fiewor";
            // john.Introduce();

            // Calculator calculator = new Calculator();


            // var result = calculator.Add(1, 2);
            int num1 = Convert.ToInt32(Console.ReadLine());
            string result = num1 >= 1 && num1 <= 10 ? "Valid" : "Invalid";
            Console.WriteLine(result);
        }
    }
}