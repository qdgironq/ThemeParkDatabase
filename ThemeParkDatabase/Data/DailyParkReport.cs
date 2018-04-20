using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ThemeParkDatabase.Data
{
    public class DailyParkReport
    {
        public int Id { get; set; }
        public int NumOfVisitors { get; set; }

        public Weather WeatherReport { get; set; }
    }
}
