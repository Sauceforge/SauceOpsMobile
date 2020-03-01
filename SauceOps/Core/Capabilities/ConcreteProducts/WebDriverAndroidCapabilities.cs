using System;
using OpenQA.Selenium.Appium;
using OpenQA.Selenium.Appium.Android;
using OpenQA.Selenium.Remote;
using SauceOps.Core.Capabilities.Base;
using SauceOps.Core.OnDemand;
using SauceOps.Core.Util;

namespace SauceOps.Core.Capabilities.ConcreteProducts {
    internal class WebDriverAndroidCapabilities : BaseCapabilities {
        public WebDriverAndroidCapabilities(SaucePlatform platform, string testName) : base(testName) {
            Console.WriteLine(SauceOpsConstants.SETTING_UP, testName, SauceOpsConstants.ANDROID_ON_WEBDRIVER);
            Caps = DesiredCapabilities.Android();

            //See https://github.com/appium/appium-dotnet-driver/wiki/Android-Sample
            //AndroidDriver<AppiumWebElement> iosd = new AndroidDriver<AppiumWebElement>(Caps);

            Caps.SetCapability(SauceOpsConstants.SAUCE_PLATFORM_CAPABILITY, SauceOpsConstants.LINUX);
            Caps.SetCapability(SauceOpsConstants.SAUCE_VERSION_CAPABILITY, platform.BrowserVersion);
            Caps.SetCapability(SauceOpsConstants.SAUCE_DEVICE_NAME_CAPABILITY, platform.LongName);
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