using DataApi.Model;
using DataApi.Model.Enums;
using NUnit.Framework;
using System;
using System.Collections.Generic;

namespace DataApi.Core.Test
{
    [TestFixture]
    public class OrderBookingManagerTest
    {
        private OrderBookingManager _orderBookingManager { get; set; }

        [SetUp]
        public void Init()
        {
            _orderBookingManager = new OrderBookingManager();
        }

        [TearDown]
        public void Dispose()
        {
            _orderBookingManager = null;
        }

        [TestCase("OPERATOR", 10.2, 100)]
        public void SendTest(string operatorName, double price, int quantity)
        {
            Trade trade = new Trade()
            {
                Id = Guid.NewGuid(),
                OperatorName = operatorName,
                Price = price,
                Quantity = quantity,
                Underlyings = new List<Underlying>
                {
                    new Underlying() {
                        SourceType = EnumUnderlyingSourceType.BLOOMBERG,
                        Code = "FP FP",
                        ProductType = EnumUnderlyingProductType.STOCK },
                    new Underlying() { SourceType = EnumUnderlyingSourceType.REUTERS,
                        Code = "BNPP.PA",
                        ProductType = EnumUnderlyingProductType.STOCK }
                },
                AdditionnalInfos = new string[2] { "Foo", "Bar" }
            };

            var actual = _orderBookingManager.Send(trade);
            Assert.IsInstanceOf(typeof(string), actual);
            Assert.IsNotNull(actual);

            System.Diagnostics.Debug.Print(actual);
        }
    }
}
