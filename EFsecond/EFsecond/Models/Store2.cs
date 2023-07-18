using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EFsecond.Models
{
    internal class Store2
    {
        [Key]
        public int ID { get; set; }
        public string? StoreName { get; set; }
        public string? Section { get; set; }
        [ForeignKey("StoreId")]
        public IList<Store1> Store1 { get; set; } = new List<Store1>();
    }
}
