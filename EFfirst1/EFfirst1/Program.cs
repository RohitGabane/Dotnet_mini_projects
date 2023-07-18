using EFfirst1.Models;

namespace EFfirst1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            StudentLayer studentLayer = new StudentLayer();

            List<Student> sl = studentLayer.GetAll();

            sl.ForEach(item =>
            {
                Console.WriteLine($"{item.FirstName} {item.LastName}" + $" {item.Height} {item.weight} {item.GradeId}");
            });
            Student s1 = new Student()
            {
                FirstName = "Geet",
                LastName = "Zaveri",
                Height = 6,
                weight = 88,
                GradeId = 5
            };

            studentLayer.AddStudent(s1);
            /*int id = 3;
            studentLayer.DeleteStudent(id);

            int sid = 1;
            Student s = new Student()
            {
                StudentId = 2,
                FirstName = "Kavita",
                LastName = "Shekh",
                Height = 4,
                weight = 44,
                GradeId = 1
            };
            studentLayer.UpdateStudent(sid, s);*/
        }

    }

}
