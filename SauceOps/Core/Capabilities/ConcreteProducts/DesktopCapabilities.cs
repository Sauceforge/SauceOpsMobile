using System;
using OpenQA.Selenium.Remote;
using SauceOps.Core.Capabilities.Base;
using SauceOps.Core.OnDemand;
using SauceOps.Core.Util;

namespace SauceOps.Core.Capabilities.ConcreteProducts {
    internal class DesktopCapabilities : BaseCapabilities {
        public DesktopCapabilities(SaucePlatform platform, string testName)
            : base(testName)
        {
            Console.WriteLine(SauceOpsConstants.SETTING_UP, testName, SauceOpsConstants.DESKTOP_ON_WEBDRIVER);
            Caps = new DesiredCapabilities();
            Caps.SetCapability(CapabilityType.Platform, platform.Os);
            Caps.SetCapability(CapabilityType.Version, platform.BrowserVersion);
            Caps.SetCapability(CapabilityType.BrowserName, platform.Browser);

            AddSauceLabsCapabilities();
        }
    }
}
/*
 * Copyright Andrew Gray, SauceForge
 * Date: 18th September 2014
 * 
 */