using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace ThemeParkDatabase.Data
{
    public class DeletionRequest
    {
        public int Id { get; set; }
        [Required]
        [MaxLength(50)]
        public string TableName { get; set; }
        public int TableId { get; set; }
        public DateTime DateRequested { get; set; }
    }
}
