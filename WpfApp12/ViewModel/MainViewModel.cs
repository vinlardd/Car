using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WpfApp12.Models;

namespace WpfApp12.ViewModel
{
    internal partial class MAinViewModel : ObservableObject
    {

        [ObservableProperty] private Car selectedCar;


        [RelayCommand] 
        private void GenerateRandomCar()
        {
            string[] marks = { "kia", "lada", "toyota" };
            string[] colors = { "red", "blue", "purple" };


            Car car = new Car()
            {
                Color = colors[new Random().Next(0, colors.Length)],
                Marka = marks[new Random().Next(0, marks.Length)]
            };

            SelectedCar = car;

        }

    }
}
