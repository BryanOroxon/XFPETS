using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using XFPETS.Models;
using XFPETS.ViewModels;

namespace XFPETS.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class PetPage : ContentPage
    {
        public PetViewModel viewModel;
        public PetPage()
        {
            InitializeComponent();
            BindingContext = viewModel = new PetViewModel();
            if (viewModel.Pets.Count == 0)
            {
                viewModel.GetPetsCommand.Execute("Find your new Pet");
                CollectionViewSource.ItemsSource = viewModel.Pets;
                
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
            CollectionViewSource.SelectedItem = null;
        }

        public PetPage(Pets pets) : this()
        {
            ((PetDetailsViewModel)BindingContext).Pets = pets;
        }
    }
}