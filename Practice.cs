using System;

public class Class1
{
    // can't create a class inside the Main methos cause it's a function/method
    // so you create a class at the namespace level
    public class Person
    {
        public string FirstName;
        public string LastName;

        public voud Introduce()
        {
            global::System.Console.WriteLine("My name is " + FirstName + " " + LastName);
        }
    }
    public Class1() 
	{
	
        static void Main(string[] args)
        {
            Person john = new Person(); 
            john.FirstName = "John";
            john.LastName = "Fiewor";
            john.Introduce();
        }
}
