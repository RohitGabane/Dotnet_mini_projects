using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Schema;
//Q1.Create class MyMaths and write 3 static methods to find square, cube and power of number

namespace Demo
{
    /* struct Point //default access modifier is internal -or you can use public
     {
         // Fields of the structure.
         public int X;
         public int Y;

         // A custom constructor. must initialize all instance member
         public Point(int XPos, int YPos)
         {
             X = XPos;
             Y = YPos;

         }
         // Display the current position.
         public void Display()
         {
             Console.WriteLine("X = {0}, Y = {1}", X, Y);
         }
     }
     class Program
     {
         static void Main(string[] args)
         {
             Point p1;
             Point p2 = new Point(50, 60);

             p1 = p2;
             p1.X = 20;
             p1.Display();
             p2.Display();

         }
     }

     */


    /* enum EmpType  // A custom enumeration.
     {
         Manager,       // = 0
         Grunt,         // = 1
         Contractor,    // = 2
         VicePresident  // = 3
     }

     class Program
     {
         static void Main(string[] args)
         {
             EmpType emp = EmpType.Contractor;
             AskForBonus(emp);

             // Prints out "emp is a Contractor".
             Console.WriteLine("emp is a {0}.", emp.ToString());

             // Prints out "Contractor = 2".
             Console.WriteLine("{0} = {1}", emp.ToString(), (int)emp);
         }
         // Enums as parameters.
         static void AskForBonus(EmpType e)
         {
             switch (e)
             {
                 case EmpType.Manager:
                     Console.WriteLine("How about stock options instead?");
                     break;
                 case EmpType.Grunt:
                     Console.WriteLine("You have got to be kidding...");
                     break;
                 case EmpType.Contractor:
                     Console.WriteLine("You already get enough cash...");
                     break;
                 case EmpType.VicePresident:
                     Console.WriteLine("VERY GOOD, Sir!");
                     break;
             }
         }

     }*/
    /* public class myclass
     {
         public enum day { Monday, Tuesday }

     }
     class Program
     {
         static void Main(string[] args)
         {
             //myclass obj = new myclass();
             myclass.day d = myclass.day.Monday; //use classname .enum name
             Console.WriteLine(d);
             myclass.day d1 = myclass.day.Tuesday;
             Console.WriteLine(d1);

         }
     }*/
    /*enum dep
    {
        MKT = 1, ADV = 2, ADMN = 3

    }
    class Employee
    { //instance member
        int id;
        string name;
        float salary;
        dep d;
        // constructor
        public Employee(int i, string nm, float sal, dep dd)
        {
            id = i;
            name = nm;
            salary = sal;
            d = dd;

        }
        public override string ToString()
        {
            return string.Format(" {0} {1} {2} {3} ", id, name, salary, d);
        }
        public static void deptwisesal(Employee[] arr) // static method
        {
            float dm = 0, dadv = 0, dadmin = 0;
            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i].d == dep.MKT)
                    dm = dm + arr[i].salary;

                else if (arr[i].d == dep.ADV)
                    dadv = dadv + arr[i].salary;

                else if (arr[i].d == dep.ADMN)
                    dadmin = dadmin + arr[i].salary;
            }
            Console.WriteLine(" MKT= {0} ADV= {1} ADMIN= {2} ", dm, dadv, dadmin);

        }

    }
    class Program
    {
        static void Main(string[] args)
        {
            Employee e1 = new Employee(1, "Raj", 3000, dep.ADMN);
            Employee e2 = new Employee(2, "Reena", 2000, dep.ADMN);
            Employee e3 = new Employee(3, "Geeta", 1000, dep.MKT);
            Console.WriteLine(e1);
            Employee[] arr = new Employee[3];
            arr[0] = e1;
            arr[1] = e2;
            arr[2] = e3;
            Employee.deptwisesal(arr);
            Console.ReadLine();
        }
    }*/
    /*class Employee //(  : Object )
    {
        public int salary;
    }
    class Program
    {
        static void Main(string[] args)
        {
            int a = 5;
            Console.WriteLine("{0}", a.GetType()); //System.Int32
            Console.WriteLine("{0}", a.GetType().BaseType); //System.valueType
            Console.WriteLine("{0}", a.GetType().BaseType.BaseType);//System. ObjectType

            Employee ob = new Employee(); //reference type data

            Console.WriteLine("{0}", ob.salary.GetType()); //System.Int32
            Console.WriteLine("{0}", ob.GetType());//name of class(Employee)
                                                   // observe datatype of ob is Employee
            Console.WriteLine("{0}", ob.GetType().BaseType);//System. Object
                                                            //parent of Employee is Object
        }
    }*/
    /* class TypeInference
     {
         static void Main(string[] args)
         {
             var name = "Bugs Bunny";
             var age = 25;
             var isRabbit = true;
             var marks = 90.55f;

             Type nameType = name.GetType(); //return data type
             Type ageType = age.GetType();
             Type isRabbitType = isRabbit.GetType();
             Type marksType = marks.GetType();

             Console.WriteLine("name is type " + nameType.ToString());
             Console.WriteLine("age is type " + ageType.ToString());
             Console.WriteLine("isRabbit is type " + isRabbitType.ToString());
             Console.WriteLine("marks is type " + marksType.ToString());


         }
     }*/

