using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using Xamarin.Essentials;

namespace MasterDetail
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    
    public partial class Maps : ContentPage
    {
        public Maps()
        {
            InitializeComponent();
        }




        /*
        private async void ButtonOpenCoords_Clicked(object sender, EventArgs e)
        {
            if (!double.TryParse(EntryLatitude.Text, out double lat))
                return;
            if (!double.TryParse(EntryLongitudte.Text, out double lng))
                return;
            await Maps.OpenAsync(lat, lng, new MapLaunchOptions
            {
                Name = EntryName.Text,
                NavigationMode = NavigationMode.None
            });
        }
        //xaml <Button Text="Open Coordonates" x:Name="ButtonOpenCoords" Clicked="ButtonOpenCoords_Clicked"/>

        */
        protected override async void OnAppearing()
        {
            base.OnAppearing();

            try
            {
                var lat = 45.9852129;
                var lon = 24.6859225;


                var placemarks = await Geocoding.GetPlacemarksAsync(lat, lon);

                var placemark = placemarks?.FirstOrDefault();
                if (placemark != null)
                {
                    var geocodeAddress =
                        $"AdminArea:       {placemark.AdminArea}\n" +
                        $"CountryCode:     {placemark.CountryCode}\n" +
                        $"CountryName:     {placemark.CountryName}\n" +
                        $"FeatureName:     {placemark.FeatureName}\n" +
                        $"Locality:        {placemark.Locality}\n" +
                        $"PostalCode:      {placemark.PostalCode}\n" +
                        $"SubAdminArea:    {placemark.SubAdminArea}\n" +
                        $"SubLocality:     {placemark.SubLocality}\n" +
                        $"SubThoroughfare: {placemark.SubThoroughfare}\n" +
                        $"Thoroughfare:    {placemark.Thoroughfare}\n";

                    Console.WriteLine(geocodeAddress);
                }
            }
            catch (FeatureNotSupportedException fnsEx)
            {
                // Feature not supported on device
            }
            catch (Exception ex)
            {
                // Handle exception that may have occurred in geocoding
            }
        }

        //protected override async void OnAppearing()
        //{
        //    base.OnAppearing();

        //    try
        //    {
        //        var request = new GeolocationRequest(GeolocationAccuracy.Medium);
        //        var location = await Geolocation.GetLocationAsync(request);

        //        if (location != null)
        //        {
        //            Console.WriteLine($"Latitude: {location.Latitude}, Longitude: {location.Longitude}, Altitude: {location.Altitude}");
        //        }
        //    }
        //    catch (FeatureNotSupportedException fnsEx)
        //    {
        //        // Handle not supported on device exception
        //    }
        //    catch (FeatureNotEnabledException fneEx)
        //    {
        //        // Handle not enabled on device exception
        //    }
        //    catch (PermissionException pEx)
        //    {
        //        // Handle permission exception
        //    }
        //    catch (Exception ex)
        //    {
        //        // Unable to get location
        //    }

        //}

        public async Task NavigateToBuilding25()
        {
            var location = new Location(45.9852129, 24.6859225);
            var options = new MapLaunchOptions { Name = "Romania" };
            // var options = new MapLaunchOptions { NavigationMode = NavigationMode.Bicycling};

            await Map.OpenAsync(location, options);
        }

        async void OnButtonClicked(object sender, EventArgs e)
        {

            await NavigateToBuilding25();

        }


    }
}