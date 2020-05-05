using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using Xamarin.Essentials;
namespace MasterDetail
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class City6 : ContentPage
    {
        public City6()
        {
            InitializeComponent();
        }
        public async Task NavigateToBuilding25()
        {
            var location = new Location(44.1767161, 28.6507598);
            var options = new MapLaunchOptions { Name = "Constanta" };
            // var options = new MapLaunchOptions { NavigationMode = NavigationMode.Bicycling};

            await Map.OpenAsync(location, options);
        }
        private async void Button_Clicked(object sender, EventArgs e)
        {
            await NavigateToBuilding25();
        }
    }
}