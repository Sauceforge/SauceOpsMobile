using System.Collections.Generic;
using Newtonsoft.Json;
using SauceOps.Core.RestAPI.RecommendedAppiumVersion.Base;
using SauceOps.Core.Util;

namespace SauceOps.Core.RestAPI.RecommendedAppiumVersion
{
    public class SauceLabsAppiumRecommender : AppiumRecommender
    {
        public override string RecommendAppium() {
            var json = GetJsonResponse(SauceOpsConstants.RECOMMENDED_APPIUM_REQUEST);
            var recommendedAppiumVersion = JsonConvert.DeserializeObject<List<AppiumPlatform>>(json);
            return recommendedAppiumVersion[0].recommended_backend_version;
        }
    }
}

/*
 * Copyright Andrew Gray, SauceForge
 * Date: 10th August 2014
 * 
 */
