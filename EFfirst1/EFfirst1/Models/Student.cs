using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.ComponentModel.DataAnnotations;
using System.Text;
using System.Threading.Tasks;

namespace EFfirst1.Models
{
    internal class Student
    {
        [Key]
        public int StudentId { get; set; }
        public string? FirstName { get; set;}
        public DateTime? DateOfBirth { get; set; }
        public string? LastName { get; set;}
        public string? Photo { get; set; }
        public decimal? Height { get; set; }
        public float? weight { get; set; }

        [ForeignKey("Grade")]
        public int? GradeId { get; set; }
        public Grade? Grade { get; set;}
    }
}
