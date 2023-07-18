using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EFmain2.Models
{
    public class Department
    {
        [Key]
        public int Id { get; set; }
        public string DepName { get; set; }
        public string Email { get; set; }
        public List<Employee> Employees { get; set; }
    }
}
