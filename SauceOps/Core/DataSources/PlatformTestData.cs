using SauceOps.Core.OnDemand;
using System.Collections;

namespace SauceOps.Core.DataSources
{
    public class PlatformTestData
    {
        public static IEnumerable Platforms
        {
            get
            {
                //Mobile Platforms
                yield return new SaucePlatform("android", "chrome", "62.0", "android", "Google Pixel 3 GoogleAPI Emulator", "10.0.", "", "android", "landscape");
            }
        }
    }
}
/*
 * Copyright Andrew Gray, SauceForge
 * Date: 12th January 2020
 * 
 */
