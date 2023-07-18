using ReverseEngineering.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReverseEngineering.DAL
{
    internal class ProductDAL
    {
        readonly ProductContext db = new ProductContext();

        public List<Product> GetAll()
        {
            var r = db.Products.AsQueryable();
            return r.ToList<Product>();

        }
        public void Addproductone(Product p1)
        {
            db.Products.Add(p1);
            db.SaveChanges();

        }
        public void DeleteProductone(int id)
        {
            Product p = db.Find<Product>(id);
            db.Products.Remove(p);
            db.SaveChanges();


        }

    }
}
