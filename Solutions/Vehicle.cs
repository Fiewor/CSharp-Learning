public partial class Program
{
    public class Vehicle
    {
        private readonly string _registrationNumber;

        public Vehicle()
        {
            Console.WriteLine("Vehicle is being initialized, {0}", _registrationNumber);
        }

        public Vehicle(string registrationNumber)
        {
            _registrationNumber = registrationNumber;
        }
    }
}