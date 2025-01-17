﻿using Interfaces;

namespace Intefaces.UnitTests;

[TestClass]
public sealed class OrderPocessesTests
{
    [TestMethod]
    [ExpectedException(typeof(InvalidOperationException))]
    public void Process_OrderIsAlreadyExist_ThrowAnException()
    {
        var orderProcessor = new OrderProcessor(new FakeShippingCalculator());

        var order = new Order
        {
            Shipment = new Shipment()
        };

        orderProcessor.Process(order);
    }

    [TestMethod]
    public void Process_OrderIsNotShipped_ShouldSetTheShipmentPropertyOfTheOrder()
    {
        var orderProcessor = new OrderProcessor(new FakeShippingCalculator());

        var order = new Order();

        orderProcessor.Process(order);

        Assert.IsTrue(order.IsShipped);

        Assert.AreEqual(1, order.Shipment.Cost);

        Assert.AreEqual(DateTime.Today.AddDays(1), order.Shipment.ShippingDate);
    }

    public class FakeShippingCalculator : IShippingCalculator
    {
        public float CalculateShipping(Order order)
        {
            return 1;
        }
    }
}

