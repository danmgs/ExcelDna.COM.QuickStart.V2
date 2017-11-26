using DataApi.XLAddin.COM.Model;
using DataApi.XLAddin.COM.Model.Enums;
using NUnit.Framework;

namespace DataApi.XLAddin.Test.Model
{
    [TestFixture]
    public class COMTradeTest
    {
        [SetUp]
        public void Init()
        {
        }

        [TearDown]
        public void Dispose()
        {
        }

        [Test]
        public void SetAdditionnalInfosTest()
        {
            COMTrade comTrade = new COMTrade();

            comTrade.SetAdditionnalInfos(new string[2] { "Foo", "Bar" });
            var actual = comTrade.GetAdditionnalInfos();

            Assert.IsTrue(actual.GetType().Equals(typeof(string[])));

            //System.Diagnostics.Debug.Print(actual);
        }
    }
}
