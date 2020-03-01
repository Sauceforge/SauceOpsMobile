using System;
using System.Text;
using SauceOps.Core.OnDemand;
using SauceOps.Core.Util;

namespace SauceOps.Core.Capabilities {
    internal static class CapabilityExtensions {
        public static bool CanUseAppium(this SaucePlatform platform) {
            if (platform.IsAnAndroidDevice()) { Console.WriteLine("CanUseAppium: Platform {0}; BrowserVersion: {1}", platform.Platform, platform.ParseBrowserVersion()); }
            return (IsAnAppleDevice(platform) &&
                    platform.ParseBrowserVersion() >= SauceOpsConstants.APPIUM_IOS_MINIMUM_VERSION) ||
                   (IsAnAndroidDevice(platform) &&
                    platform.ParseBrowserVersion() >= SauceOpsConstants.APPIUM_ANDROID_MINIMUM_VERSION);
        }

        public static bool IsAMobileDevice(this SaucePlatform platform)
        {
            return IsAnAndroidDevice(platform) || IsAnAppleDevice(platform);
        }

        public static bool IsADesktopPlatform(this SaucePlatform platform)
        {
            return !IsAMobileDevice(platform);
        }

        public static bool IsAnAppleDevice(this SaucePlatform platform)
        {
            return IsAnIPhone(platform) || IsAnIPad(platform);
        }

        public static bool IsAnIPhone(this SaucePlatform platform) {
            return platform.Device != null && platform.Device.ToLower().Contains(SauceOpsConstants.APPLE_IPHONE);
        }

        public static bool IsAnIPad(this SaucePlatform platform) {
            return platform.Device != null && platform.Device.ToLower().Contains(SauceOpsConstants.APPLE_IPAD);
        }

        public static bool IsAnAndroidDevice(this SaucePlatform platform) {
            return platform.Platform != null && platform.Platform.ToUpper().Contains(SauceOpsConstants.ANDROID_PLATFORM);
        }

        public static string GetTestName(this SaucePlatform platform, string testName) {
            var shortTestName = new StringBuilder();
            shortTestName.Append(testName.Contains(SauceOpsConstants.LEFT_SQUARE_BRACKET) 
                                    ? testName.Substring(0, testName.IndexOf(SauceOpsConstants.LEFT_SQUARE_BRACKET, StringComparison.Ordinal)) 
                                    : testName);
            return platform.IsADesktopPlatform()
                ? DesktopTestName(shortTestName, platform)
                : MobileTestName(shortTestName, platform);
        }

        public static string SanitisedLongVersion(this SaucePlatform platform)
        {
            return platform.LongVersion.EndsWith(SauceOpsConstants.DOT)
                    ? platform.LongVersion.Trim()
                    : platform.LongVersion.Trim().Remove(platform.LongVersion.Length - 1);
        }

        private static string DesktopTestName(StringBuilder shortTestName, SaucePlatform platform) {
            return AppendPlatformField(
                AppendPlatformField(AppendPlatformField(shortTestName, platform.Os), platform.Browser),
                platform.BrowserVersion).ToString();
        }

        private static string MobileTestName(StringBuilder shortTestName, SaucePlatform platform) {
            return AppendPlatformField(AppendPlatformField(AppendPlatformField(shortTestName, platform.LongName), platform.BrowserVersion),
                platform.DeviceOrientation).ToString();
        }

        private static StringBuilder AppendPlatformField(this StringBuilder testName, string fieldToAdd) {
            return testName.Append(SauceOpsConstants.UNDERSCORE).Append(fieldToAdd);
        }
    }
}
/*
 * Copyright Andrew Gray, SauceForge
 * Date: 18th September 2014
 * 
 */