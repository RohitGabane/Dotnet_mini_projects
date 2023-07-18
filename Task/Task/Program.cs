using System.Security.Cryptography.X509Certificates;
using Task.Models;

namespace Task
{
    internal class Program
    {
        static void Main(string[] args)
        {

            // All employee
            var context = new Task1();
            List<emp> list=context.emp.Select(x => x).ToList();
            Console.WriteLine("------------------------------------------------------------");
            Console.WriteLine("****** Display all employee ******");
            foreach (emp x in list) 
            {
                Console.WriteLine($"Id:{x.empid},Name: {x.name},Salary: {x.Salary},city: {x.city}");
                Console.WriteLine("------------------------------------------------------------");

            }

            //Total Numbers of employee
            Console.WriteLine();
            int count=context.emp.Count();
            Console.WriteLine("------------------------------------------------------------");
            Console.WriteLine($"**** Total number of employee is **** : {count}\n\n");
            Console.WriteLine("------------------------------------------------------------");

            //Q2. Display all employee department wise Salary

            var result = from x in context.emp
                         join d in context.Dep
                         on x.DepId equals d.Id
                         group x.Salary by d.depName into k
                         select new { Dep = k.Key, TotalSalary = k.Sum() };
            foreach (var x in result)
            {
                Console.WriteLine("------------------------------------------------------------");
                Console.WriteLine(x.Dep+" "+x.TotalSalary);
                Console.WriteLine("------------------------------------------------------------");

            }

        }
    }
}