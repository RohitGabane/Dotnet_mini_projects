using EFsecond.Models;
using static EFsecond.Models.StoreLayer;

namespace EFsecond
{
    internal class Program
    {
        static void Main(string[] args)
        {
            StudentLayer studentLayer = new StudentLayer();

            List<Store1> sl = studentLayer.GetAll();

            sl.ForEach(item =>
            {
                Console.WriteLine($"{item.LastName} {item.City}" + $" {item.StoreId}");
            });


            //insert
            Store1 s1 = new Store1()
            {
                StoreId = 2,
                LastName = "Jonty",
                City = "Dubai",
               
            };

            studentLayer.AddStudent(s1);

            //delete
              int id = 11;
              studentLayer.DeleteStudent(id);


            //update
              int sid = 1;
              Store1 s = new Store1()

              {
                  StoreId = 2,
                  LastName = "Jonty",
                  City = "Dubai",
              };
            studentLayer.UpdateStudent(sid, s);
        }
    }
}