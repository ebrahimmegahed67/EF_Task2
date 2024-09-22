using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EF_Task2.Models
{
    internal class news
    {
        [Key]
        public int newId {  get; set; }
        [MaxLength(100)]
        public string title {  get; set; }
        [MaxLength(100)]
        public string descriptionNews { get; set; }
        [MaxLength(100)]
        public string bref {  get; set; }
        public int time { get; set; }
        public DateTime date { get; set; }
        [ForeignKey("author")]
        public int authId { get; set; }
        [ForeignKey("catlog")]
        public int catId { get; set; }

        public catalog catlog { get; set; }
        public author author { get; set; }
    }
}
