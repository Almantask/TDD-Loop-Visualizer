using OpenQA.Selenium.Appium.Service;
using System.Diagnostics;

namespace TddVisualiser.AcceptanceTests.WinDriver
{
    /// <summary>
    /// Listener for all automation acitons. Is needed for target of a driver.
    /// </summary>
    internal class AutomationServer
    {
        public static Uri Uri => _localService.ServiceUrl;

        private static AppiumLocalService _localService;
        private static bool IsStarted => _localService?.IsRunning == true;

        public static void Start()
        {
            if (IsStarted)
            {
                throw new InvalidOperationException("Appium server is already started. No need to start again");
            }

            StartWinAppDriverServer();
            _localService = AppiumLocalService.BuildDefaultService();

            // In case test run stops abruptly or is cancelled - the server may not be started and this hangs.
            // Left of here: https://github.com/microsoft/WinAppDriver/wiki/WinAppDriver-and-Appium#the-appium-default-server-path-is-different-from-winappdriver
            if (!IsStarted)
            {
                try
                {
                    _localService.Start();
                }
                catch(Exception ex) {
                
                } 
            }
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

        private static void StartWinAppDriverServer()
        {
            ProcessStartInfo psi = new ProcessStartInfo();
            psi.FileName = @"C:\Program Files\Windows Application Driver\WinAppDriver.exe";
            Process winAppDriverProcess = new Process();
            winAppDriverProcess.StartInfo = psi;
            winAppDriverProcess.Start();
        }
    }
}
