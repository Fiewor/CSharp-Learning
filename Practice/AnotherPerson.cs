namespace Practice
{
    public class AnotherPerson
    {
        public int age;
    }
    class Program
    {
        static void Main(string[] args)
        {
            var number = 1;
            Increment(number);
            // Console.WriteLine(number); // results in 1

            var person = new Person() { Age = 20 };
            // this person and the person we have as a parameter to the MakeOld will be pointing to the same object on the heap
            // that is because the type of the MakeOld method parameter is a reference type
            // Console.WriteLine(person.Age);
        }

        public static void Increment(int number)
        {
            number += 10;
        }
        public static void MakeOld(Person person)
        {
            person.Age += 10;
        }
    }
}
