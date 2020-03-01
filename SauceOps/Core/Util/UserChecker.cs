namespace SauceOps.Core.Util {
    internal static class UserChecker {
        internal static bool ItIsMe() {
            return Enviro.SauceUserName.ToLower().Equals(SauceOpsConstants.MY_USERNAME_LOWER);
        }
    }
}
/*
 * Copyright Andrew Gray, SauceForge
 * Date: 29th July 2014
 * 
 */