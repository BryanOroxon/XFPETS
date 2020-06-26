using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using XFPETS.Models;
using XFPETS.ViewModels;

namespace XFPETS.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class HomePage : ContentPage
    {
        public PetViewModel viewModel;
        public HomePage()
        {
            InitializeComponent();
            BindingContext = viewModel = new PetViewModel();
            if (viewModel.Pets.Count == 0)
            {
                viewModel.GetPetsCommand.Execute("Find your new Pet");               
                PetsList.ItemsSource = viewModel.Pets;
            }
        }

        async void OnItemSelected(object sender, SelectedItemChangedEventArgs args)
        {
            var item = args.SelectedItem as Pets;
            if (item == null)
            {
                // the item was deselected
                return;
            }
            // Navigate to the detail page
            await Navigation.PushAsync(new PetDetailsView(new PetDetailsViewModel(item)));
            
            // Manually deselect item
            PetsList.SelectedItem = null;
        }
    
        public HomePage(Pets pets) : this()
        {
            ((PetDetailsViewModel)BindingContext).Pets = pets;
        }

        private async void Donate_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new DonatePage());
        }
    }
}