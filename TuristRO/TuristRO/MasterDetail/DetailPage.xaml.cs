using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Timers;
using TuristRO.Meniu;
using TuristRO.Models;

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
            this.BindingContext = this;
        }
 
        public List<BannerModel> Banners { get => GetBanners(); }
        private System.Timers.Timer time; // obiect pentru realizarea timerului evenimentelor
        private async void Button_Clicked(object sender, EventArgs e) => await Navigation.PushAsync(new Obiective());
        private List<BannerModel> GetBanners() //elementele banner-ului
        {
            var bannerList = new List<BannerModel>();
            bannerList.Add(new BannerModel { Heading = "", Image = "rom1.jpeg" });
            bannerList.Add(new BannerModel { Heading = "", Image = "rom2.jpg" });
            bannerList.Add(new BannerModel { Heading = "", Image = "rom3.jpg" });
            bannerList.Add(new BannerModel { Heading = "", Image = "rom4.jpg" });
            bannerList.Add(new BannerModel { Heading = "", Image = "romania7.jpg" });
            bannerList.Add(new BannerModel { Heading = "", Image = "romania3.jpg" });
            return bannerList;
        }
        protected override void OnAppearing()
        {
            //durata aparitiei pozei
            time = new System.Timers.Timer(TimeSpan.FromSeconds(3).TotalMilliseconds) { AutoReset = true, Enabled = true }; //durata aparitiei imaginii
            time.Elapsed += Timer_Elapsed;
            base.OnAppearing();
        }

        protected override void OnDisappearing()
        {
            time?.Dispose();
            base.OnDisappearing();
        }

        private void Timer_Elapsed(object sender, ElapsedEventArgs e) //procesul de afisare
        {
            Device.BeginInvokeOnMainThread(() =>
            {

                if (cvBanners.Position == 5)
                {
                    cvBanners.Position = 0;
                    return;
                }

                cvBanners.Position += 1;
            });
        }

    }
} 