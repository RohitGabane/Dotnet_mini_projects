using EFfirst1.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Migrations.Operations;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EFfirst1.Models
{
    internal class Bank_Of_Baroda:DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Data Source=(localdb)\ProjectModels;Initial Catalog=Bank_Of_Baroda;Integrated Security=True");
        }

        public DbSet<Student> Student { get; set; }
        public DbSet<Grade> Grade { get; set; }
        
    }

}

