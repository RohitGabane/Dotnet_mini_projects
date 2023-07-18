using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EFsecond.Models
{
    internal class StoreLayer
    {
        internal class StudentLayer
        {
            public static readonly Bank_Of_Baroda db = new Bank_Of_Baroda();
            public List<Store1> GetAll()
            {
                return db.Store1.ToList<Store1>();

            }
            public void AddStudent(Store1 s1)
            {
                db.Add<Store1>(s1);
                db.SaveChanges();
            }
           public void DeleteStudent(int Id)
            {
                Store1 d = db.Find<Store1>(Id);
                if (d != null)
                {
                    db.Remove<Store1>(d);
                }
                db.SaveChanges();
            }
            public void UpdateStudent(int Id, Store1 s)
            {
                if (s != null && s.Store1tId == Id)
                {
                    db.Entry(s).State = EntityState.Modified;
                    db.Update<Store1>(s);
                }
                db.SaveChanges();
            }
        }

    }
}
