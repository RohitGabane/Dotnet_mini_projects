using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net.Http.Headers;
using System.Runtime.Serialization.Formatters.Soap;
using System.Text;
using System.Threading.Tasks;

namespace Ronny
{

    /*  class Program
      {
          static void Main(string[] args)
          {
              Console.WriteLine("***** A First Look at Interfaces *****\n");

              // All of these classes support the ICloneable interface.
              string myStr = "Hello";
              Console.WriteLine(myStr.GetHashCode());
              OperatingSystem unixOS = new OperatingSystem(PlatformID.Unix, new Version());
              Console.WriteLine(unixOS.GetHashCode());
              System.Data.SqlClient.SqlConnection sqlCnn = new System.Data.SqlClient.SqlConnection();
              Console.WriteLine(sqlCnn.GetHashCode());
              // Therefore, they can all be passed into a method taking ICloneable.
              CloneMe(myStr);
              CloneMe(unixOS);
              CloneMe(sqlCnn);
              Console.ReadLine();
          }

          private static void CloneMe(ICloneable c)
          {
              // Clone whatever we get and print out the name.
              object theClone = c.Clone();
              Console.WriteLine(theClone.GetHashCode());
              Console.WriteLine("Your clone is a: {0}", theClone.GetType().Name);
          }
      }*/
    /* delegate int Demo(int a, int b);
     class Student
     {
         public static int Add(int a, int b)
         {
             return a + b; ;
         }

         public static int Product(int a, int b)
         {
             return a * b; ;
         }


         public static void main()
         {
             Demo strOp = new Demo(Add);
             int x = strOp(5, 6);

             Console.WriteLine("Addition is " + x);
             Console.WriteLine();

             strOp = new Demo(Product);
             int y= strOp(5, 6);
             Console.WriteLine("product is " + y);
         }
     }
    */

    // Rethrow an exception. 
    /* using System;
     class Rethrow
     {
         public static void genException()
         {
             // here, numer is longer than denom 
             int[] numer = { 4, 8, 16, 32, 64, 128, 256, 512 };
             int[] denom = { 2, 0, 4, 4, 0, 8 };

             for (int i = 0; i < numer.Length; i++)
             {
                 try
                 {
                     Console.WriteLine(numer[i] + " / " +
                                                   denom[i] + " is " +
                                                   numer[i] / denom[i]);
                 }
                 catch (DivideByZeroException)
                 {
                     // catch the exception 
                     Console.WriteLine("Can't divide by Zero!");
                 }
                 catch (IndexOutOfRangeException)
                 {
                     // catch the exception 
                     Console.WriteLine("No matching element found.");
                     throw; // rethrow the exception 
                 }
             }
         }
     }
     class RethrowDemo
     {
         public static void Main()
         {
             try
             {
                 Rethrow.genException();
             }
             catch (IndexOutOfRangeException)
             {
                 // recatch exception 
                 Console.WriteLine("Fatal error -- " +
                                   "program terminated.");
             }
         }
     }
    */
    // Use finally. 
    /* using System;
     class UseFinally
     {
         public static void genException(int what)
         {
             int t;
             int[] nums = new int[2];

             Console.WriteLine("Receiving " + what);
             try
             {
                 switch (what)
                 {
                     case 0:
                         t = 10 / what; // generate div-by-zero error 
                         break;
                     case 1:
                         nums[4] = 4; // generate array index error. 
                         break;
                     case 2:
                         return; // return from try block 
                 }
             }
             catch (DivideByZeroException)
             {
                 // catch the exception 
                 Console.WriteLine("Can't divide by Zero!");
                 return; // return from catch 
             }
             catch (IndexOutOfRangeException)
             {
                 // catch the exception 
                 Console.WriteLine("No matching element found.");
             }
             finally
             {
                 Console.WriteLine("Leaving try.");
             }
         }
     }

     class FinallyDemo
     {
         public static void Main()
         {

             for (int i = 0; i < 3; i++)
             {
                 UseFinally.genException(i);
                 Console.WriteLine();
             }
         }
     }*/
    // Using Exception members. 

