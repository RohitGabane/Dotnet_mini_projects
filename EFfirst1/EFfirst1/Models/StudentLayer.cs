using EFfirst1.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EFfirst1.Models
{
    internal class StudentLayer
    {
        public static readonly Bank_Of_Baroda db = new Bank_Of_Baroda();
        public List<Student> GetAll()
        {
            return db.Student.ToList<Student>();

        }
        public void AddStudent(Student s1)
        {
            db.Add<Student>(s1);
            db.SaveChanges();
        }
        public void DeleteStudent(int Id)
        {
            Student d = db.Find<Student>(Id);
            if (d != null)
            {
                db.Remove<Student>(d);
            }
            db.SaveChanges();
        }
        public void UpdateStudent(int Id, Student s)
        {
            if (s != null && s.StudentId == Id)
            {
                db.Entry(s).State = EntityState.Modified;
                db.Update<Student>(s);
            }
            db.SaveChanges();
        }

    }
}
