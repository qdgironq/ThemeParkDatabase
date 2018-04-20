using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace ThemeParkDatabase.Data
{
    public class VendorSalesReport
    {
        public int Id { get; set; }
        [DisplayFormat(ApplyFormatInEditMode = true, DataFormatString = "{MM/dd/yyyy}")]
        public DateTime Date { get; set; }
        public decimal TotalSales { get; set; } // Display with 2 decimal places
        public decimal SalesGoal { get; set; } // Display with 2 decimal places

        public int VendorId { get; set; }
        public Vendor Vendor { get; set; }
    }
}
