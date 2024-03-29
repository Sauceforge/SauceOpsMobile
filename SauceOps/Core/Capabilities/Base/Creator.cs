﻿using SauceOps.Core.OnDemand;

namespace SauceOps.Core.Capabilities.Base {
    internal abstract class Creator {
        public abstract BaseCapabilities Create(SaucePlatform platform, string testName);
    }
}
/*
 * Copyright Andrew Gray, SauceForge
 * Date: 18th September 2014
 * 
 */