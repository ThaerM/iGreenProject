using iGreen.Model;
using System.Collections.Generic;
using System.Linq;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace iGreen
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class HomePage : ContentPage
    {
        public List<string> animationName;
        private HomeDataModel nameItem;
        public HomePage()
        {
            InitializeComponent();
            animationName = new List<string>() { "forest.json" };
        }

        protected override void OnAppearing()
        {
            base.OnAppearing();
            animationView.IsVisible = false;
            layoutPage.IsVisible = true;
            logoanimation.Opacity = 0;
        }

        private async void Handle_OnFinish(object sender, System.EventArgs e)
        {
            await Navigation.PushAsync(new ItemPage(nameItem) { Title = nameItem.Name }, true).ConfigureAwait(true); ;
        }
        private async void ShowAnimationHandel(object sender, System.EventArgs e)
        {
            await Navigation.PushModalAsync(new MenuPage(), true);

        }

        private void listView_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            if (listView.SelectedItem != null)
            {
                var result = (e.CurrentSelection.FirstOrDefault() as HomeDataModel);
                if (result != null)
                {
                    nameItem = result;

                    animationView.IsVisible = true;
                    animation.Play();
                    layoutPage.IsVisible = false;
                    logoanimation.FadeTo(1, 1500);
                    listView.SelectedItem = null;
                }
            }
        }

        private async void ShowDetails(object sender, System.EventArgs e)
        {
            await Navigation.PushModalAsync(new AboutPage(), true);
        }
    }
}