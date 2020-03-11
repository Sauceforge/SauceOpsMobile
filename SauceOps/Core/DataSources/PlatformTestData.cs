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
                yield return new SaucePlatform("android", "android", "chrome", "62.0", "Google Pixel 3 GoogleAPI Emulator", "10.0.", "", "android", "landscape");
                yield return new SaucePlatform("ios", "ios", "safari", "13.0", "iPhone XS Max Simulator", "13.0", "", "iphone", "portrait");
            }
        }
    }
}
/*
 * Copyright Andrew Gray, SauceForge
 * Date: 12th January 2020
 * 
 */
