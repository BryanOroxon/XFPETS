using System;
using System.ComponentModel;
using Xamarin.Essentials;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace XFPETS.Views
{
    // Learn more about making custom code visible in the Xamarin.Forms previewer
    // by visiting https://aka.ms/xamarinforms-previewer
    [DesignTimeVisible(false)]
    public partial class AboutPage : ContentPage
    {
        public AboutPage()
        {
            InitializeComponent();

            LabelName.Text = "Name: " + $"{AppInfo.Name}";

            LabelVersion.Text = "Version " + $"{AppInfo.VersionString} " +
                $"{AppInfo.BuildString}";
        }

        private void Button_Clicked(object sender, EventArgs e)
        {
           
        }

        private async void DevInfo_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new ApInfoPage());
        }
    }
}
