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
    public partial class Muzica : ContentPage
    {
        public Muzica()
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
                new EventModels{ EventTitle = "Untold(1-4 august)" ,Poza="untold.jpg", Date = new DateTime(DateTime.Now.Ticks + new TimeSpan(31, 23, 45, 59).Ticks)},
              
                new EventModels{ EventTitle = "Electric Castle(17-21 iulie)",Poza="electric.jpg", Date = new DateTime(DateTime.Now.Ticks + new TimeSpan(18, 11, 15, 0).Ticks)},
                

                 new EventModels{ EventTitle = "Summer Well(7-9 august)",Poza="summerwell.jpg", Date = new DateTime(DateTime.Now.Ticks + new TimeSpan(32, 18, 29, 45).Ticks)},
                new EventModels{ EventTitle = "Neversea(7-9 iulie)",Poza="neversea2.jpg", Date = new DateTime(DateTime.Now.Ticks + new TimeSpan(7, 18, 29, 45).Ticks)},
               

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