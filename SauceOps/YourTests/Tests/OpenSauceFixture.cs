﻿using System;
using NUnit.Framework;
using SauceOps.Core.OnDemand;
using SauceOps.Core.Tests;
using YourTests.PageObjects;
using Shouldly;

namespace YourTests.Tests {
    public class OpenSauceFixture : SauceryBase {
        public OpenSauceFixture(SaucePlatform platform) : base(platform) {
        }

        [Test]
        [TestCase(5)]
        [TestCase(4)]
        //[Ignore("Reason")]
        public void DoSomethingOnAWebPageWithSelenium(int data) {
            //Saucery supports NUnit data-driven tests 
            Console.WriteLine(@"My data is: " + data);
            var guineaPigPage = new GuineaPigPage(Driver, "https://saucelabs.com/");

            // verify the page title is correct - this is actually checked as part of the constructor above.
            Driver.Title.ShouldContain("I am a page title - Sauce Labs");
        }

        [Test]
        //[Ignore("Reason")]
        public void DoSomethingElseOnAWebPageWithSelenium() {
            var guineaPigPage = new GuineaPigPage(Driver, "https://saucelabs.com/");
            // find and click the link on the page
            guineaPigPage.ClickLink();

            // verify the browser was navigated to the correct page
            Driver.Url.ShouldContain("saucelabs.com/test-guinea-pig2.html");
        }

        [Test]
        //[Ignore("Reason")]
        public void DoSomethingElseAgainOnAWebPageWithSelenium() {
            var guineaPigPage = new GuineaPigPage(Driver, "https://saucelabs.com/");

            // read the useragent string off the page
            var useragent = guineaPigPage.GetUserAgent();

            useragent.ShouldNotBeNull();
        }
    }
}