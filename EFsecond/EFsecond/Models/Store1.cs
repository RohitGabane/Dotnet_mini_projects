using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EFsecond.Models
{
    internal class Store1
    {
        [Key]

        public int Store1tId { get; set; }
        public string? City { get; set; }
        public string? LastName { get; set; }

        public DateTime? Dateopening { get; set; }
        public string? Photo { get; set; }

        [ForeignKey("Store")]
        public int? StoreId { get; set; }
        public Store2? Store2 { get; set; }

    }
}
