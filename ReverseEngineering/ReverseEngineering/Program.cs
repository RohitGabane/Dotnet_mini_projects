using ReverseEngineering.Models;
using ReverseEngineering.DAL;

namespace ReverseEngineering
{
    internal class Program
    {
        static void Main(string[] args)
        {
            PrintProduct();
            AddProduct();
            DeleteProduct();
        }
        static void PrintProduct()
        {
            var ProductDAL = new ProductDAL();
            var listCountryModel = ProductDAL.GetAll();
            listCountryModel.ForEach(item =>
            {
                Console.WriteLine($"{item.Name} {item.Price}");
            });
            Console.WriteLine("Press any key to stop.");
            Console.ReadKey();
        }
        static void AddProduct()
        {
            Product p1 = new Product() { Name = "SyskaLed", Price = 250, Qty = 3000 };
            var ProductDAL = new ProductDAL();
            ProductDAL.Addproductone(p1);
        }
        static void DeleteProduct()
        {
            var ProductDAL = new ProductDAL();
            ProductDAL.DeleteProductone(1);
        }
    }
}