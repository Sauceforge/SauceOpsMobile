using System;
using NUnit.Framework;
using NUnit.Framework.Interfaces;
using OpenQA.Selenium;
using OpenQA.Selenium.Remote;
using SauceOps.Core.DataSources;
using SauceOps.Core.Driver;
using SauceOps.Core.OnDemand;
using SauceOps.Core.Util;

namespace SauceOps.Core.Tests {
    //[Parallelizable(ParallelScope.Children)]
    [TestFixtureSource(typeof(PlatformTestData), "Platforms")]
    public class SauceryBase : SauceryRoot {
        protected SauceryRemoteWebDriver Driver;

        public SauceryBase(SaucePlatform platform) : base(platform) {
            
        }

        public override void InitialiseDriver(DesiredCapabilities caps, int waitSecs) {
            SauceLabsFlowController.ControlFlow();
            try {
                //Console.WriteLine("About to create Driver");
                Driver = new SauceryRemoteWebDriver(new Uri(SauceOpsConstants.SAUCELABS_HUB), caps);
                Driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(waitSecs);
            } catch(Exception ex) {
                Console.WriteLine(ex.Message);
            }
        }

        [TearDown]
        public void Cleanup() {
            if(Driver != null) {
                var passed = Equals(TestContext.CurrentContext.Result.Outcome, ResultState.Success);
                // log the result to SauceLabs
                SauceLabsStatusNotifier.NotifyStatus(Driver.GetSessionId(), passed);
                PrintSessionDetails();
                Driver.Quit();
            }
        }

        public void PrintSessionDetails() {
            try {
                var sessionId = Driver.GetSessionId();
                Console.WriteLine(@"SauceOnDemandSessionID={0} job-name={1}", sessionId, TestName);
            } catch(WebDriverException) {
                Console.WriteLine(@"Caught WebDriverException, quitting driver.");
                Driver.Quit();
            }
        }
    }
}
/*
 * Copyright Andrew Gray, SauceForge
 * Date: 12th July 2014
 * 
 */