using DataApi.XLAddin.COM.Classes;
using DataApi.XLAddin.COM.Model;
using DataApi.XLAddin.COM.Model.Enums;
using NUnit.Framework;

namespace DataApi.XLAddin.Test
{
    [TestFixture]
    public class COMOrderBookingManagerTest
    {
        private COMOrderBookingManager _comOrderBookingManager { get; set; }

        [SetUp]
        public void Init()
        {
            _comOrderBookingManager = new COMOrderBookingManager();
        }

        [TearDown]
        public void Dispose()
        {
            _comOrderBookingManager = null;
        }


        [TestCase("OPERATOR", 10.2, 100)]
        public void Send(string operatorName, double price, int quantity)
        {
            COMUnderlyingInfos underlyingInfos = new COMUnderlyingInfos();
            underlyingInfos.Add(
                new COMUnderlying()
                {
                    SourceType = COMEnumUnderlyingSourceType.REUTERS,
                    ProductType = COMEnumUnderlyingProductType.STOCK,
                    Code = "BHP.AX"
                });

            underlyingInfos.Add(
                new COMUnderlying()
                {
                    SourceType = COMEnumUnderlyingSourceType.BLOOMBERG,
                    ProductType = COMEnumUnderlyingProductType.INDEX,
                    Code = "SX5E"
                });

            COMTrade comTrade = new COMTrade()
            {
                OperatorName = operatorName,
                Price = price,
                Quantity = quantity,
                UnderlyingInfos = underlyingInfos,
                AdditionnalInfos = new string[2] { "Foo", "Bar" }
            };

            var actual = _comOrderBookingManager.Send(comTrade);
            Assert.IsInstanceOf(typeof(string), actual);
            Assert.IsNotNull(actual);

            System.Diagnostics.Debug.Print(actual);
        }
    }
}
