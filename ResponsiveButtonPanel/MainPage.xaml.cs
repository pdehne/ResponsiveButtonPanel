using System;
using Windows.Foundation;
using Windows.UI.Popups;
using Windows.UI.ViewManagement;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;

namespace ResponsiveButtonPanel
{
    public sealed partial class MainPage : Page
    {
        public MainPage()
        {
            this.InitializeComponent();

            ApplicationView.GetForCurrentView().SetPreferredMinSize(new Size { Width = 320, Height = 400 });
        }

        private async void ResponsiveButtonPanelButton_Click(object sender, RoutedEventArgs e)
        {
            var button = sender as ResponsiveButtonPanelButton;

            MessageDialog dialog = new MessageDialog(button.Text + " clicked", "Information");

            await dialog.ShowAsync();
        }
    }
}
