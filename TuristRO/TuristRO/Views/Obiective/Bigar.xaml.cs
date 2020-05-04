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
    public partial class Bigar : ContentPage
    {
        public Bigar()
        {
            InitializeComponent();
        }

        public async Task NavigateToBuilding25()
        {
            var location = new Location(45.0034584, 21.9593945);
            var options = new MapLaunchOptions { Name = "Cascada Bigăr" };
            var options2 = new MapLaunchOptions { NavigationMode = NavigationMode.Bicycling };

            await Map.OpenAsync(location, options);
        }
        private async void Button_Clicked(object sender, EventArgs e)
        {
            await NavigateToBuilding25();
        }
    }
}