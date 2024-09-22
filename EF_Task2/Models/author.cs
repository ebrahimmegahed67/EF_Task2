using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EF_Task2.Models
{
    internal class author
    {
        [Key]
        public int autId { set; get; }
        [MaxLength(100)]
        public string name { set; get; }
        
        public int age { set; get; }
        [MaxLength(100)]
        public string userName { set; get; }
        [MaxLength(100)]
        public string password { set; get; }
        public DateTime joinDate { set; get; }
        public List<news> newss { set; get; }
    }
}
