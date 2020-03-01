namespace SauceOps.Core.Util {
    internal class Sanitiser {
        public static string SanitisePlatformField(string field) {
            return field.Equals(SauceOpsConstants.NULL_STRING) ? null : field;
        }

        public static string RemoveSpaces(string expected, string actual) {
            return !actual.Contains(SauceOpsConstants.SPACE) && expected.Contains(SauceOpsConstants.SPACE)
                ? actual
                : expected;
        }
    }
}
/*
 * Copyright Andrew Gray, SauceForge
 * Date: 12th August 2014
 * 
 */