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
    public partial class XamarinControls2 : ContentPage
    {
        List<string> Users = new List<string>();

        public XamarinControls2()
        {
            InitializeComponent();

            //Uri url = new Uri("https://unsplash.com/photos/Wuh3eqVliQ0");

            //imageholder = 
            //    new Image { Source = ImageSource.FromUri(url) };

            Users.Add("Ali");
            userslist.ItemsSource = Users;
        }

        private void Button_Clicked(object sender, EventArgs e)
        {
            string name  = username.Text;


            users.Items.Add(name);

            
        }

        private void Stepper_PropertyChanged(object sender, System.ComponentModel.PropertyChangedEventArgs e)
        {
            Stepper sen = sender as Stepper;

            progress.Progress = sen.Value;

        }
    }
}