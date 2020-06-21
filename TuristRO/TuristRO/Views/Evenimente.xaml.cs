using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TuristRO.Models;
using TuristRO.ViewModel;
using TuristRO.Views.Evenimente;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace TuristRO.Meniu
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Evenimente : ContentPage
    {
        public Evenimente()
        {
            InitializeComponent();
            // Setup();
            BindingContext = new EvenimenteViewModel();
        }
       

        private async void ObiectiveListView_ItemTapped(object sender, ItemTappedEventArgs e)
        {
            var myselecteditem = e.Item as EvenimenteModels;
            switch (myselecteditem.id)
            {
                case 1:
                    await Navigation.PushAsync(new Muzica());
                    break;
                case 2:
                    await Navigation.PushAsync(new Film());
                    break;
                case 3:
                    await Navigation.PushAsync(new Teatru());
                    break;
                case 4:
                    await Navigation.PushAsync(new Arta());
                    break;   
            }
            ((ListView)sender).SelectedItem = null;
        }      
    }
}

       



        