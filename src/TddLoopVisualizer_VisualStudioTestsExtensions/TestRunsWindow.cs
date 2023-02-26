using Microsoft.VisualStudio.Shell;
using System;
using System.Runtime.InteropServices;

namespace TddLoopVisualizer_VisualStudioTestsExtensions
{
    /// <summary>
    /// This class implements the tool window exposed by this package and hosts a user control.
    /// </summary>
    /// <remarks>
    /// In Visual Studio tool windows are composed of a frame (implemented by the shell) and a pane,
    /// usually implemented by the package implementer.
    /// <para>
    /// This class derives from the ToolWindowPane class provided from the MPF in order to use its
    /// implementation of the IVsUIElementPane interface.
    /// </para>
    /// </remarks>
    [Guid("a1d0b680-d451-4879-90b6-7ba405e39132")]
    public class TestRunsWindow : ToolWindowPane
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="TestRunsWindow"/> class.
        /// </summary>
        public TestRunsWindow() : base(null)
        {
            this.Caption = "TestRunsWindow";

            // This is the user control hosted by the tool window; Note that, even if this class implements IDisposable,
            // we are not calling Dispose on this object. This is because ToolWindowPane calls Dispose on
            // the object returned by the Content property.
            this.Content = new TestRunsWindowControl();
        }
    }
}
