using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
        private List<Event> AllEvents { get; set; }
        //crearea unei liste cu evenimente muzicale
        private List<Event> GetEvents()
        {
            return new List<Event>()
            {
                new Event{ EventTitle = "Untold(1-4 august)" ,Poza="untold.jpg", Date = new DateTime(DateTime.Now.Ticks + new TimeSpan(31, 23, 45, 59).Ticks)},
              
                new Event{ EventTitle = "Electric Castle(17-21 iulie)",Poza="electric.jpg", Date = new DateTime(DateTime.Now.Ticks + new TimeSpan(18, 11, 15, 0).Ticks)},
                

                 new Event{ EventTitle = "Summer Well(7-9 august)",Poza="summerwell.jpg", Date = new DateTime(DateTime.Now.Ticks + new TimeSpan(32, 18, 29, 45).Ticks)},
                new Event{ EventTitle = "Neversea(7-9 iulie)",Poza="neversea2.jpg", Date = new DateTime(DateTime.Now.Ticks + new TimeSpan(7, 18, 29, 45).Ticks)},
               

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

    public class Event
    {
        public DateTime Date { get; set; }
        public string EventTitle { get; set; }
        public TimeSpan Timespan { get; set; }
        public string Days => Timespan.Days.ToString("00");
        public string Hours => Timespan.Hours.ToString("00");
        public string Minutes => Timespan.Minutes.ToString("00");
        public string Seconds => Timespan.Seconds.ToString("00");
        public string Imagine { get; set; }
        public string Poza { get; set; }
    }
}