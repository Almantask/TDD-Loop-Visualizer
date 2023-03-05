using OpenQA.Selenium.Appium.Service;

namespace TddVisualiser.AcceptanceTests.WinDriver
{
    /// <summary>
    /// Listener for all automation acitons. Is needed for target of a driver.
    /// </summary>
    internal class AutomationServer
    {
        public static Uri Uri => _localService.ServiceUrl;

        private static AppiumLocalService _localService;
        private static bool IsStarted => _localService.IsRunning;

        public static void Start()
        {
            if (IsStarted)
            {
                throw new InvalidOperationException("Appium server is already started. No need to start again");
            }

            var builder = new AppiumServiceBuilder();
            _localService = builder.Build();
            _localService.Start();
        }

        public static void Stop()
        {
            // Stop as many times as you want - not an issue.

            if (IsStarted)
            {
                _localService.Dispose();
                _localService = null;
            }
        }
    }
}
