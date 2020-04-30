
using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using TuristRO.ViewModel;
using TuristRO.Views.Orase;
using TuristRO.Models;
using System.Linq;

namespace TuristRO.Meniu
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Orase : ContentPage
    {
        public Orase()
        {
            InitializeComponent();
            BindingContext = new OraseViewModel();
        }


        private async void ListView_ItemTapped(object sender, ItemTappedEventArgs e)
        {
            var myselecteditem = e.Item as OraseModels;
            switch (myselecteditem.ID)
            {
                case 1:
                    await Navigation.PushAsync(new AlbaIulia());
                    break;
                case 2:
                    await Navigation.PushAsync(new Sibiu());
                    break;
                case 3:
                    await Navigation.PushAsync(new Constanta());
                    break;
                case 4:
                    await Navigation.PushAsync(new Brasov());
                    break;
                case 5:
                    await Navigation.PushAsync(new Cluj());
                    break;
                case 6:
                    await Navigation.PushAsync(new Hunedoara());
                    break;
                case 7:
                    await Navigation.PushAsync(new Suceava());
                    break;
                case 8:
                    await Navigation.PushAsync(new Iasi());
                    break;
                case 9:
                    await Navigation.PushAsync(new Oradea());
                    break;
                case 10:
                    await Navigation.PushAsync(new Bucuresti());
                    break;
                case 11:
                    await Navigation.PushAsync(new Timisoara());
                    break;
                case 12:
                    await Navigation.PushAsync(new Sighisoara());
                    break;

            }
            ((ListView)sender).SelectedItem = null;
        }

        private void SearchBar_TextChanged(object sender, TextChangedEventArgs e)
        {
            var _container = BindingContext as OraseViewModel;
            OraseListView.BeginRefresh();

            if (string.IsNullOrWhiteSpace(e.NewTextValue))
                OraseListView.ItemsSource = _container.ListCollector;
            else
                OraseListView.ItemsSource = _container.ListCollector.Where(i => i.Nume.Contains(e.NewTextValue));
            OraseListView.EndRefresh();
        }

    }
}