using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Dilution.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class ConversorPage : ContentPage
    {
        public ConversorPage()
        {
            InitializeComponent();
            dosePicker.SelectedIndex = 0;
            timePicker.SelectedIndex = 0;
            OutTimePicker.SelectedIndex = 1;
            OutDosePicker.SelectedIndex = 1;
        }

        void OnButtonClicked(object sender, EventArgs e)
        {

            //(sender as Button).Text = "Click me again!";
            float dose = 0;
            float result = 0;

            if (float.TryParse(doseAbsolute.Text, out dose))
            {
                // you know that the parsing attempt
                // was successful
                //index 0 is mcg for dose, minute per time
                result = dose;
                if (dosePicker.SelectedIndex != OutDosePicker.SelectedIndex)
                {
                    //If mg to mcg
                    if (OutDosePicker.SelectedIndex == 0) result = dose * 1000;
                    else result = dose / 1000;
                }
                if (timePicker.SelectedIndex != OutTimePicker.SelectedIndex)
                {
                    //If hour to minute
                    if (OutTimePicker.SelectedIndex == 0) result = result / 60;
                    else result = result * 60;
                }

                string outputtext;
                if (OutDosePicker.SelectedIndex == 0) outputtext = " mcg/kg/";
                else outputtext = " mg/kg/";
                if (OutTimePicker.SelectedIndex == 0) outputtext = outputtext + "minute";
                else outputtext = outputtext + "hour";

                CalcRes.Text = result.ToString() + outputtext;

            }
            else
                CalcRes.Text = "ERROR";
        }
    }
}