    /* using System;

     class ExcTest
     {
         public static void genException()
         {
             int[] nums = new int[4];

             Console.WriteLine("Before exception is generated.");

             // Generate an index out-of-bounds exception. 
             for (int i = 0; i < 10; i++)
             {
                 nums[i] = i;
                 Console.WriteLine("nums[{0}]: {1}", i, nums[i]);
             }

             Console.WriteLine("this won't be displayed");
         }
     }

     class UseExcept
     {
         public static void Main()
         {

             try
             {
                 ExcTest.genException();
             }
             catch (IndexOutOfRangeException exc)
             {
                 // catch the exception  
                 Console.WriteLine("Standard message is: ");
                 Console.WriteLine(exc); // calls ToString() 
                 Console.WriteLine("Stack trace: " + exc.StackTrace);
                 Console.WriteLine("Message: " + exc.Message);
                 Console.WriteLine("TargetSite: " + exc.TargetSite);
             }
             Console.WriteLine("After catch statement.");
         }
     }
    */


    /*1. Create abstract class Employee having member id, name, salary, netsalary
It has method givebasic_salary which will set netsalary after deduction 10%TDS
 it has abstract method givebonus
Id should be autoincrement and should be readonly property
Write getter setter for name and salary
Salary can be set only by child class
Create two child class permanentEmp and tempEmp
permanentEmp get bonus of 10%[ declare this as static veriable ]
const maxsalay=150000.
Ensure that you are not paying more then 150000 to any employee
Bonus for tempEmp is 5% of the basic salary.
When you load application it should print name of company
When you give salary it should give SMS and Email to the employee.
Crate Array of Employee and store all child class object.*/

    /*using System;

    abstract class Employee
    {
        private static int nextId = 1;
        public readonly int Id;
        private string name;
        private double salary;
        private double netSalary;
        protected static readonly double maxSalary = 150000;


            public Employee(string name, double salary)
        {
            Id = nextId++;
            Name = name;
            Salary = salary;
        }

        public string Name
        {
            get { return name; }
            set { name = value; }
        }

        public double Salary
        {
            get { return salary; }
            protected set
            {
                if (value > maxSalary)
                    throw new ArgumentException($"Salary cannot exceed {maxSalary}.");
                salary = value;
            }
        }

        public double NetSalary
        {
            get { return netSalary; }
        }

        public void GiveBasicSalary()
        {
            double tds = 0.1 * Salary;
            netSalary = Salary - tds;
        }

        public abstract void GiveBonus();


        public override string ToString()
        {
            return $"Id: {Id}, Name: {Name}, Salary: {Salary}, NetSalary: {NetSalary}";
        }
    }

    class PermanentEmp : Employee
    {
        private static readonly double bonusRate = 0.1;

        public PermanentEmp(string name, double salary) : base(name, salary) { }

        public override void GiveBonus()
        {
            double bonus = bonusRate * Salary;
            Salary += bonus;
            Console.WriteLine($"Bonus of {bonus} given to {Name}");
        }
    }

    class TempEmp : Employee
    {
        private static readonly double bonusRate = 0.05;

        public TempEmp(string name, double salary) : base(name, salary) { }

        public override void GiveBonus()
        {
            double bonus = bonusRate * Salary;
            Salary += bonus;
            Console.WriteLine($"Bonus of {bonus} given to {Name}");
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to XYZ Company");

            Employee[] employees = new Employee[4];
            employees[0] = new PermanentEmp("John", 100000);
                try
                {
                    employees[1] = new PermanentEmp("Mary", 200000);

                } catch( Exception e)
                {
                    Console.WriteLine(e.Message);
                }
            employees[2] = new TempEmp("Bob", 50000);
            employees[3] = new TempEmp("Alice", 70000);

            foreach (Employee emp in employees)
            {
                emp.GiveBasicSalary();
                emp.GiveBonus();
                Console.WriteLine(emp);
                // send SMS and email to the employee
            }
        }
    }*/
    /*[Serializable]
    public class employee
    {
        string name;
        int sal;
        int id;
        public employee(string nm, int sal, int id)
        {
            Name = nm;
            Salary = sal;
            this.id = id;
        }

        public String Name
        {
            get { return name; }
            set { name = value; }
        }

        public int Salary
        {
            get { return sal; }
            set { sal = value; }
        }


    }
    class Program
    {
        // Be sure to import the System.Xml.Serialization
        // and System.IO namespaces.
        static void Main(string[] args)
        {
            Console.WriteLine("***** Fun with Object Serialization *****\n");
            // employee e = new employee();
            employee[] myEmp = new employee[2];
            myEmp[0] = new employee("raj", 7000, 101);
            myEmp[1] = new employee("geeta", 9000, 102);


            // Save as SOAP.
            SaveAsSoapFormat(myEmp, "CarData.soap");
            string fn = "CarData.soap";
            LoadFromFile(fn);


            Console.ReadLine();
        }
        static void SaveAsSoapFormat(object objGraph, string fileName)  //Serialisation
        {
            // Save object to a file named CarData.soap in SOAP format.
            SoapFormatter soapFormat = new SoapFormatter();

            using (Stream fStream = new FileStream("CarData.soap",
              FileMode.Create, FileAccess.Write))
            {
                soapFormat.Serialize(fStream, objGraph);
            }
            Console.WriteLine("=> Saved car in SOAP format!");
        }
        //Deserialisation
        static void LoadFromFile(string fn)
        {

            // read object to a file named CarData.soap in SOAP format.
            SoapFormatter soapFormat = new SoapFormatter();
            using (Stream fStream = new FileStream("CarData.soap", FileMode.Open))
            {
                employee[] obj = (employee[])soapFormat.Deserialize(fStream);

                foreach (employee e in obj)
                    Console.WriteLine("{0}  {1}", e.Name, e.Salary);
            }

        }
    }*/

