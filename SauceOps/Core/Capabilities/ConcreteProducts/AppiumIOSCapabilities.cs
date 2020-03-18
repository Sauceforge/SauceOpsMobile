using System;
using OpenQA.Selenium.Remote;
using SauceOps.Core.Capabilities.Base;
using SauceOps.Core.OnDemand;
using SauceOps.Core.Util;

namespace SauceOps.Core.Capabilities.ConcreteProducts {
    internal class AppiumIOSCapabilities : BaseCapabilities {
        public AppiumIOSCapabilities(SaucePlatform platform, string testName) : base(testName) {
            Console.WriteLine(SauceOpsConstants.SETTING_UP, testName, SauceOpsConstants.IOS_ON_APPIUM);
            Caps = platform.IsAnIPhone() ? DesiredCapabilities.IPhone() : DesiredCapabilities.IPad();

            Caps.SetCapability(SauceOpsConstants.SAUCE_BROWSER_NAME_CAPABILITY, GetBrowser(Enviro.SauceNativeApp));
            Caps.SetCapability(SauceOpsConstants.SAUCE_PLATFORM_VERSION_CAPABILITY, platform.BrowserVersion);
            Caps.SetCapability(SauceOpsConstants.SAUCE_PLATFORM_NAME_CAPABILITY, SauceOpsConstants.IOS_PLATFORM);
            Caps.SetCapability(SauceOpsConstants.SAUCE_DEVICE_NAME_CAPABILITY, platform.IsAnIPhone() ? SauceOpsConstants.IPHONE_SIMULATOR : SauceOpsConstants.IPAD_SIMULATOR);
            Caps.SetCapability(SauceOpsConstants.SAUCE_DEVICE_CAPABILITY, platform.IsAnIPhone() ? SauceOpsConstants.IPHONE_DEVICE : SauceOpsConstants.IPAD_DEVICE);
            Caps.SetCapability(SauceOpsConstants.SAUCE_DEVICE_ORIENTATION_CAPABILITY, platform.DeviceOrientation);

            AddSauceLabsCapabilities(Enviro.SauceNativeApp);
        }
    }
}
/*
 * Copyright Andrew Gray, SauceForge
 * Date: 10th September 2014
 * 
 */