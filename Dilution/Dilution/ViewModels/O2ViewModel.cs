using System;
using System.Windows.Input;
using Xamarin.Essentials;
using Xamarin.Forms;

namespace Dilution.ViewModels
{
    public class O2ViewModel : BaseViewModel
    {
        public O2ViewModel()
        {
            Title = "O2 Mixer";
            OpenWebCommand = new Command(async () => await Browser.OpenAsync("https://xamarin.com"));
        }

        public ICommand OpenWebCommand { get; }
    }
}