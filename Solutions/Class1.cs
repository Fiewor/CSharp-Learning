using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Solutions
{
    public class Person
    {
        public string Name;
        public void Introduce(string to)
        {
            Console.WriteLine("Hi {0}, I am {1}", to, Name);
        }
        public static Person Parse(string str)
        {
            var person = new Person();
            person.Name = str;

            return person;
        }
    }
    internal class Class1
    {
        //static void Main(string[] args)
        //{
            // var person = new Person();
            // var p = person.Parse("John"); // returns a Person object

            // or Person person  = new Person
            // person.Name = "john";
            // person.Introduce("Jane");

            // when parse is declared as a static method, you no longer have to create a person object first in other to parse a stringvar
            // var person = Person.parse("John");
            // person.Introduce("John");

            // Constructor - a method that's called when an instance of a class is created.
            // needed to put an object in an early state i.e. to initialize some of the fields in the class

            // constructor:
                // has the exact same name as the class (compulsory)
                // does not have a return type (not even void)
                // parameterless or default constructor - no parameters
                    // defined automatically by C# compiler if you don't explicitly create one (in the Intermediate Language - IL code) that will be resolved at the compilation
                    // doesn't do anything asides initilazing class fileds to default values:
                        // boolean - false
                        // numbers - 0
                        // strings or any other objects - null
                        // characters - empty characters
            // public class Customer
            // {
                // public string Name;
                // constructor
                // public Customer(string name) // get the name of the customer and set the name field (above) to that 
                // {
                    //this.Name = name;
                    // this references the current object
                // }
            // }
            // Customer customer = new Customer("John");

        // constructor overloading - having a method by the same name but different signatures (signature is what uniquely identifies a method i.e it's return type, name, the types and numbers of its parameters)
        // NOTE: you can't have two constructors with the exact same signature
        // constuctor overloading is used to make initialization of a class easier

        // Example:
        // public class Customer
        // {
            // public Customer () {}
            // public Customer (string name) {}
            // public Customer (int id, string name) {}
        // }
       // }
    }
}
