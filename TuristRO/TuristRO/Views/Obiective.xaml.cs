using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TuristRO.Models;
using TuristRO.ViewModel;
using TuristRO.Views.Obiective;
using TuristRO.Views.Orase;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace TuristRO.Meniu
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Obiective : ContentPage
    {
        public Obiective()
        {
            InitializeComponent();
            BindingContext = new ObiectiveViewModel();
        }

    
        //bara de cautare in functie de nume
        private void SearchBar_TextChanged(object sender, TextChangedEventArgs e)
        {
            var _container = BindingContext as ObiectiveViewModel;
            ObiectiveListView.BeginRefresh();

            if (string.IsNullOrWhiteSpace(e.NewTextValue))
                ObiectiveListView.ItemsSource = _container.List2Collector;
            else
                ObiectiveListView.ItemsSource = _container.List2Collector.Where(i => i.Nume.Contains(e.NewTextValue));
            ObiectiveListView.EndRefresh();
        }
        //dechiderea paginii item-ului selectat
        private async void ObiectiveListView_ItemTapped(object sender, ItemTappedEventArgs e)
        {
            var myselecteditem = e.Item as ObiectiveModels;
            switch (myselecteditem.id)
            {
                case 1:
                    await Navigation.PushAsync(new CascadaCailor());
                    break;
                case 2:
                    await Navigation.PushAsync(new SfantaAna());
                    break;
                case 3:
                    await Navigation.PushAsync(new FoculViu());
                    break;
                case 4:
                    await Navigation.PushAsync(new Delta());
                    break;
                case 5:
                    await Navigation.PushAsync(new Transfagarasan());
                    break;
                case 6:
                    await Navigation.PushAsync(new Bigar());
                    break;
                case 7:
                    await Navigation.PushAsync(new CimitirulVesel());
                    break;
                case 8:
                    await Navigation.PushAsync(new SalinaTurda());
                    break;
                case 9:
                    await Navigation.PushAsync(new Cazanele());
                    break;
                case 10:
                    await Navigation.PushAsync(new Peles());
                    break;
                case 11:
                    await Navigation.PushAsync(new Mocanita());
                    break;

            }
            ((ListView)sender).SelectedItem = null;
        }
    }
}