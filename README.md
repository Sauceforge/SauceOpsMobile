# SauceOpsMobile
Example of how to integrate Azure DevOps with SauceLabs Mobile Platforms in lieu of an Azure DevOps SauceLabs plugin.

## How To
1. Go to [SauceLabs](https://saucelabs.com) and sign up.
2. Clone [SauceOpsMobile](https://github.com/Sauceforge/SauceOpsMobile) and commit to Azure Repos in your Azure DevOps project.
3. Add two *private variables* to your pipeline:

| Name                   | Value                                                        |
| :--------------------: | -------------------------------------------------------------|
| OPSENG_SAUCE_USER_NAME | <USER NAME field @ https://app.saucelabs.com/user-settings>  |
| OPSENG_SAUCE_API_KEY   | <Access Key field @ https://app.saucelabs.com/user-settings> |

4. Write your Page Objects [here](https://github.com/Sauceforge/SauceOpsMobile/tree/master/SauceOps/YourTests/PageObjects).
5. Write your Tests [here](https://github.com/Sauceforge/SauceOpsMobile/tree/master/SauceOps/YourTests/Tests).
6. Specify the platforms you wish to test on [here](https://github.com/Sauceforge/SauceOpsMobile/blob/master/SauceOps/Core/DataSources/PlatformTestData.cs).