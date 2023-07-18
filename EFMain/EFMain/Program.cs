using EFMain.Models;

namespace EFMain
{
    internal class Program
    {
        static void Main(string[] args)
        {
            EmployeeLayer emp = new EmployeeLayer();

            List<Employee> sl = emp.GetAll();

            sl.ForEach(item =>
            {
                Console.WriteLine($"{item.Firstname} {item.Lastname}");
            });
           

           /* int id = 3;
            studentLayer.DeleteStudent(id);*/

           
        }

    }


}