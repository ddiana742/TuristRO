using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TuristRO.Models;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace TuristRO.Views.FavoriteView
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class ModificareFavorite : ContentPage
    {
        public ModificareFavorite()
        {
            InitializeComponent();
        }
        async void OnSaveButtonClicked(object sender, EventArgs e)
        {
            var note = (FavoriteModels)BindingContext;

            await App.Database.SaveNoteAsync(note);
            await Navigation.PopAsync();
        }
        async void OnDeleteButtonClicked(object sender, EventArgs e)
        {
            var note = (FavoriteModels)BindingContext;
            await App.Database.DeleteNoteAsync(note);
            await Navigation.PopAsync();
        }
    }
}
