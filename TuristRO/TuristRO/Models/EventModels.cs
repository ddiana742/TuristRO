using System;
using System.Collections.Generic;
using System.Text;

namespace TuristRO.Models
{
   public class EventModels
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
