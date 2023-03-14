using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Amazon
{
    public class Customer
    {
        public int id { get; set; }
        public string Name { get; set; }

        public void Promote()
        {
            //var rating = CalculateRating(excludeOrders: true);
            //if (rating == 0)
            //    Console.WriteLine("Promoted to level 1");
            //else
            //    Console.WriteLine("Promoted to level 2");

            var calculator = new RateCalculator(); // it's not a good practice to instanitate a new object like the RateCalculator inside the method here because this creates coupling or dependency to this object
            var rating = calculator.Calculate(this);

            Console.WriteLine("Promote logic changed.");
        }

        protected int CalculateRating(bool excludeOrders)
        {
            return 0;
        }
    }
}
