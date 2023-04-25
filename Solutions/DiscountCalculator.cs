public partial class Program
{
    // example of creating a constraint to a class (in generics)
    // we're basically saying TProduct (the generic type passed to DiscountCalculator) should be a product or any of it's subclasses
    // so we now have access to all of Product's properties or methods.
    public class DiscountCalculator<TProduct> where TProduct : Product
    {
        public float CalulateDiscount(TProduct product)
        {
            return product.Price;

        }
    }
}
