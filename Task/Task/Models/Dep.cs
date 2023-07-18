using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task.Models
{
    public class Dep
    {
        [Key]
        public int Id { get; set; }
        public string depName { get; set; }

    }
}
