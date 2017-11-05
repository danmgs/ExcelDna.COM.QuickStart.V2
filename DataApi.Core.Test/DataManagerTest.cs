using DataApi.Model;
using NUnit.Framework;
using System.Collections.Generic;
using System.Linq;

namespace DataApi.Core.Test
{
    [TestFixture]
    public class DataManagerTest
    {
        private DataManager _dataManager { get; set; }

        [SetUp]
        public void Init()
        {
            _dataManager = new DataManager();
        }

        [TearDown]
        public void Dispose()
        {
            _dataManager = null;
        }

        [Test]
        public void GetUnderlyingProductTypesTest()
        {
            var actual = _dataManager.GetUnderlyingProductTypes();
            Assert.IsInstanceOf(typeof(List<string>), actual);
            Assert.IsNotNull(actual);
            Assert.IsTrue(actual.Any());
        }

        [Test]
        public void GetUnderlyingSourceTypesTest()
        {
            var actual = _dataManager.GetUnderlyingSourceTypes();
            Assert.IsInstanceOf(typeof(List<string>), actual);
            Assert.IsNotNull(actual);
            Assert.IsTrue(actual.Any());
        }
    }
}
