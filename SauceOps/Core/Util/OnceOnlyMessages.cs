using System;
using System.Collections.Generic;
using System.Linq;
using SauceOps.Core.OnDemand;

namespace SauceOps.Core.Util {
    internal class OnceOnlyMessages {
        public static void CopyrightBanner() {
            OnceOnlyWriter.WriteLine(SauceOpsConstants.CONSOLE_RUNNER, Saucery3Constants.PRODUCTNAME/*, NuGetHelper.GetInstalledVersion()*/);
            OnceOnlyWriter.WriteLine(SauceOpsConstants.COPYRIGHT_NOTICE, GetCurrentYear());
            //NewVersionAvailable();
            OnceOnlyWriter.WriteLine(SauceOpsConstants.SPACE);
        }

        public static void TestingOn(List<SaucePlatform> platforms) {
            OnceOnlyWriter.WriteLine(platforms.Any()
                ? string.Format(SauceOpsConstants.TESTING_ON, platforms.Count, GetMoniker(platforms))
                : SauceOpsConstants.NO_PLATFORMS);
        }

        public static void OnDemand() {
            if (UserChecker.ItIsMe()) {
                OnceOnlyWriter.WriteLine(SauceOpsConstants.ON_DEMAND, Enviro.SauceOnDemandBrowsers);
            }
        }

        public static void UsingLicenced() {
            OnceOnlyWriter.WriteLine(SauceOpsConstants.LICENCED_VERSION, Saucery3Constants.PRODUCTNAME);
        }

        public static void UsingTrial() {
            OnceOnlyWriter.WriteLine(SauceOpsConstants.TRIAL_VERSION, Saucery3Constants.PRODUCTNAME);
        }

        public static void DaysRemaining(double remaining) {
            OnceOnlyWriter.WriteLine(SauceOpsConstants.DAYS_REMAINING, remaining);
        }

        private static string GetCurrentYear() {
            return DateTime.Now.ToString(SauceOpsConstants.YEAR_FORMAT);
        }

        private static string GetMoniker(IReadOnlyCollection<SaucePlatform> platforms) {
            return platforms.Count == 1 ? "platform" : "platforms";
        }

        internal static void RestApiLimitExceeded() {
            OnceOnlyWriter.WriteLine(SauceOpsConstants.RESTAPI_LIMIT_EXCEEDED_MSG);
        }
    }
}
/*
 * Copyright Andrew Gray, SauceForge
 * Date: 24th December 2015
 * 
 */