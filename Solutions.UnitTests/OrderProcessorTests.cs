using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace Solutions.UnitTests
{
    [TestClass]
    public class OrderProcessorTests
    {
        // method naming convention -> METHODNAME_CONDITION_EXPECTATION
        [ExpectedException(typeof(InvalidOperationException))]
        [TestMethod]
        public void Process_OrderIsAlreadyShipped_ThrowsAnException()
        {
            var orderProcessor = new OrderProcessor(new FakeShippingCalculator());
            var order = new Order
            {
                Shipment = new Shipment()
            };
            orderProcessor.Process(order);
        }

        [TestMethod]
        public void Process_OrderIsNotShipped_SholdSetTheShipmentPropertyOfTheOrder()
        {
            var orderProcessor = new OrderProcessor(new FakeShippingCalculator());
            var order = new Order();

            orderProcessor.Process(order);

            Assert.IsTrue(order.IsShipped)+++++++
            Assert.AreEqual(1, order.Shipment.Cost);
            Assert.AreEqual(DateTime.Today.AddDays(1), order.Shipment.Shipment.ShippingDate);
        }
    }

    // we need to pass an arument to OrderProcessor which is the IShippingCalculator
    // because we need an object that's always working, we're not going to pass the original ShippingCalculator - cause we're trying to isolate that OrderProcessor
    // so we'll create a FakeShippingCalculator

    public class FakeShippingCalculator : IShippingCalculator
    {
        public float CalculateShipping(OrderProcessorTests order)
        {
            return 1; // <- returning 1 because we don't want to have logic. we're assuming this fake class is doing it's job properly and focus on testing OrderProcessor
        }

    }
}
