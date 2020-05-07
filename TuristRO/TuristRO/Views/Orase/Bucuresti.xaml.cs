using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Essentials;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace TuristRO.Views.Orase
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Bucuresti : ContentPage
    {
        public Bucuresti()
        {
            InitializeComponent();
        }

        public async Task NavigateToBuilding25()
        {
            var location = new Location(44.439663, 26.096306);
            var options = new MapLaunchOptions { Name = "Bucuresti" };
            // var options2 = new MapLaunchOptions { NavigationMode = NavigationMode.Bicycling};

            await Map.OpenAsync(location, options);
        }
        private async void Button_Clicked(object sender, EventArgs e)
        {
            await NavigateToBuilding25();
        }
        private async void favorite_Clicked(object sender, EventArgs e) => await Navigation.PushAsync(new Favorite());

    }

}