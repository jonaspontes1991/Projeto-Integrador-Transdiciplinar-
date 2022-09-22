using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace PIT
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }
        void webviewNavigating(object sender, WebNavigatingEventArgs e)
        {
            pagina.IsVisible = false;
            logo.IsVisible = true;
            labelLoading.IsEnabled = true;
            labelLoading.IsRefreshing = true;
        }

        void webviewNavigated(object sender, WebNavigatedEventArgs e)
        {
            pagina.IsVisible = true;
            logo.IsVisible = false;
            labelLoading.IsRefreshing = false;
            labelLoading.IsEnabled = false;

        }
    }
}
