using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ThemeParkDatabase.Data
{
    public class Weather
    {
        public int Id { get; set; }
        public DateTime Date { get; set; }
        public bool Rainout { get; set; }
        public float Temperature { get; set; }
        public float InchesOfRain { get; set; }

        public int DailyParkReportId { get; set; }
        public DailyParkReport DailyParkReport { get; set; }
    }
}
