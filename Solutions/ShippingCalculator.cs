public partial class Program
{
    public interface IShippingCalculator
    {
        float CalculateShipping(Order order);
    }

    public class ShippingCalculator : IShippingCalculator
    {
        public float CalculateShipping(Order order)
        {
            //if total cost of order is less $30, the shipping cost is going to be 10% of the total price of the order
            if (order.TotalPrice < 30f)
                return order.TotalPrice * 0.1f;
            // otherwise (total price is $30 or more), give free shipping to customers!
            return 0;
        }
    }
}