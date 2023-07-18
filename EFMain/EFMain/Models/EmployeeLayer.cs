using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EFMain.Models
{
    internal class EmployeeLayer
    {
        public static readonly Company db = new Company();
        public List<Employee> GetAll()
        {
            return db.Employee.ToList<Employee>();

        }
        public void AddStudent(Employee s1)
        {
            db.Add<Employee>(s1);
            db.SaveChanges();
        }
        public void DeleteStudent(int Id)
        {
            Employee d = db.Find<Employee>(Id);
            if (d != null)
            {
                db.Remove<Employee>(d);
            }
            db.SaveChanges();
        }
        public void UpdateStudent(int Id, Employee s)
        {
            if (s != null && s.empId == Id)
            {
                db.Entry(s).State = EntityState.Modified;
                db.Update<Employee>(s);
            }
            db.SaveChanges();
        }

    }
}
