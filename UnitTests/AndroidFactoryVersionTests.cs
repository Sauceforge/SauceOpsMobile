using NUnit.Framework;
using SauceOps.Core.OnDemand;
using SauceOps.Core.Capabilities;
using Shouldly;
using System.Collections;

namespace UnitTests
{
    [TestFixture]
    public class AndroidFactoryVersionTests : TestBase
    {
        //[Test, TestCaseSource(typeof(AndroidDataClass), "SupportedTestCases")]
        //public void IsSupportedPlatformTest(SaucePlatform saucePlatform)
        //{
        //    var caps = CapabilityFactory.CreateCapabilities(saucePlatform, "MyTest");
        //    caps.IsSupportedPlatform().ShoulBeTrue();
        //}

        //[Test, TestCaseSource(typeof(AndroidDataClass), "NotSupportedTestCases")]
        //public void IsNotSupportedPlatformTest(SaucePlatform saucePlatform)
        //{
        //    var factory = new OptionFactory(saucePlatform);
        //    var result = factory.IsSupportedPlatform();
        //    result.ShouldBeFalse();
        //}

        [Test, TestCaseSource(typeof(AndroidDataClass), "SupportedTestCases")]
        public void AppiumAndroidCapabilityTest(SaucePlatform saucePlatform)
        {
            CapabilityFactory.CreateCapabilities(saucePlatform, "MyTest").ShouldNotBeNull();
        }
    }
    public class AndroidDataClass
    {
        public static IEnumerable SupportedTestCases
        {
            get
            {
                yield return new TestCaseData(new SaucePlatform("android", "chrome", "62.0", "android", "Google Pixel 3 GoogleAPI Emulator", "10.0.", "", "android", "landscape"));
            }
        }

        //public static IEnumerable NotSupportedTestCases
        //{
        //    get
        //    {
        //        yield return new TestCaseData(new SaucePlatform("android", "android", "android", "10.0", "Google Pixel 3 GoogleAPI Emulator", "10.0.", "", "android", "landscape"));
        //    }
        //}
    }
}