    /*class Employee //default access modyfier internal
    {
        public string name;
        public float salary; //member are by default private
                             //constructor must be public or internal else will not able to create object outside class
        public Employee()
        {
            Console.WriteLine("initialize data");
        }
        //if you do not write constructor frame work will give you no args constructor
    }
    class Program
    {
        static void Main(string[] args)
        {
            Employee obj = new Employee();
            Console.WriteLine("{0}{1}", obj.name, obj.salary);
        }
    }*/
    /* class Employee //default access modifier internal
     {
         internal string name;
         internal float salary;
         //member are by default private
         //constructor must be public else will not able to 
         //create object outside Assembly
         internal Employee()
         {
             Console.WriteLine("initialize data");
         }
         //if you do not write constructor frame work will give you no args constructor
     }
     class Program
     {
         static void Main(string[] args)
         {
             Employee obj = new Employee();
             Console.WriteLine("{0}{1}", obj.name, obj.salary);
             Console.ReadLine();
         }
     }*/

    /* class Employee //default access modyfier internal
     {
         public string name;
         public float salary; //member are by default private (if you do not use access modifier) 

         public Employee(string nm, float sal) //must be public/internal else will not able to create object outside class
         {
             name = nm;
             salary = sal;
            // Console.WriteLine("initialize data");
         }
         //if you have parameterised constructor frame work will not give you no args constructor
     }
     class Program
     {
         static void Main(string[] args)
         {

             Employee obj1 = new Employee("Raj", 5000);
             Employee obj2 = new Employee("Mona",8000);
             Console.WriteLine("{0} {1}", obj1.name, obj1.salary);
             Console.WriteLine("{0} {1}", obj2.name, obj2.salary);
             Employee obj3 = new Employee("ronny", 8000);
             Console.WriteLine("{0} {1}", obj3.name , obj3.salary);


         }
     }*/
    /* class Employee
     {
         string name;
         float salary;
         public Employee(string nm, float sal)
         {
             Console.WriteLine("initialize data");
             name = nm;
             salary = sal;
         }
         public string display()
         {
             return string.Format("name={0} salary={1}", name, salary);
         }
     }
     class Program
     {
         static void Main(string[] args)
         {
             Employee obj1 = new Employee("Raj", 30000);
             Employee obj2;
             obj2 = obj1; //shallow copy
             Console.WriteLine(obj2.display());//Raj 30000
             Console.WriteLine(obj1.display());// Raj 30000
             bool b = obj1.Equals(obj2);
             Console.WriteLine(b);// true
             Console.WriteLine(obj1 == obj2);// true
             Employee obj3 = new Employee("Raj", 4000);
             Console.WriteLine(obj3.display());
         }
     }*/

    /*Create class student with private member variable 
    Prn_no, 
    (subjects)
    Java, c#, Html
    Total
    Percentage

    Write method public void get_total()
    Write method public void get_percentage()
    Write method public string display() which will display Prn_no total percentage
    Create 2 object of a class and display record.
    */

    /* class Student
     {
         public int prn_no;
          public string subjects;
         public double total;
       public double percentage;

         public Student(int no, string sub, double d, double dd)
         {
             prn_no=no;
             subjects = sub;
             total = d;
             percentage = dd;
         }
         public string display()
         {
             return string.Format("prn_no {0} subjects {1} total {2} percentage {3}" , prn_no, subjects, total,percentage);
         }

     }
     class Demo
     {
         public static void Main(string[] args)
         {
             Student s1 = new Student(1, "java", 450, 89.25);
             Console.WriteLine(s1.display());
         }



     }*/
    /* using System;
     using System.Collections.Generic;
     using System.Linq;
     using System.Text;
     using System.Threading.Tasks;*/

    /* namespace Day01Task
     {*/
    /*internal class Product
    {
        static void Main(string[] args)
        {
            //Q7.Accept 2 number and print product and sum of these number

            Console.WriteLine("Enter First number");
            double n1 = double.Parse(Console.ReadLine());
            Console.WriteLine("Enter Second Number");
            double n2 = double.Parse(Console.ReadLine());

            double res = n1 * n2;
            Console.WriteLine($"Product of {n1} and {n2} = {res}");

            //Q8.declare 2 byte variable and do sum of it.Print as byte data type

            Console.WriteLine("Enter First  byte number");
            double b1 = double.Parse(Console.ReadLine());
            Console.WriteLine("Enter Second byte Number");
            double b2 = double.Parse(Console.ReadLine());

            byte b3 = (byte)(b1 + b2);
            Console.WriteLine(b3);


            //Q9.declare 2 short variable and do sum of it.Print as short data type
            Console.WriteLine("Enter First  short number");
            short s1 = short.Parse(Console.ReadLine());
            Console.WriteLine("Enter Second short Number");
            short s2 = short.Parse(Console.ReadLine());

            short s3 = (short)(s1 + s2);
            Console.WriteLine(s3);

            //Q10.declare 2 char variable and do sum of it.Print as char data type
            Console.WriteLine("Enter First  character");
            char c1 = char.Parse(Console.ReadLine());
            Console.WriteLine("Enter Second character");
            char c2 = char.Parse(Console.ReadLine());

            char c3 = (char)(c1 + c2);
            Console.WriteLine(c3);

        }

    }
    */

