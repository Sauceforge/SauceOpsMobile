using SauceOps.Core.Capabilities.Base;
using SauceOps.Core.Capabilities.ConcreteProducts;
using SauceOps.Core.OnDemand;

namespace SauceOps.Core.Capabilities.ConcreteCreators {
    internal class AppiumIOSCreator : Creator {
        public override BaseCapabilities Create(SaucePlatform platform, string testName)
        {
            return new AppiumIOSCapabilities(platform, testName);
        }
    }
}
/*
 * Copyright Andrew Gray, SauceForge
 * Date: 18th September 2014
 * 
 */