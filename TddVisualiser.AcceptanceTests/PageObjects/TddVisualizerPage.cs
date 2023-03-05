using OpenQA.Selenium.Appium.Windows;

namespace TddVisualiser.AcceptanceTests.PageObjects
{
    public class TddVisualizerPage
    {
        // TODO: Change
        public const string AppId = @"C:\Windows\System32\notepad.exe";

        private readonly WindowsDriver<WindowsElement> _driver;

        protected TddVisualizerPage(WindowsDriver<WindowsElement> driver)
        {
            _driver = driver;
        }
    }
}
