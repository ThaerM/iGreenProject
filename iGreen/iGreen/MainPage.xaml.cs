using System;
using System.ComponentModel;
using Xamarin.Forms;

namespace iGreen
{
    // Learn more about making custom code visible in the Xamarin.Forms previewer
    // by visiting https://aka.ms/xamarinforms-previewer
    [DesignTimeVisible(false)]
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }

        private async void TheCarousel_CurrentItemChanged(object sender, CurrentItemChangedEventArgs e)
        {
            if ((string)e.CurrentItem == "screen2")
            {
                NextBtn.IsVisible = true;
                NextBtn.Opacity = 0;
                await NextBtn.FadeTo(1, 350);

            }
            else
            {
                NextBtn.Opacity = 1;
                await NextBtn.FadeTo(0, 350);
                NextBtn.IsVisible = false;

            }
        }

        private void GoToMenuPageHandler(object sender, EventArgs e)
        {
            Application.Current.MainPage = new NavigationPage(new HomePage());
        }
    }
}
