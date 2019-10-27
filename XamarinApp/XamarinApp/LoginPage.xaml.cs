using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace XamarinApp
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class LoginPage : ContentPage
    {
        public LoginPage()
        {
            InitializeComponent();
            TapGestureRecognizer imagetapped = new TapGestureRecognizer();

            image.GestureRecognizers.Add(imagetapped);

            imagetapped.Tapped += ImageTappedAction;
        }

        private async void ImageTappedAction(object sender, EventArgs e)
        {
            await DisplayAlert("Alert","You tapped the car image","OK");
            await Navigation.PopToRootAsync();
        }
    }
}