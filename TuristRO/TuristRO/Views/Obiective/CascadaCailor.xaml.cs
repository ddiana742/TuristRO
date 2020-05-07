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
    public partial class CascadaCailor : ContentPage
    {
        public CascadaCailor()
        {
            InitializeComponent();
        }
        public async Task NavigateToBuilding25()
        {
            var location = new Location(47.5902714, 24.8022593);
            var options = new MapLaunchOptions { Name = "Cascada Cailor" };
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