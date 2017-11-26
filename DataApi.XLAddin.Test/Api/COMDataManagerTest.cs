using DataApi.XLAddin.COM.Classes;
using DataApi.XLAddin.COM.Model;
using DataApi.XLAddin.COM.Model.Enums;
using NUnit.Framework;

namespace DataApi.XLAddin.Test.Api
{
    [TestFixture]
    public class COMDataManagerTest
    {
        private COMDataManager _comDataManager { get; set; }

        [SetUp]
        public void Init()
        {
            _comDataManager = new COMDataManager();
        }

        [TearDown]
        public void Dispose()
        {
            _comDataManager = null;
        }

        [Test]
        public void GetUnderlyingProductTypesTest()
        {
            var actual = _comDataManager.GetUnderlyingProductTypes();
            Assert.IsInstanceOf(typeof(string[]), actual);
            Assert.IsNotNull(actual);
            Assert.IsTrue(actual.Length > 0);
        }

        [Test]
        public void GetUnderlyingSourceTypesTest()
        {
            var actual = _comDataManager.GetUnderlyingSourceTypes();
            Assert.IsInstanceOf(typeof(string[]), actual);
            Assert.IsNotNull(actual);
            Assert.IsTrue(actual.Length > 0);
        }
    }
}
