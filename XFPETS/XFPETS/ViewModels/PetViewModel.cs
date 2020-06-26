using System;
using System.Threading.Tasks;
using Xamarin.Forms;
using Xamarin.Essentials;

using System.Linq;
using XFPETS.Models;
using System.Diagnostics;
using System.Collections.ObjectModel;
using MvvmHelpers;
using System.Windows.Input;

namespace XFPETS.ViewModels
{
    public class PetViewModel : BaseViewModel
    {
        public ObservableRangeCollection<Pets> Pets { get; }
        public Command LoadItemsCommand { get; set; }
        public Command<string> GetPetsCommand { get; }

        
        public PetViewModel()
        {
            Pets = new ObservableRangeCollection<Pets>();
            GetPetsCommand = new Command<string>(async (test) => await GetPetsAsync(test));
        }

        async Task GetPetsAsync(string test)
        {
            if (IsBusy)
                return;
            try
            {
                IsBusy = true;
                var pets = await DataService.GetPetsAsync();

                Pets.ReplaceRange(pets);

                Title = $"{test} ({Pets.Count})";
            }
            catch (Exception ex)
            {
                Debug.WriteLine($"Unable to get Pets: {ex.Message}");
                await Application.Current.MainPage.DisplayAlert("Error!", ex.Message, "OK");
            }
            finally
            {
                IsBusy = false;
            }
        }

    }
}