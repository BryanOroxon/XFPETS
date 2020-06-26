using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace XFPETS.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class DonatePage : ContentPage
    {
        public DonatePage()
        {
            InitializeComponent();
        }

        private void donate25_Clicked(object sender, EventArgs e)
        {
            donate25.BackgroundColor = Color.FromHex("#f0690c");
            labelDonate.Text = " $25 can pay a comfy bed.";
            donate50.BackgroundColor = Color.FromHex("#FFC300");
            donate100.BackgroundColor = Color.FromHex("#FFC300");
            Donate.Text = "Donate $25";
        }

        private void donate50_Clicked(object sender, EventArgs e)
        {
            donate50.BackgroundColor = Color.FromHex("#f0690c");
            labelDonate.Text = "$50 can feed a large dog for a month.";
            donate25.BackgroundColor = Color.FromHex("#FFC300");
            donate100.BackgroundColor = Color.FromHex("#FFC300");
            Donate.Text = "Donate $50";
        }

        private void donate100_Clicked(object sender, EventArgs e)
        {
            donate100.BackgroundColor = Color.FromHex("#f0690c");
            labelDonate.Text = "$100 can help to pay a medication for injured pet.";
            donate25.BackgroundColor = Color.FromHex("#FFC300");
            donate50.BackgroundColor = Color.FromHex("#FFC300");
            Donate.Text = "Donate $100";
        }

        private async void Donate_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new Donation());
        }
    }
}