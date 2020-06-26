using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using XFPETS.ViewModels;

namespace XFPETS.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class PetDetailsView : ContentPage
    {
        PetDetailsViewModel viewModel;
        public PetDetailsView(PetDetailsViewModel viewModel)
        {
            InitializeComponent();

            BindingContext = this.viewModel = viewModel;
        }
      /*  protected async override void OnDisappearing()
        {
            await Navigation.PopAsync();     
        } */  //No funciona en iOS
    }
}