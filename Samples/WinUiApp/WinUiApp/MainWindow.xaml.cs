using Microsoft.UI.Xaml;

// To learn more about WinUI, the WinUI project structure,
// and more about our project templates, see: http://aka.ms/winui-project-info.

namespace WinUiApp
{
    /// <summary>
    /// An empty window that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class MainWindow : Window
    {
        public MainWindow()
        {
            this.InitializeComponent();
            this.ExtendsContentIntoTitleBar = true;
            this.Activated += MainWindow_Activated;
        }

        private void MainWindow_Activated(object sender, WindowActivatedEventArgs args)
        {
            DesktopBridge.Helpers helpers = new DesktopBridge.Helpers();
            bool isUwp = helpers.IsRunningAsUwp();
            string text = isUwp ? "The app is running as a Universal Windows Package" : "The app is running as a native Win32 app";
            Status.Text = text;
        }
    }
}
