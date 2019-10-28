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
    public partial class WebViewPage : ContentPage
    {
        public WebViewPage()
        {
            InitializeComponent();
        }

        private void WebView_Navigating(object sender, WebNavigatingEventArgs e)
        {
            webview.IsVisible = false;
            loader.IsVisible = true;
        }

        private void WebView_Navigated(object sender, WebNavigatedEventArgs e)
        {
            webview.IsVisible = true;
            loader.IsVisible = false;
        }
    }
}