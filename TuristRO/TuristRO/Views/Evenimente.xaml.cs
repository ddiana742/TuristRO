using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace TuristRO.Meniu
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Evenimente : ContentPage
    {
        public Evenimente()
        {
            InitializeComponent();
            Setup();
        }
        private List<Event> AllEvents { get; set; }

        private List<Event> GetEvents()
        {
            return new List<Event>()
            {
                new Event{ EventTitle = "Untold" ,Poza="untold.jpg", Date = new DateTime(DateTime.Now.Ticks + new TimeSpan(12, 23, 45, 59).Ticks)},
                new Event{ EventTitle = "TIFF",Poza="tiff.jpg", Date = new DateTime(DateTime.Now.Ticks + new TimeSpan(27, 1, 22, 10).Ticks)},
                new Event{ EventTitle = "Electric Castle",Poza="electric.jpg", Date = new DateTime(DateTime.Now.Ticks + new TimeSpan(48, 11, 15, 0).Ticks)},
                new Event{ EventTitle = "ASTRA ",Poza="astra.jpg", Date = new DateTime(DateTime.Now.Ticks + new TimeSpan(2, 18, 29, 45).Ticks)},
                 new Event{ EventTitle = "Sibiu Jazz Festival",Poza="jazz.jpg", Date = new DateTime(DateTime.Now.Ticks + new TimeSpan(2, 18, 29, 45).Ticks)},
                new Event{ EventTitle = "Concursul Internațional George Enescu",Poza="georgeenescu.jpg", Date = new DateTime(DateTime.Now.Ticks + new TimeSpan(2, 18, 29, 45).Ticks)},
                new Event{ EventTitle = "FITS ", Date = new DateTime(DateTime.Now.Ticks + new TimeSpan(2, 18, 29, 45).Ticks), Poza="fits.jpg"},

            };
        }

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