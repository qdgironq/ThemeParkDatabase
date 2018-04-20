using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace ThemeParkDatabase.Data
{
    public class Employee
    {
        public int Id { get; set; }
        [Required]
        [MaxLength(50)]
        public string FirstName { get; set; }
        [Required]
        [MaxLength(1)]
        public string MiddleInitial { get; set; }
        [Required]
        [MaxLength(50)]
        public string LastName { get; set; }
        [Required]
        [MaxLength(200)]
        public string Title { get; set; }
        public DateTime HireDate { get; set; }
        public decimal Salary { get; set; }

        public int DepartmentId { get; set; }
        public Department Department { get; set; }
    }
}
