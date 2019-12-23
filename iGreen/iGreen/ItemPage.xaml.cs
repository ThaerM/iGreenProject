using iGreen.Model;
using System;
using Xamarin.Essentials;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace iGreen
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class ItemPage : ContentPage
    {
        public ItemPage(HomeDataModel nameItem)
        {
            InitializeComponent();
            this.BindingContext = nameItem;
        }

        private async void ListView_ItemTapped(object sender, ItemTappedEventArgs e)
        {
            var result = (FactoryDataModel)e.Item;
            if (result != null)

            {
                var requst = string.Format("http://maps.google.com/?daddr=" + result.NameStreet + "&sll=" + result.letudeLocation + "," + result.longtudeLoacation + "");
                if (await Launcher.CanOpenAsync(new Uri(requst)))
                {
                    await Launcher.OpenAsync(new Uri(requst));
                }
            }
            ((ListView)sender).SelectedItem = null;
        }
    }
}