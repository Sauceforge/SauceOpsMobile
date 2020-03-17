using System;
using OpenQA.Selenium.Appium;
using OpenQA.Selenium.Appium.Android;
using OpenQA.Selenium.Remote;
using SauceOps.Core.Capabilities.Base;
using SauceOps.Core.OnDemand;
using SauceOps.Core.Util;

namespace SauceOps.Core.Capabilities.ConcreteProducts {
    internal class AppiumAndroidCapabilities : BaseCapabilities {
        public AppiumAndroidCapabilities(SaucePlatform platform, string testName)
            : base(testName)
        {
            var nativeApp = Enviro.SauceNativeApp;
            //var useChromeOnAndroid = Enviro.SauceUseChromeOnAndroid;
            Console.WriteLine(SauceOpsConstants.SETTING_UP, testName, SauceOpsConstants.ANDROID_ON_APPIUM);
            //Caps = DesiredCapabilities.Android();
            Caps = new DesiredCapabilities();

            //See https://github.com/appium/appium-dotnet-driver/wiki/Android-Sample
            //AndroidDriver<AppiumWebElement> ad = new AndroidDriver<AppiumWebElement>(Caps);

            //Caps.SetCapability(SauceOpsConstants.SAUCE_APPIUM_VERSION_CAPABILITY, Enviro.RecommendedAppiumVersion);
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

            AddSauceLabsCapabilities(nativeApp);
        }
    }
}
/*
 * Copyright Andrew Gray, SauceForge
 * Date: 10th September 2014
 * 
 */