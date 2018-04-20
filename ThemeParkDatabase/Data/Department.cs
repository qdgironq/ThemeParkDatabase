using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace ThemeParkDatabase.Data
{
    public class Department
    {
        public int Id { get; set; }
        [Required]
        [MaxLength(255)]
        public string Name { get; set; }

        public int LocationId { get; set; }
        public Location Location { get; set; }  

        public virtual ICollection<Employee> Employees { get; set; }

        public Employee Manager { get; set; }
    }
}