    /* class Myclass
     {
         string name;
         int id;

         static Myclass sobj = null;

         private Myclass(string nm,int dd)
         {
             name = nm;
             id = dd;
         }
         public static Myclass getobj()
         {
             if(sobj == null)

                 sobj=new Myclass("Dac" , 455);
                 return sobj;

         }
         public string display() 
         { return name + " " +id; }
     }
     class progarm
     {
         public static void Main()
         {
             Myclass ob=Myclass.getobj();
             Console.WriteLine(ob.display());

             Myclass obj1 = Myclass.getobj();
             Console.WriteLine(obj1.display());

             Console.WriteLine(ob == obj1);
             Console.WriteLine(ob.Equals(obj1));
         }
     }*/

    /*class Account
    {
        string name;
        int Account_no;

        static Account()
        {
            Console.WriteLine("CENTRAL BANK OF INDIA");
        }
        public Account(string name, int roll_no)
        {
            this.name = name;
            this.Account_no = roll_no;
        }
        public void display()
        {
            Console.WriteLine(name + " " + Account_no);
        }
    }
    class program
    {
        public static void Main(string[] args) 
        {
            Account r =new Account("Ronny",8365421);
            r.display();
        }
    }*/

    /*3. Create class Employee having member Id, Name, Salary,  NetSalary, Dept d
    Create enum Dept {MKT, ADMIN, ADV}
    Create method public double paytax(double p) {return tax amount and set netsalary(note: netsalary=salary-salary*p%)}
    Create method display to display name and netsalary and department
    When you load application it should print name of company.
    new Employee(1,”Raj”,50000,Dept.MKT)
    */

    /*  enum dep
      {
          MKT = 1, ADV = 2, ADMN = 3

      }
      class Employee
      { //instance member
          int id;
          string name;
          float salary;
          double NetSalary;
          dep d;
          // constructor
          static Employee()
          {
              Console.WriteLine("Presented by MICROSOFT");
          }
          public Employee(int i, string nm, float sal, dep dd)
          {
              id = i;
              name = nm;
              salary = sal;
              d = dd;

          }
          public double paytax(double d)
          {
              NetSalary = salary - salary * 0.5;
              return d;
          }
          public override string ToString()
          {
              return string.Format(" {0} {1} {2} {3} ", id, name, salary, d);
          }
         public void display()
          {
              Console.WriteLine(name + " " +NetSalary + " " +dep.MKT);
          }


      }
      class Program
      {
          static void Main(string[] args)
          {
              Employee e1 = new Employee(1, "Raj", 3000, dep.ADMN);

              Console.WriteLine(e1); 
              e1.display();
             e1.paytax(3);
              Console.ReadLine();
          }
      }*/




    /*class calculator
    {
        public static double add(double a, double b)
        {
            return a + b;
        }
        public static double sqr(double a)
        {
            return a * a;
        }
    }
    class Program1
    {
        static void Main(string[] args)
        {
            double add = calculator.add(4, 9);

            double sq = calculator.sqr(5.5);

            Console.WriteLine("{0} {1}", add, sq);
        }
    }*/
    class Account
    {
        static int getid;
        int id;
        string name;
        double balance;
        static double interest_rate = 0.07;
        static Account()
        {
            Console.WriteLine("Bank of Baroda");
        }
        public Account(string nm, double bal)
        {
            id = ++getid;
            name = nm;
            balance = bal;
        }
        public void deposit(double amt)
        {
            balance += amt;
        }
        public string display()
        {
            return string.Format("{0}{1}{2}", id, name, balance);
        }
        public static double payint(Account a2)
        {
            double income = a2.balance * interest_rate;
            a2.balance = a2.balance + income;
            return income;
        }

    }
    class AccountDemo
    {
        static void Main()
        {
            Account a1 = new Account("Raj", 1000); // create a  object 
            Account a2 = new Account("Geeta", 40000); // create a object 

            Console.WriteLine(Account.payint(a1));
            a1.deposit(3000);
            a2.deposit(1000);

            Console.WriteLine(a1.display());
            Console.WriteLine(a2.display());
            double r = Account.payint(a2);
        }
    }


}

