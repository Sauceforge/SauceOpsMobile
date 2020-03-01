using NUnit.Framework;
using SauceOps.Core.Capabilities;

namespace UnitTests {

    public class TestBase
    {
        internal CapabilityFactory Factory { get; set; }

        [SetUp]
        public void Setup()
        {
            
        }

        [TearDown]
        public void TearDown()
        {
            Factory = null;
        }
    }
}