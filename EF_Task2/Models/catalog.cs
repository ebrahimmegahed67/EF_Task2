using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EF_Task2.Models
{
    internal class catalog
    {
        [Key]
        public int id { get; set; }
        [MaxLength(100)]
        public string name { get; set; }
        [MaxLength(100)]
        public string description { get; set; }
        public List<news> newss { get; set; }

    }
}
