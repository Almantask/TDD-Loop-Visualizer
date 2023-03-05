using OpenQA.Selenium.Appium.Windows;
using TddVisualiser.AcceptanceTests.PageObjects;
using TddVisualiser.AcceptanceTests.WinDriver;

namespace TddVisualiser.AcceptanceTests.Steps
{
    [Binding]
    public class GenericApplicationSteps
    {
        private WindowsDriver<WindowsElement> _driver;

        [When(@"I open TddLoopVisualizer")]
        public void WhenIOpenTddLoopVisualizer()
        {
            _driver = AutomationDriver.BuildDriverForApp(TddVisualizerPage.AppId);
        }

        [Then(@"it should be opened without any test run entries")]
        public void ThenItShouldBeOpenedWithoutAnyTestRunEntries()
        {
            _driver.Quit();
        }

    }
}
