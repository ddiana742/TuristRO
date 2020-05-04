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
    public partial class Sighisoara : ContentPage
    {
        public Sighisoara()
        {
            InitializeComponent();
        }

        public async Task NavigateToBuilding25()
        {
            var location = new Location(46.2201975, 24.7934573);
            var options = new MapLaunchOptions { Name = "Sighisoara" };
            // var options2 = new MapLaunchOptions { NavigationMode = NavigationMode.Bicycling};

            await Map.OpenAsync(location, options);
        }
        private async void Button_Clicked(object sender, EventArgs e)
        {
            await NavigateToBuilding25();
        }
    }
}