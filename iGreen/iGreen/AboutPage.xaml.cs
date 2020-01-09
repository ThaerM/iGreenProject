using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace iGreen
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class AboutPage : ContentPage
    {
        public AboutPage()
        {
            InitializeComponent();
        }

        private async void Button_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushModalAsync(new MenuPage());
        }
    }
}