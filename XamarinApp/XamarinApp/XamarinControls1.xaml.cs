using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace XamarinApp
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class XamarinControls1 : ContentPage
    {
        List<string> certs = new List<string>();

        public XamarinControls1()
        {
            InitializeComponent();

            certs.Add("Choose Subject");
            certs.Add("Math");
            certs.Add("Chem");

            cer.ItemsSource = certs;
            cer.SelectedIndex = 0;

            //imageholder.Source = ImageSource.FromResource("XamarinApp.Assets.car.png");
        }

        

        private void Button_Clicked(object sender, EventArgs e)
        {
           string dt = date.Date.ToShortDateString();
            showdate.Text = dt;

            string tm = time.Time.ToString();
            showtime.Text = tm;

            if (daytime.IsToggled)
            {
                showisday.Text = "Good Morning";
            }
            else
            {
                showisday.Text = "Good Night";
            }

        }

        private void daytime_PropertyChanged(object sender, System.ComponentModel.PropertyChangedEventArgs e)
        {
            if (daytime.IsToggled)
            {
                showisday.IsVisible = true;
                showisday.Text = "Good Morning";
            }
            else
            {
                showisday.IsVisible = false;

                showisday.Text = "Good Night";
            }
        }

        private void age_PropertyChanged(object sender, System.ComponentModel.PropertyChangedEventArgs e)
        {
            if (age.IsChecked && gr.IsChecked)
            {
                submit.IsEnabled = true;
            }
            else
            {
                submit.IsEnabled = false;

            }
        }

        private void gr_PropertyChanged(object sender, System.ComponentModel.PropertyChangedEventArgs e)
        {
            if (age.IsChecked && gr.IsChecked)
            {
                submit.IsEnabled = true;
            }
            else
            {
                submit.IsEnabled = false;

            }
        }

        private void cer_SelectedIndexChanged(object sender, EventArgs e)
        {
            var picker = sender as Picker;

            string item = picker.SelectedItem.ToString();

            pickeritem.Text = item;
        }
    }
}