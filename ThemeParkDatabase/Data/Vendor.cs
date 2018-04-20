﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace ThemeParkDatabase.Data
{
    // Test git comment
    public class Vendor
    {
        public Vendor()
        {
            VendorSalesReports = new HashSet<VendorSalesReport>();
        }

        public int Id { get; set; }
        [Required]
        [MaxLength(50)]
        public string Name { get; set; }
        [Required]
        public string Description { get; set; }

        public int LocationId { get; set; }
        public Location Location { get; set; }

        public virtual ICollection<VendorSalesReport> VendorSalesReports { get; set; }
    }
}
