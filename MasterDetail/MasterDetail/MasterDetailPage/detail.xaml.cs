using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace MasterDetail
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class detail : ContentPage
    {
        public detail()
        {
            
            InitializeComponent();
            
        }

        private async void Button_Clicked(object sender, EventArgs e) => await Navigation.PushAsync(new Page2());
    }
}