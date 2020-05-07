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
    public partial class Film : ContentPage
    {
        public Film()
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
                new EventModels{ EventTitle = "BIEFF (Bucharest International Experimental Film Festival)(septembrie)" ,Poza="bieff.jpg", Date = new DateTime(DateTime.Now.Ticks + new TimeSpan(62, 23, 45, 59).Ticks)},

                new EventModels{ EventTitle = "Les films de Cannes à Bucarest(14 – 25 septembrie)",Poza="cannes.jpg", Date = new DateTime(DateTime.Now.Ticks + new TimeSpan(70, 11, 15, 0).Ticks)},


                 new EventModels{ EventTitle = "ASTRA (Festivalul Internațional de Film documentar)(octombrie)",Poza="astra.jpg", Date = new DateTime(DateTime.Now.Ticks + new TimeSpan(97, 18, 29, 45).Ticks)},
                new EventModels{ EventTitle = "Lună Plină – Festivalul Filmului Horror și Fantastic(8 – 11 august)",Poza="horror.jpg", Date = new DateTime(DateTime.Now.Ticks + new TimeSpan(34, 20, 29, 45).Ticks)},


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