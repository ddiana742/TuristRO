using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TuristRO.Views.Evenimente;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace TuristRO.Meniu
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class LogOut : ContentPage
    {
        public LogOut()
        {
            InitializeComponent();
        }

        private async void Button_Clicked(object sender, EventArgs e) => await Navigation.PushAsync(new Muzica());
    }
}