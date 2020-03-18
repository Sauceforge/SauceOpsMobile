using OpenQA.Selenium.Remote;
using SauceOps.Core.Util;

namespace SauceOps.Core.Capabilities.Base
{
    internal abstract class BaseCapabilities {
        protected DesiredCapabilities Caps = null;
        private readonly string _testName;

        protected BaseCapabilities(string testName) {
            _testName = testName;
        }

        protected void AddSauceLabsCapabilities() {
            Caps.SetCapability(SauceOpsConstants.SAUCE_USERNAME_CAPABILITY, Enviro.SauceUserName);
            Caps.SetCapability(SauceOpsConstants.SAUCE_ACCESSKEY_CAPABILITY, Enviro.SauceApiKey);
            Caps.SetCapability(SauceOpsConstants.SELENIUM_VERSION_CAPABILITY, SauceOpsConstants.LATEST_SELENIUM_VERSION);
            //This sets the Session column
            Caps.SetCapability(SauceOpsConstants.SAUCE_SESSIONNAME_CAPABILITY, _testName);
            //This sets the Build column
            Caps.SetCapability(SauceOpsConstants.SAUCE_BUILDNAME_CAPABILITY, Enviro.BuildName);
            //Improve performance on SauceLabs
            Caps.SetCapability(SauceOpsConstants.SAUCE_VUOP_CAPABILITY, false);
            //Caps.SetCapability(Constants.VISIBILITY_KEY, Constants.VISIBILITY_TEAM);
        }

        protected void AddSauceLabsCapabilities(string nativeApp) {
            AddSauceLabsCapabilities();
            if (nativeApp != null) {
                Caps.SetCapability(SauceOpsConstants.SAUCE_NATIVE_APP_CAPABILITY, nativeApp);
            }
        }

        public DesiredCapabilities GetCaps() {
            return Caps;
        }

        protected static string GetBrowser(string nativeApp) {
            return nativeApp != null ? "" : SauceOpsConstants.SAFARI_BROWSER;
        }
    }
}
/*
 * Copyright Andrew Gray, SauceForge
 * Date: 18th September 2014
 * 
 */