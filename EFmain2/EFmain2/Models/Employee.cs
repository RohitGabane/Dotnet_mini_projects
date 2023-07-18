using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EFmain2.Models
{
    public class Employee
    {
        [Key]
        public int empId { get; set; }

        [MaxLength(8)]
        [Required]
        public string Firstname { get; set; }
        public string Lastname { get; set; }

        [MaxLength(10)]
        [Required]
        public long Mobile { get; set; }

        [NotMapped]
        public string FullName => $"{Firstname} {Lastname}";

        [MinLength(10)]
        public float Salary { get; set; }
        public int DepartmentId { get; set; }

    }
}
