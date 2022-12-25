using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

using Dilution.Models;
using Dilution.Views;
using Dilution.ViewModels;

namespace Dilution.Views
{
    // Learn more about making custom code visible in the Xamarin.Forms previewer
    // by visiting https://aka.ms/xamarinforms-previewer
    [DesignTimeVisible(false)]
    public partial class ItemsPage : ContentPage
    {
        ItemsViewModel viewModel;

        public ItemsPage()
        {
            InitializeComponent();

            BindingContext = viewModel = new ItemsViewModel();
        }

        void OnButtonClicked(object sender, EventArgs e)
        {

            //(sender as Button).Text = "Click me again!";
            float Cmaj = 0;
            float Cmin = 0;
            float Cgoal = 0;
            float Vgoal = 0;
            float result = 0;

            if (float.TryParse(CMajor.Text, out Cmaj) & float.TryParse(CMinor.Text, out Cmin) & float.TryParse(CGoal.Text, out Cgoal) & float.TryParse(VGoal.Text, out Vgoal))
            {
                // you know that the parsing attempt
                // was successful
                result = Vgoal * ((Cgoal - Cmin) / (Cmaj - Cmin));
                CalcRes.Text = "Result: " + result.ToString();

            }
            else
                CalcRes.Text = "ERROR";
        }
    }
}