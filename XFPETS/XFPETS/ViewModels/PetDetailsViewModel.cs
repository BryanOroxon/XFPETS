using System;
using System.Diagnostics;
using System.Threading.Tasks;
using Xamarin.Essentials;
using Xamarin.Forms;
using XFPETS.Models;

namespace XFPETS.ViewModels
{
    public class PetDetailsViewModel : BaseViewModel
    {
        /*public PetDetailsViewModel(Pets pets)           
        {
            Pets = pets;
            Title = $"{Pets.Name} Details";
        }

        Pets pets;
        public Pets Pets
        {
            get => pets;
            set
            {
                if (pets == value)
                    return;

                pets = value;

                Title = $"{pets.Name} Detalles";
                OnPropertyChanged();
            }*/

            public Pets Pets { get; set; }

            public PetDetailsViewModel(Pets pet)
            {
                Title =  $"Scroll {pet.Name} Details";
            
                Pets = pet;
            }
        
    }
}
