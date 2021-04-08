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
                yield return new SaucePlatform("android", "android", "chrome", "89.0", "Google Pixel 3 GoogleAPI Emulator", "11.0.", "", "android", "portrait");
                yield return new SaucePlatform("", "", "Safari", "14.3", "iPhone 12 Pro Simulator", "14.3", "", "iphone", "portrait");
            }
        }
    }
}
/*
 * Copyright Andrew Gray, SauceForge
 * Date: 12th January 2020
 * 
 */
