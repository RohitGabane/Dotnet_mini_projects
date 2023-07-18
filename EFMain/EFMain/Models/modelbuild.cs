using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EFMain.Models
{
    public static class modelbuild
    {
       public static void seed(this ModelBuilder modelBuilder)
       {
            modelBuilder.Entity<Employee>().HasData(
                new Employee()
                {
                    empId = 1,
                    Firstname = "Rohit",
                    Lastname = "Gabane",
                    Mobile = 8888421183,
                    Salary = 570000,
                    DepartmentId = 1
                },
                 new Employee()
                 {
                     empId = 2,
                     Firstname = "Mayank",
                     Lastname = "Kapoor",
                     Mobile = 9011596791,
                     Salary = 970000,
                     DepartmentId = 2
                 },
                  new Employee()
                  {empId = 3,
                      Firstname = "Mukunda",
                      Lastname = "Patil",
                      Mobile = 8975463210,
                      Salary = 670000,
                      DepartmentId = 3
                  }, new Employee()
                  {empId = 4,
                      Firstname = "Hrushi",
                      Lastname = "Jawale",
                      Mobile = 7896541283,
                      Salary = 270000,
                      DepartmentId = 4
                  }, new Employee()
                  {empId = 5,
                      Firstname = "Satish",
                      Lastname = "Patil",
                      Mobile = 8965321475,
                      Salary = 480000,
                      DepartmentId = 5
                  }, new Employee()
                  {empId = 6,
                      Firstname = "Suraj",
                      Lastname = "Rana",
                      Mobile = 8521479635,
                      Salary = 330000,
                      DepartmentId = 6
                  }, new Employee()
                  {empId = 7,
                      Firstname = "Aniket",
                      Lastname = "hurde",
                      Mobile = 8632145975,
                      Salary = 420000,
                      DepartmentId = 7
                  }, new Employee()
                  {empId = 8,
                      Firstname = "Akash",
                      Lastname = "Digwa",
                      Mobile = 8965472319,
                      Salary = 170000,
                      DepartmentId = 8
                  }, new Employee()
                  {empId = 9,
                      Firstname = "Sandeep",
                      Lastname = "Chikya",
                      Mobile = 9514783628,
                      Salary = 530000,
                      DepartmentId = 9
                  }, new Employee()
                  {empId = 10,
                      Firstname = "vivek",
                      Lastname = "bhatt",
                      Mobile = 7895463254,
                      Salary = 630000,
                      DepartmentId = 10
                  }
                          
                      );


        }
        public static void Nord(this ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Department>().HasData(
                //new Department()
                //{
                //    Id = 1,
                //    DepName = "it",
                //    Email = "it@gmail.com"
                //},
                new Department()

                                {
                                    Id = 2,
                    DepName = "it",
                    Email = "it@gmail.com"
                },
                 new Department()

                 {
                     Id = 3,
                     DepName = "it",
                     Email = "it@gmail.com"
                 },
                new Department()
                {
                Id = 4,
                    DepName = "it",
                    Email = "it@gmail.com"
                },
                new Department()
                {
                Id = 5,
                    DepName = "it",
                    Email = "it@gmail.com"
                },
                new Department()
                {
                Id = 6,
                    DepName = "it",
                    Email = "it@gmail.com"
                },
                new Department()
                {
                Id = 1,
                    DepName = "it",
                    Email = "it@gmail.com"
                },
                new Department()
                {
                Id = 7,
                    DepName = "it",
                    Email = "it@gmail.com"
                },
                new Department()
                {
                Id = 8,
                    DepName = "it",
                    Email = "it@gmail.com"
                },
                new Department()
                {
                Id = 9,
                    DepName = "it",
                    Email = "it@gmail.com"
                },
                new Department()
                {
                Id = 10,
                    DepName = "it",
                    Email = "it@gmail.com"
                }
                );
        }

    }
}
