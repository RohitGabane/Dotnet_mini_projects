using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task.Models
{
    public class emp
    {
        [Key]
        public int empid
        { get; set; }
        [Required]
        [StringLength(10)]
        public string name { get; set; }
        [Required]
        public float Salary { get; set; }
        public string city { get; set; }
        public int DepId { get; set; }
    }
}
