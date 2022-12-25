using System;
using System.Windows.Input;
using Xamarin.Essentials;
using Xamarin.Forms;

namespace Dilution.ViewModels
{
    public class AboutViewModel : BaseViewModel
    {
        public AboutViewModel()
        {
            Title = "About";
            OpenLinkCommand = new Command(async () => await Browser.OpenAsync("https://www.elsevier.es/es-revista-revista-cientifica-sociedad-espanola-enfermeria-319-articulo-suero-salino-hipertonico-un-metodo-S201352461500032X"));
            OpenWebCommand = new Command(async () => await Browser.OpenAsync("https://xamarin.com"));
        }
        public ICommand OpenLinkCommand { get; }
        public ICommand OpenWebCommand { get; }
    }
}