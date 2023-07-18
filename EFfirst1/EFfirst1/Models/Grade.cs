using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EFfirst1.Models
{
    internal class Grade
    {
        [Key]
        public int ID { get; set; }
        public string? GradeName { get; set; }
        public string? Section { get; set; }
        [ForeignKey("GradeId")]
        public IList<Student> Students { get; set; } = new List<Student>();
    }
}
