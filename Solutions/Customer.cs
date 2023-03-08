namespace Solutions
{
    public class Customer
    {
        public int Id;
        public string Name;
        public List<Program.Order> Orders;
        // use ctor to get snippet for constructor
        public Customer()
        {
            // best practice: when you have a class, and that class has a list of objects of any type, always initialize that list to an empty list
            Orders = new List<Program.Order>();
        }

        public Customer(int id)
            // the Orders field is not initialized in this constructor. (it would be auto-set to null)
            // instead of manually defining it here again as done in previous constructor, use the this keeyword like done below:
            : this()
        // what line 24 does is that when the constructor is called, first it calls the constructor without parameters which would initialize the Orders field and then we get into the current constructor proper
        {
            this.Id = id;
        }

        public Customer(int id, string name)
            : this(id)
        // this(id) calls the constructor with the id parameter upon intialization
        {
            // this.Id = Id;
            this.Name = name;
        }

        // so, we can use the this keyword to specify any of the other constructors we would like to pass the control to

        // in general, this is not considered a good practice because it makes the control flow complicated

        // only define a constructor when you REALLY have to initialize some fields of your class
    }
}
