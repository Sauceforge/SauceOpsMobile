using System;
using OpenQA.Selenium.Remote;
using SauceOps.Core.Capabilities.Base;
using SauceOps.Core.OnDemand;
using SauceOps.Core.Util;

namespace SauceOps.Core.Capabilities.ConcreteProducts {
    internal class AppiumAndroidCapabilities : BaseCapabilities {
        public AppiumAndroidCapabilities(SaucePlatform platform, string testName)
            : base(testName)
        {
            Console.WriteLine(SauceOpsConstants.SETTING_UP, testName, SauceOpsConstants.ANDROID_ON_APPIUM);
            Caps = new DesiredCapabilities();

            Caps.SetCapability(SauceOpsConstants.SAUCE_BROWSER_NAME_CAPABILITY, SauceOpsConstants.CHROME_BROWSER);
            Caps.SetCapability(SauceOpsConstants.SAUCE_PLATFORM_VERSION_CAPABILITY, platform.SanitisedLongVersion());
            Caps.SetCapability(SauceOpsConstants.SAUCE_PLATFORM_NAME_CAPABILITY, SauceOpsConstants.ANDROID);
            Caps.SetCapability(SauceOpsConstants.SAUCE_DEVICE_NAME_CAPABILITY, platform.LongName);
            Caps.SetCapability(SauceOpsConstants.SAUCE_DEVICE_ORIENTATION_CAPABILITY, platform.DeviceOrientation);

            Console.WriteLine("{0}:{1}\n{2}:{3}\n{4}:{5}\n{6}:{7}\n{8}:{9}",
                              SauceOpsConstants.SAUCE_BROWSER_NAME_CAPABILITY, SauceOpsConstants.CHROME_BROWSER,
                              SauceOpsConstants.SAUCE_PLATFORM_VERSION_CAPABILITY, platform.SanitisedLongVersion(),
                              SauceOpsConstants.SAUCE_PLATFORM_NAME_CAPABILITY, SauceOpsConstants.ANDROID,
                              SauceOpsConstants.SAUCE_DEVICE_NAME_CAPABILITY, platform.LongName,
                              SauceOpsConstants.SAUCE_DEVICE_ORIENTATION_CAPABILITY, platform.DeviceOrientation);

            AddSauceLabsCapabilities(Enviro.SauceNativeApp);
        }
    }
}
/*
 * Copyright Andrew Gray, SauceForge
 * Date: 10th September 2014
 * 
 */