using System;
using System.Windows.Input;
using Xamarin.Essentials;
using Xamarin.Forms;

namespace Dilution.ViewModels
{
    public class ConversorViewModel : BaseViewModel
    {
        public ConversorViewModel()
        {
            Title = "Conversor";
            OpenWebCommand = new Command(async () => await Browser.OpenAsync("https://xamarin.com"));
        }

        public ICommand OpenWebCommand { get; }
    }
}