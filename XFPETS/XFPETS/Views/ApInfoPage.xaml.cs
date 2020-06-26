using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Essentials;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace XFPETS.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class ApInfoPage : ContentPage
    {
        public ApInfoPage()
        {
            InitializeComponent();


            var device = DeviceInfo.Model;

            var manufacturer = DeviceInfo.Manufacturer;

            var deviceName = DeviceInfo.Name;

            var version = DeviceInfo.VersionString;

            var platform = DeviceInfo.Platform;            
            
            var deviceType = DeviceInfo.DeviceType;


            LabelDevice.Text = $"{deviceName} {version} {platform}";

            LabelDeviceDisplay.Text = DeviceDisplay.MainDisplayInfo.ToString();

        }

        protected override void OnAppearing()
        {
            base.OnAppearing();
            DeviceDisplay.MainDisplayInfoChanged += DeviceDisplay_MainDisplayInfoChanged;
        }

        private void DeviceDisplay_MainDisplayInfoChanged(object sender, DisplayInfoChangedEventArgs e)
        {
            LabelDeviceDisplay.Text = e.DisplayInfo.ToString();
        }

        protected override void OnDisappearing()
        {
            base.OnDisappearing();
            DeviceDisplay.MainDisplayInfoChanged -= DeviceDisplay_MainDisplayInfoChanged;
        }
        
        /* protected async override void OnDisappearing()
        {
            base.OnDisappearing();
            DeviceDisplay.MainDisplayInfoChanged -= DeviceDisplay_MainDisplayInfoChanged;
            //  await Navigation.PopAsync();  /No funciona en iOS
        } */
    }

}