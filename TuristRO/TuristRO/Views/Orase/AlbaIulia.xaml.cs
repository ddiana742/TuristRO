using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TuristRO.ViewModel;
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
            BindingContext = new OraseViewModel();
        }
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