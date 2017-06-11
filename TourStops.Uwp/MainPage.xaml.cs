using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using Windows.ApplicationModel.Calls;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.System;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Navigation;

// The Blank Page item template is documented at https://go.microsoft.com/fwlink/?LinkId=402352&clcid=0x409

namespace TourStops.Uwp
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class MainPage : Page
    {
        public MainPage()
        {
            this.InitializeComponent();
        }

        private void CalcButton_Click(object sender, RoutedEventArgs e)
        {
            var duration = new TourLib.Duration();
            double result = duration.CalculateTourDuration(numberOfStops: 2, speedRatio: 1.2);
            DurationMessage.Text = String.Format("{0} minutes", result);

        }

        private async void MapButton_Click(object sender, RoutedEventArgs e)
        {
            await Launcher.LaunchUriAsync(new Uri("http://maps.google.com/maps?q=chicago"));
        }

        private void PhoneButton_Click(object sender, RoutedEventArgs e)
        {
            PhoneCallManager.ShowPhoneCallUI(PhoneButton.Content.ToString(),TextBlock1.Text);
        }
    }
}
