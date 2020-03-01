using System;
using OpenQA.Selenium.Appium;
using OpenQA.Selenium.Appium.iOS;
using OpenQA.Selenium.Remote;
using SauceOps.Core.Capabilities.Base;
using SauceOps.Core.OnDemand;
using SauceOps.Core.Util;

namespace SauceOps.Core.Capabilities.ConcreteProducts {
    internal class WebDriverIOSCapabilities : BaseCapabilities {
        public WebDriverIOSCapabilities(SaucePlatform platform, string testName) : base(testName) {
            Console.WriteLine(SauceOpsConstants.SETTING_UP, testName, SauceOpsConstants.IOS_ON_WEBDRIVER);
            Caps = platform.IsAnIPhone() ? DesiredCapabilities.IPhone() : DesiredCapabilities.IPad();

            //See https://github.com/appium/appium-dotnet-driver/wiki/Android-Sample
            //IOSDriver<AppiumWebElement> iosd = new IOSDriver<AppiumWebElement>(Caps);

            Caps.SetCapability(CapabilityType.Platform, SauceOpsConstants.IOS_PLATFORM);
            Caps.SetCapability(CapabilityType.Version, platform.BrowserVersion);
            Caps.SetCapability(SauceOpsConstants.SAUCE_DEVICE_CAPABILITY, platform.Device);
            Caps.SetCapability(SauceOpsConstants.SAUCE_DEVICE_ORIENTATION_CAPABILITY, platform.DeviceOrientation);

            AddSauceLabsCapabilities();
        }
    }
}
/*
 * Copyright Andrew Gray, SauceForge
 * Date: 10th September 2014
 * 
 */