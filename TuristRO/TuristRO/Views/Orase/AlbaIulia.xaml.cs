using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TuristRO.ViewModel;
using Xamarin.Essentials;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;


namespace TuristRO.Views.Orase
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class AlbaIulia : ContentPage
    {
        public AlbaIulia()
        {
            InitializeComponent();
           
        }

        public async Task NavigateToBuilding25()
        {
            var location = new Location(46.0687385, 23.5704398);
            var options = new MapLaunchOptions { Name = "Alba-Iulia" };
            // var options2 = new MapLaunchOptions { NavigationMode = NavigationMode.Bicycling};

            await Map.OpenAsync(location, options);
        }
        private async void Button_Clicked(object sender, EventArgs e)
        {
            await NavigateToBuilding25();
        }

        private async void Button_Clicked_1(object sender, EventArgs e) => await Navigation.PushAsync(new Favorite());
       

        /*
private void RatingConception_Voted(object sender, EventArgs e)
{
RatingConception rating = (RatingConception)sender;
int index = rating.IndexVoted;
int value = rating.Value;

index_star.Text = index.ToString();
value_star.Text = value.ToString();

// rating.InitialValue = 2; sobres así se asigna por default e buen rating
} */
    }
}