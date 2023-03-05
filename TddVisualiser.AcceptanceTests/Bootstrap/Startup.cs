using OpenQA.Selenium.Appium.Windows;
using TddVisualiser.AcceptanceTests.WinDriver;

namespace TddVisualiser.AcceptanceTests.Bootstrap
{
    [Binding]
    public static class Startup
    {
        public static WindowsDriver<WindowsElement> Driver { get; set; }

        [BeforeTestRun()]
        public static void InitializeAppium()
        {
            AutomationServer.Start();
            // Driver = AutomationDriver.BuildDriverForApp(@"C:\Program Files\Microsoft Visual Studio\2022\Enterprise\Common7\IDE\devenv.exe");
        }

        [AfterTestRun]
        public static void CleanupAppium()
        {
            // TODO: Anything else?
            AutomationServer.Stop();
            //Driver.Quit();
        }
    }
}
