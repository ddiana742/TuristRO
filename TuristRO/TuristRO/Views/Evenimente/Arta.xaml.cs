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
    public partial class Arta : ContentPage
    {
        public Arta()
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
                new EventModels{ EventTitle = "Spotlight Festival(septembrie)" ,Poza="spotlight.jpg", Date = new DateTime(DateTime.Now.Ticks + new TimeSpan(62, 23, 45, 59).Ticks)},

                new EventModels{ EventTitle = "Bucharest Photofest(1 – 12 octombrie)",Poza="photofest.jpg", Date = new DateTime(DateTime.Now.Ticks + new TimeSpan(92, 11, 15, 0).Ticks)},


                 new EventModels{ EventTitle = "iMapp Bucharest(septembrie)",Poza="imappbuc.jpg", Date = new DateTime(DateTime.Now.Ticks + new TimeSpan(58, 18, 29, 45).Ticks)},
                new EventModels{ EventTitle = "Bookfest(5 – 8 septembrie)",Poza="bookfest.jpg", Date = new DateTime(DateTime.Now.Ticks + new TimeSpan(63, 20, 29, 45).Ticks)},


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