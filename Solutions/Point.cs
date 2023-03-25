public partial class Program
{
    //public class Person
    //{
    //    public string Name;
    //    public void Introduce(string to)
    //    {
    //        Console.WriteLine("Hi {0}, I am {1}", to, Name);
    //    }
    //}

    public class Point
    {
        public int X;
        public int Y;

        public Point(int x, int y)
        {
            this.X = x;
            this.Y = y;
        }

        // method to move the points to a different location
        public void Move(int x, int y)
        {
            this.X = x;
            this.Y = y;
        }

        // overloading
        public void Move(Point newLocation)
        {
            // validate the parameter and always thrw an exception if you get an unexpected parameter type
            if (newLocation == null)
                throw new ArgumentNullException("newLocation");

            Move(newLocation.X, newLocation.Y); // call the previous overload instead of repeating the same concept (in this case, setting X and Y)
            // this.X = newLocation.X;
            // this.Y = newLocation.Y;
        }
    }
}