    /* public interface Iservice
     {
         string serviceMethod();
     }
     public class Business
     {
         private Iservice client;
         public Business(Iservice client)
         {
             this.client = client;
             Console.WriteLine("Constructor ");
         }
     }*/


    /*public interface IProductRESTService
    {

        List<Product> GetProductList();

        Product GetProduct(int id);
    }

    public class ProductRESTService : IProductRESTService
    {
        public List<Product> GetProductList()
        {
            return Productscoll.Instance.ProductList;
        }
        public Product GetProduct(int id)
        {
            return Productscoll.Instance.GetProduct(id);
        }
    }
    public class Product
    {

        public int ProductId { get; set; }

        public string Name { get; set; }

        public string CategoryName { get; set; }

        public int Price { get; set; }
        public override string ToString()
        {
            return String.Format("{0}{1}{2}{3}", ProductId, Name, CategoryName, Price);
        }
    }
    public class Productscoll
    {
        private static readonly Productscoll _instance = new Productscoll();

        private Productscoll() { }

        public static Productscoll Instance
        {
            get { return _instance; }
        }
        public List<Product> ProductList
        {
            get { return products; }
        }
        public Product GetProduct(int id)
        {
            var result = (from r in products where r.ProductId == id select r).ToList<Product>().First<Product>();

            return result;
        }
        private List<Product> products = new List<Product>()
        {
                new Product() { ProductId = 1, Name = "TV", CategoryName = "Category 1", Price=10},
                 new Product() { ProductId = 2, Name = "LCD", CategoryName = "Category 2", Price=5},
                new Product() { ProductId = 3, Name = "Projector", CategoryName = "Category 3", Price=15},
                new Product() { ProductId = 4, Name = "LED", CategoryName = "Category 1", Price=9}
        };
    }
    public class Program
    {
        static void Main()
        {

            ProductRESTService ob = new ProductRESTService();

            foreach (var x in ob.GetProductList())

                Console.WriteLine(x);

            var pobj = ob.GetProduct(3);


    }
    }*/
    /* class GenListDemo
     {
         static void Main()
         {
             // Create a list. 
             List<char> lst = new List<char>();

             Console.WriteLine("count={0} capacity={1}", lst.Count, lst.Capacity);//0 0
             Console.WriteLine("Adding 6 elements");
             // Add elements to the array list  
             lst.Add('C');
             lst.Add('A');
             lst.Add('E');
             lst.Add('B');
             lst.Add('D');
             lst.Add('F');

             Console.WriteLine("count={0} capacity={1}", lst.Count, lst.Capacity);//6 8

             // Display the array list using array indexing.  
             Console.Write("Current contents: ");
             for (int i = 0; i < lst.Count; i++)
                 Console.Write(lst[i] + " ");
             Console.WriteLine("\n");

         }
     }
    */

    class Employee
    {
        public string Name { get; set; }
        public double Salary { get; set; }
        public Employee() { }
        public Employee(string nm, double sl)
        {
            Name = nm;
            Salary = sl;
        }
        public override string ToString()
        {
            return String.Format("{0} {1}", Name, Salary);
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            List<Employee> listemp = new List<Employee>{
               new Employee {Name ="Raj",Salary =6000} ,
                new Employee {Name ="Mona",Salary =7000} ,
              new Employee {Name ="Het",Salary =3000} ,      };

            foreach (Employee E in listemp)
                Console.WriteLine(E);
            Employee obj = listemp.Find((arr) => arr.Salary == 6000);

         
            Console.WriteLine(obj);
            var result = listemp.FindAll((arr) => arr.Salary >= 6000);
            foreach(Employee E in result) Console.WriteLine(E);
        }
    }




}
