using OpenQA.Selenium.Appium.Windows;
using TddVisualiser.AcceptanceTests.WinDriver;

namespace TddVisualiser.AcceptanceTests.Bootstrap
{
    [Binding]
    public static class Startup
    {
        public static WindowsDriver<WindowsElement> Driver { get; set; }

        [BeforeTestRun]
        public static void InitializeDriver()
        {
            AutomationServer.Start();
            Driver = AutomationDriver.BuildDriverForApp("TODO");
        }

        [AfterTestRun]
        public static void CleanupDriver()
        {
            // TODO: Anything else?
            AutomationServer.Stop();
            Driver.Quit();
        }
    }
}
