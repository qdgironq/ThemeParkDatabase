using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ThemeParkDatabase.Data
{
    public class AttractionVisit
    {
        public int Id { get; set; }
        public DateTime Time { get; set; }

        public int AttractionId { get; set; }
        public Attraction Attraction { get; set; }
    }
}
