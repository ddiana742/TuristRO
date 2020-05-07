using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Essentials;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace TuristRO.Views.Obiective
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Cazanele : ContentPage
    {
        public Cazanele()
        {
            InitializeComponent();
        }

        public async Task NavigateToBuilding25()
        {
            var location = new Location(45.2148042, 29.300725);
            var options = new MapLaunchOptions { Name = "Cazanele Dunării" };
            var options2 = new MapLaunchOptions { NavigationMode = NavigationMode.Bicycling };

            await Map.OpenAsync(location, options);
        }

        private async void Button_Clicked(object sender, EventArgs e)
        {
            await NavigateToBuilding25();
        }
        private async void Button_Clicked_1(object sender, EventArgs e) => await Navigation.PushAsync(new Favorite());

    }
}