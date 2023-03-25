public partial class Program
{
    public class OrderProcessor
    {
        //private readonly ShippingCalculator _shippingCalculator; // <- changing this reference to the ShippingCalculator to the below code to remove the tight coupling by instead using an interface
        private readonly IShippingCalculator _shippingCalculator;
        //public OrderProcessor() // <- modifying the constructor to pass in the interface
        public OrderProcessor(IShippingCalculator shippingcalculator)
        {
            //_shippingCalculator = new ShippingCalculator(); // <- instead of instantiating the ShippingCalculator class, now use the (interface) argument passed to the constructor. this removes the dependence on the complete ShippingCalculator class
            _shippingCalculator = shippingcalculator;

            // now there is no reference to the ShippingCalculator class, we're now just using an interface.
            // this is an example of loose coupling
            // so any changes in the code in ShippingClass won't affect the OrderProcessor class
        }
        public void Process(Order order)
        {
            //remember defensive programming - ensure arg is indexer valid state
            if (order.IsShipped)
                throw new InvalidOperationException("This order is already processed.");

            order.Shipment = new Shipment
            {
                Cost = _shippingCalculator.CalculateShipping(order),
                ShippingDate = DateTime.Today.AddDays(1)
            };
        }   
    }
}