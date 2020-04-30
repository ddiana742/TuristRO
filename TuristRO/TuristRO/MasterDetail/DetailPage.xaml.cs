using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TuristRO.Meniu;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace TuristRO.MasterDetail
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class DetailPage : ContentPage
    {
        public DetailPage()
        {
            InitializeComponent();
        }
        private async void Button_Clicked(object sender, EventArgs e) => await Navigation.PushAsync(new Obiective());
    }
}