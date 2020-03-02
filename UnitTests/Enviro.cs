using System;

namespace UnitTests {
    public static class Enviro {
        internal static string SauceNativeApp => GetStringVar(SauceOpsConstants.SAUCE_NATIVE_APP);

        internal static string SauceUserName => GetStringVar(SauceOpsConstants.SAUCE_USER_NAME);

        internal static string SauceApiKey => GetStringVar(SauceOpsConstants.SAUCE_API_KEY);

        public static string SauceOnDemandBrowsers => GetStringVar(SauceOpsConstants.SAUCE_ONDEMAND_BROWSERS);

        internal static bool SauceUseChromeOnAndroid => GetBoolVar(SauceOpsConstants.SAUCE_USE_CHROME_ON_ANDROID);

        public static string BuildNumber => GetStringVar(SauceOpsConstants.BUILD_NUMBER);
        
        public static string RecommendedAppiumVersion => GetStringVar(SauceOpsConstants.RECOMMENDED_APPIUM_VERSION);

        public static void SetVar(string variableName, string value) {
            if (GetStringVar(variableName) == null) {
                //Set it
                Environment.SetEnvironmentVariable(variableName, value);
            }
        }

        private static string GetStringVar(string envVar) {
            return envVar == null ? null : Environment.GetEnvironmentVariable(envVar);
        }

        private static bool GetBoolVar(string envVar) {
            var v = GetStringVar(envVar);
            return v != null && Convert.ToBoolean(v);
        }

        private static int GetIntVar(string envVar) {
            var v = GetStringVar(envVar);
            return v == null ? 0 : Convert.ToInt32(v);
        }

        private static double GetDoubleVar(string envVar) {
            var v = GetStringVar(envVar);
            return v == null ? 0 : Convert.ToDouble(v);
        }
    }
}
/*
 * Copyright Andrew Gray, SauceForge
 * Date: 12th July 2014
 * 
 */