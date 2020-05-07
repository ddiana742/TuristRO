using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TuristRO.Models;
using TuristRO.Views.FavoriteView;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace TuristRO.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Favorite : ContentPage
    {
        public Favorite()
        {
            InitializeComponent();
        }
        protected override async void OnAppearing()
        {
            base.OnAppearing();
            listView.ItemsSource = await App.Database.GetNotesAsync();
        }
        async void OnNoteAddedClicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new ModificareFavorite
            {
                BindingContext = new FavoriteModels()
            });
        }
        async void OnListViewItemSelected(object sender, SelectedItemChangedEventArgs e)
        {
            if (e.SelectedItem != null)
            {
                await Navigation.PushAsync(new ModificareFavorite
                {
                    BindingContext = e.SelectedItem as FavoriteModels
                });
            }
        }
    }
}