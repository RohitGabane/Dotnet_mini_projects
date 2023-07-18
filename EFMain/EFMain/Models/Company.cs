using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EFMain.Models
{
    public class Company :DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Data Source=(localdb)\ProjectModels;Initial Catalog=Company;Integrated Security=True");
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        { 
            modelBuilder.seed();
            modelBuilder.Nord();
        }

       public DbSet<Department> Department{ get;  }
        public DbSet<Employee> Employee { get; }
    }


}
