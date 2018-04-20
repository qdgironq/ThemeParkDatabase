using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace ThemeParkDatabase.Data
{
    public class MaintenanceRequest
    {
        public int Id { get; set; }
        [Required]
        public string Description { get; set; }
        public DateTime DateRequested { get; set; }
        public DateTime? DateResolved { get; set; }
        [Required]
        public string CurrentStatus { get; set; }
        public decimal EstimatedCost { get; set; }

        public int AttractionId { get; set; }
        public Attraction Attraction { get; set; }
    }
}
