public partial class Program
{
    public class Car : Vehicle
    {
        public Car()
        {
            Console.WriteLine("Car is being initialized");
        }
        public Car(string registrationNumber)
            : base(registrationNumber) // a way to access the base class
        {
            // initialise fields specific to the Car class
            Console.WriteLine("Car is being initialized, {0}", registrationNumber);
        }
    }
}