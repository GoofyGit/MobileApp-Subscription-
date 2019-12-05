using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace Project2Forms
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }

        private void GoToPageView_Clicked(object sender, EventArgs e)
        {
            Navigation.PushAsync(new View());
        }

        private void GoToPageAdd_Clicked(object sender, EventArgs e)
        {
            Navigation.PushAsync(new Add());
        }

        private void GoToPageAbout_Clicked(object sender, EventArgs e)
        {
            Navigation.PushAsync(new About());
        }

        private void PushNotification_Clicked(object sender, EventArgs e)
        {

        }
    }
}
