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
    public partial class PopUpPage : ContentPage
    {
        public PopUpPage()
        {
            InitializeComponent();
        }

        private void Button_Clicked(object sender, EventArgs e)
        {
            popup.IsVisible = true;
        }

        private void Button_Clicked_1(object sender, EventArgs e)
        {
            popup.IsVisible = false;
        }
    }
}