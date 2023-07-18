using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EFsecond.Models
{
    internal class Bank_Of_Baroda : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Data Source=(localdb)\ProjectModels;Initial Catalog=Bank_Of_Baroda;Integrated Security=True");
        }

        public DbSet<Store1> Store1 { get; set; }
        public DbSet<Store2> Store2 { get; set; }

    }
}
