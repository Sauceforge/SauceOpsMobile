using System;
using OpenQA.Selenium.Remote;
using SauceOps.Core.Capabilities.Base;
using SauceOps.Core.OnDemand;
using SauceOps.Core.Util;

namespace SauceOps.Core.Capabilities.ConcreteProducts {
    internal class AppiumIOSCapabilities : BaseCapabilities {
        public AppiumIOSCapabilities(SaucePlatform platform, string testName) : base(testName) {
            var nativeApp = Enviro.SauceNativeApp;
            //Console.WriteLine(SauceOpsConstants.SETTING_UP_APPIUM, testName, SauceOpsConstants.IOS_ON_APPIUM, Enviro.RecommendedAppiumVersion);
            Console.WriteLine(SauceOpsConstants.SETTING_UP, testName, SauceOpsConstants.IOS_ON_APPIUM);
            Caps = platform.IsAnIPhone() ? DesiredCapabilities.IPhone() : DesiredCapabilities.IPad();

            //See https://github.com/appium/appium-dotnet-driver/wiki/Android-Sample
            //IOSDriver<AppiumWebElement> iosd = new IOSDriver<AppiumWebElement>(Caps);

            //Caps.SetCapability(SauceOpsConstants.SAUCE_APPIUM_VERSION_CAPABILITY, Enviro.RecommendedAppiumVersion);
            Caps.SetCapability(SauceOpsConstants.SAUCE_BROWSER_NAME_CAPABILITY, GetBrowser(nativeApp));
            Caps.SetCapability(SauceOpsConstants.SAUCE_PLATFORM_VERSION_CAPABILITY, platform.BrowserVersion);
            Caps.SetCapability(SauceOpsConstants.SAUCE_PLATFORM_NAME_CAPABILITY, SauceOpsConstants.IOS_PLATFORM);
            Caps.SetCapability(SauceOpsConstants.SAUCE_DEVICE_NAME_CAPABILITY, platform.IsAnIPhone() ? SauceOpsConstants.IPHONE_SIMULATOR : SauceOpsConstants.IPAD_SIMULATOR);
            Caps.SetCapability(SauceOpsConstants.SAUCE_DEVICE_CAPABILITY, platform.IsAnIPhone() ? SauceOpsConstants.IPHONE_DEVICE : SauceOpsConstants.IPAD_DEVICE);
            Caps.SetCapability(SauceOpsConstants.SAUCE_DEVICE_ORIENTATION_CAPABILITY, platform.DeviceOrientation);

            AddSauceLabsCapabilities(nativeApp);
        }
    }
}
/*
 * Copyright Andrew Gray, SauceForge
 * Date: 10th September 2014
 * 
 */