using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using XFPETS.Services;
using XFPETS.Views;

namespace XFPETS
{
    public partial class App : Application
    {

        public App()
        {
            InitializeComponent();

            //DependencyService.Register<MockDataStore>();
            MainPage = new AppShell();
           // MainPage = new NavigationPage(new AppShell());
        }

        protected override void OnStart()
        {
        }

        protected override void OnSleep()
        {
        }

        protected override void OnResume()
        {
        }
    }
}
