using OpenQA.Selenium.Appium.Windows;
using OpenQA.Selenium.Appium;

namespace TddVisualiser.AcceptanceTests.WinDriver
{
    public static class AutomationDriver
    {
        public static WindowsDriver<WindowsElement> BuildDriverForApp(string appId, int timeoutMs = 1000)
        {
            var options = BuildWindowsOptionsForApp(appId);
            var driver = new WindowsDriver<WindowsElement>(AutomationServer.Uri, options);
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromMilliseconds(timeoutMs);

            return driver;
        }

        private static AppiumOptions BuildWindowsOptionsForApp(string appId)
        {
            var winOptions = new AppiumOptions();
            winOptions.AddAdditionalCapability("app", appId);
            winOptions.AddAdditionalCapability("deviceName", "WindowsPC");
            winOptions.AddAdditionalCapability("platformName", "Windows");

            return winOptions;
        }
    }
}
