using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TuristRO.Models;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace TuristRO.Views.Evenimente
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Teatru : ContentPage
    {
        public Teatru()
        {
            InitializeComponent();
            Setup();
        }
        private List<EventModels> AllEvents { get; set; }
        //crearea unei liste cu evenimente muzicale
        private List<EventModels> GetEvents()
        {
            return new List<EventModels>()
            {
                new EventModels{ EventTitle = "FITS (Festivalul Internațional de Teatru de la Sibiu)" ,Poza="fits.jpg", Date = new DateTime(DateTime.Now.Ticks + new TimeSpan(50, 23, 45, 59).Ticks)},

                new EventModels{ EventTitle = "Ideo Ideis – Festivalul Național de Teatru Tânăr(august)",Poza="ideo.jpg", Date = new DateTime(DateTime.Now.Ticks + new TimeSpan(33, 11, 15, 0).Ticks)},


                 new EventModels{ EventTitle = "Bucharest Fringe(29 septembrie-7 octombrie 2018)",Poza="buc.jpg", Date = new DateTime(DateTime.Now.Ticks + new TimeSpan(98, 18, 29, 45).Ticks)},
                new EventModels{ EventTitle = "B-Fit in the Street(13 iulie-5 august)",Poza="bfit.jpg", Date = new DateTime(DateTime.Now.Ticks + new TimeSpan(15, 14, 29, 45).Ticks)},


            };
        }
        //setarea evenimentului de countdown
        private void Setup()
        {
            AllEvents = GetEvents();
            eventList.ItemsSource = AllEvents;

            Device.StartTimer(new TimeSpan(0, 0, 1), () =>
            {
                foreach (var evt in AllEvents)
                {
                    var timespan = evt.Date - DateTime.Now;
                    evt.Timespan = timespan;
                }

                eventList.ItemsSource = null;
                eventList.ItemsSource = AllEvents;

                return true;
            });
        }
    }

}