
using ConsoleApp2;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Security.Claims;
using System.Security.Principal;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;
using static System.Net.Mime.MediaTypeNames;

namespace ConsoleApp2
{
    /* class Account
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
             return string.Format("{0} {1} {2}", id, name, balance);
         }
         public static double payint(Account a1)
         {
             double income = a1.balance * 17;
             a1.balance = a1.balance + income;
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
             double r = Account.payint(a1);
         }
     }*/

    /*class Ronny
    {
        public const int capacity = 120;

    }
    class Demoe
    {
        public static void Main(String[]args)
        {
            Console.WriteLine(Ronny.capacity);
        }
    }*/
    /*class Account
    {
        static int getid;
        int id;
        string name;
        double balance;
        const int maxcapacity = 2;
        static double interest_rate = 0.07;
        static Account()
        {
            Console.WriteLine("Bank of Baroda");
        }
        public Account(string nm, double bal)
        {
            if (getid < maxcapacity)
            {
                id = ++getid;
                name = nm;
                balance = bal;
            }
            else
                Console.WriteLine("capacity full can not open account");
            throw new Exception("cant create account");
        }
        public void deposit(double amt)
        {
            balance += amt;
        }
        public string display()
        {
            return string.Format("{0} {1} {2}", id, name, balance);
        }
        public static double payint(Account obj)
        {
            double income = obj.balance * interest_rate;
            obj.balance = obj.balance + income;
            return income;
        }
        public void withdraw(double amt)
        {
            const int minbal = 1000;
            if (balance - amt < minbal)
            { //5000-2000
                Console.WriteLine("insufficient balance" );
            }
            else
                balance -= amt;
        }

    }
    class AccountDemo
    {
        static void Main()
        {
            Account a1 = new Account("Raj", 1000); // create a  object 
            Account a2 = new Account("Geeta", 40000); // create a object 
            Account a3 = new Account("Ankit", 5000); // will object  get created? 
            Account a4 = new Account("sanket", 50000); // will object  get created? 


            Console.WriteLine(Account.payint(a1));
            a1.deposit(3000);
            a2.deposit(1000);

            Console.WriteLine(a1.display());
            Console.WriteLine(a2.display());

            Console.WriteLine(a3.display());
            Console.WriteLine(a4.display());


        }
    }*/
    /*class demoreadonly
    {
        public static readonly double intrate = 0.5;
        //can be initialized only where you declare or in constructor
        public readonly double TDS;
        static demoreadonly()
        {
            intrate = 0.07;
            Console.WriteLine(intrate);
        }
        public demoreadonly()
        {
            TDS = 0.1;
            Console.WriteLine(TDS);
        }
    }
    class EmployeeDemo
    {
        static void Main()
        {
           demoreadonly obj = new demoreadonly();
            // obj.TDS = 44; error

            // demoreadonly.intrate = 8; error
        }
    }*/
    /* static class myclass
     {
         public static int x;
         static myclass()
         {
             x = 55;
             Console.WriteLine("hi" + x);

         }
     }

     class Program
     {
         static void Main(string[] args)
         {
             int y = myclass.x;
             Console.WriteLine("in main");
             Console.ReadLine();
         }

     }*/


    /* static class myclass
     {
         public const int x = 50;
         static myclass()
         { Console.WriteLine("SMVITA" + x); }
     }
     class Program
     {
         const int no = 111;
         static Program()
         {
             Console.WriteLine("SMVITA.......prog");
         }
         static void Main(string[] args)
         {
             int y = myclass.x;
             Console.WriteLine("in main{0} {1}", no, y);
         }
     }*
    class Test
 {
     /* This method causes no change to the arguments 
        used in the call. */
    /* class Test
     { 
     public void noChange(int i, int j)
     {
         i += 5;
         j += 5;

     }

 }
 class CallByValue
 {
     public static void Main()
     {

         Test ob = new Test();

         int a = 15, b = 20;

         Console.WriteLine("a and b before call: " + a + " " + b);//15 20

         ob.noChange(a, b);

         Console.WriteLine("a and b after call: " + a + " " + b);//15 20
     }*/
    /* class Employee
     {
         double _salary;
         int empno;
         //no () after Salary
         public double Salary
         {
             get
             {
                 Console.WriteLine("I am in get");
                 return _salary;
             }
             set
             {    //20000
                 _salary = value;
                 Console.WriteLine("I am in set" + value);
             }
         }
     }
     public class demo
     {
         public static void Main()
         {
             //calling no args constructor given by .NetFrame work
             Employee emp = new Employee();
             //setter is called 
             emp.Salary = 20000;

             //getter is called
             Console.WriteLine(emp.Salary);


         }
     }*/
    /* class propdisp
     {
         string _name;
         public propdisp(string nm)
         {
             Name = nm;
         }
         public string Name
         {
             get
             {
                 Console.WriteLine("get called");
                 return _name;
             }

             set
             {
                 Console.WriteLine("set called");
                 if (value.Length < 3)
                     throw new Exception("name length is < 3");
                 else
                     _name = value;
             }
         }
     }
     class Program
     {
         static void Main(string[] args)
         {
             try
             {
                 propdisp obj = new propdisp("vi");
                 Console.WriteLine("not" + obj.Name);
             }
             catch
             {
                 Console.WriteLine("cold not created object");
             }
             propdisp obj2 = new propdisp("vita");
             Console.WriteLine("obj.name=" + obj2.Name);


         }
     }*/

    /*class propdisp
    {
        int id;
        static int getid;
        string _name;

        public propdisp(string nm)
        {
            Name = nm;
            id = ++getid;
        }
        public string Name
        {
            get
            {
                Console.WriteLine("get called");
                return _name;
            }
            set
            {
                Console.WriteLine("set called");
                _name = value;
            }
        }
        public int Id
        {
            get
            {
                return id;
            }
        }
        //observe no setter for Id 
    }
    class Program
    {
        static void Main(string[] args)
        {
            propdisp obj = new propdisp("vita");

            Console.WriteLine(obj.Name);
            Console.WriteLine(obj.Id);
            //obj.Id=2 error you can not write
            propdisp ob = new propdisp("vidya");

            Console.WriteLine(ob.Name);
            Console.WriteLine(ob.Id);
        }
    }*/


    /*class Employee
    {
        double _salary;
        int empno;
        //no () after Salary
        public double main
        {
            get
            {
                Console.WriteLine("I am in get");
                return _salary;
            }
            set
            {    //20000
                _salary = value;
                Console.WriteLine("I am in set" + value);
            }
        }
    }
    public class demo
    {
        public static void Main()
        {
            //calling no args constructor given by .NetFrame work
            Employee emp = new Employee();
            //setter is called 
            emp.main = 20000;

            //getter is called
            Console.WriteLine(emp.main);

        }
    }*/

    /*class dept
    {
        int no;
        string namr;

        public int method
        {
            get
            {
                Console.WriteLine("in get");
                return no;
            }
            set
            {
                 no = value;
                Console.WriteLine("in set");
            }
        }

    }
    internal class normal
    {
        public static void Main(string[] args)

        {
            dept d = new dept();
            d.method = (-5);
            Console.WriteLine(d.method);
        }
    }*/

    /*class propdisp
    {
        string _name;
        public propdisp(string nm)
        {
            Name = nm;
        }
        public string Name
        {
            get
            {
               // Console.WriteLine("get called");
                return _name;
            }

            set
            {
                Console.WriteLine("set called");
                if (value.Length < 3)
                    Console.WriteLine("err");
                else
                    _name = value;
            }
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            propdisp obj = new propdisp("vita");
            Console.WriteLine(obj.Name);

        }
    }*/

    /*
        class p
        {
            int no;
            string name;

            public p(string name)
            {
                this.name = name;
                Console.WriteLine(name);
            }
            public string method
            {
                get { return name; }
                set {
                    if (value.Length< 3)
                        Console.WriteLine("err");
                    else
                        name = value; }
            }
        }
        public class p2
        {
            public static void Main(string[] args) {
                p p1 = new p("g");

            }
        }*/

    /* class prop
     {
         string name;

         public prop(string nm)
         {
             this.name = nm;
         }
         public string method
         {
             get
             {
                 return this.name;
             }
             set
             {
                 if (value.Length < 3)
                     throw new Exception("cannot put below 3 name");
                 else
                     this.name = value;
             }
         }
         class propmain
         {
             public static void Main()
             {
                 try
                 {
                     prop p = new prop("hi");
                     Console.WriteLine(p.method);

                 }
                 catch
                 {
                     Console.WriteLine("Could not create obj");
                 }
             }
         }
     }*/
    /*class propdisp
    {
        string _name;
        public propdisp(string nm)
        {
            Name = nm;
        }
        public string Name
        {
            get
            {
                Console.WriteLine("get called");
                return _name;
            }

            set
            {
                Console.WriteLine("set called");
                if (value.Length < 3)
                    throw new Exception("name length is < 3");
                else
                    _name = value;
            }
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                propdisp obj = new propdisp("vi");
                Console.WriteLine("not" + obj.Name);
            }
            catch
            {
                Console.WriteLine("cold not created object");
            }
            propdisp obj2 = new propdisp("vita");
            Console.WriteLine("obj,name=" + obj2.Name);


        }
    }*/

    /*Q1. Create 2 string variable and accept data from user.
Using equals and == check data entered by user is same or not.
Print gethashcode for both string .variable
Also use referenceEquals and observe out put.
*/
    /*class program
    {
        public static void Main(string[] args)
        {

            string a = "hello";
            string b="hel";
            Console.WriteLine(a==b);
            Console.WriteLine(Object.Equals(a,b));
            Console.WriteLine(a.GetHashCode());
            Console.WriteLine(b.GetHashCode());
            Console.WriteLine(Object.ReferenceEquals(a,b));
        }
    }*/
    /*Create Account class having instance member 
1. id- id should be generated by application, it is readonly property
2. name – write getter setter 
3. balance- Write getter setter 
It has deposit method who’s job is to increase the balance.
Declare static float Interestrate=0.07.
It has withdraw method who’s job is to reduce balance.
Declare conts float minbal=1000. When user withdraw money your application should ensure that minimum balance is maintain. 
Give appropriate validation like user can not deposit or withdraw 0 or negative. user can not open account with 0 amount
When you run your application at the beginning it should print name of bank and copy right detail.
It has static method which will calculate and return  interest amount for each account holder and increase the balance.
Write display method who’s job is to display Id name and balance and interest received.
If you are comfortable the exception try to use it and handle it also.
*/

    /*class Account
    {
        static int getid;
        int id;
        string name;
        double balance;
        static float Interestrate = 0.07f;
        const float minbal = 1000f;


        static Account()  //don't have parameter + use for presented copy by name ex..company name
        {
            Console.WriteLine("CENTRAL BANK OF INDIA");
        }
        public Account( string nm, double bal)//come after create obj and give value in runtime...
        {
            id = ++getid;
            name = nm;
            balance = bal;
        }
        public string Name //call setter getter using instance method means non-static..they don't have () 
        {
            get
            { 
                return name;
            }
            set 
            { 
                name = value;
            }
        }
        public double Balance
        {
            get 
            {
                return balance;
            }
            set                //write-only
            {
                if (value < 1)
                {
                    Console.WriteLine("error");
                }
                balance = value;
            }
        }
        public int Id
        {
            get              //read-only
            {
                return id;
            }
        }
      

        public void withdraw(double amt)
        {
            const float minbal = 1000f;      //const value

            if (balance - amt < minbal)
            { 
                Console.WriteLine("insufficient balance");
            }
            else
                balance -= amt;
        }
        public static double payint(Account a1)
        {
            double income = a1.balance * 0.07;
            a1.balance = a1.balance + income;
            return income;
        }

        public string Display()
        {
            return string.Format(" {0} {1} ", name, balance);
        }


    }
    public class AccountDemp
    {
        public static void Main(string[] args)
        {
            Account a1 = new Account("ronny", 25000);
            Account a2 = new Account("Disha", 2000);

            Console.WriteLine(a1.Display() + " " + a2.Display());

            a1.withdraw(5525);
            Console.WriteLine(" after withdraw balance is " +a1.Balance);

            Console.WriteLine("After giving interest income on your balance " +Account.payint(a1));


        }
    }*/

    /*Create a class Employee having private instance member 
id- id is readonly property and generated by your application
name- write getter setter
salary- write getter setter
net salary
Write method who’s job is to deduct TDS 10% and return tax amount and set netsalary instance member after deducting tax.
Declare TDS as static variable.
Your application should create only 3 object if you try to create 4th object it should throw exception.
Give appropriate validation like salary can not be 0 or negative, maximum
Salary allowed is 50000 if you try to set more then 50000 it should give some error message.
When you run your application it should print name of company.
*
*/
    /*class Employee
    {
        private int id;
        static int minpid;
        string name;
        double salary;
        double net_salary;
        static double TDS = 10.0;
        const int maxcapacity = 3;

        static Employee()
        {
            Console.WriteLine("***** MICROSOFT *****");
        }
      
        public Employee(string name, double sal)
        {
            if (minpid < maxcapacity)
            {

                id = ++minpid;
                Name = name;
                salary = sal;
            } else { throw new Exception("gvg"); }
        }
        public int ID
        {
            get
            {
                return id; 
            } 
        }
        public string Name
        {
            get { return name; }
            set { name = value; }
        }
        public double Salary
        {
            get
            {
              return salary;
            }
            set 
            {
                if (value < 1 || value < 50000)
                    Console.WriteLine("error");
                else
                salary = value;
            }
        }
        public string dispaly()
        {
           return string.Format("{0} {1}" , Name, salary);
        }
    }
    public class EmpDemo
    {
        public static void Main(string[]args)
        {
            Employee e1 = new Employee("ronny", 450000);
            Employee e2 = new Employee("ronny1", 25000);
            Employee e3 = new Employee("ronny2", 15000);
            Employee e4 = null;
            try
            {
               

                 e4 = new Employee("ronny2", 15000);



            }
            catch(Exception e) 
            {
                Console.WriteLine("can't create more object");
            
            }


            Console.WriteLine(e1.dispaly());
            Console.WriteLine(e2.dispaly()); Console.WriteLine(e3.dispaly());
            Console.WriteLine(e4.dispaly());


        }
    }*/
    /*class A
    {
        public int i = 0;
        // show() in A //3
        public void show()
        {
            Console.WriteLine("i in base class: " + i);//8
        }
    }
    // Create a derived class. 
    class B : A
    {
        new int i; // this i hides the i in A 
        public B(int a, int b)//2
        {
            base.i = a; // this uncovers the i in A //4
            i = b; // i in B //5
        }
        // This hides show() in A. Notice the use of new. 
        new public void show()
        {
            base.show(); // this calls show() in A //7
                         // this displays the i in B 
            Console.WriteLine("i in derived class: " + i);//9
        }
        class UncoverName
        {
            public static void Main()
            {
                B ob = new B(1, 2);//1

                ob.show();//6
                A aref = new B(5, 3);// this will call parent class show method
                aref.show();
            }
        }

    }*/
    /* class Message
     {
         public void wemail(double a, double Balance, string name)
         {
             Console.WriteLine(" E-mail : Amount withdrawn successfully : {0} ramaining balance is: {1} name = {2}", a, Balance, name);
         }

         public void wmobile(double a, double Balance, string name)
         {
             Console.WriteLine( "Mobile : Amount withdrawn successfully : {0} ramaining balance is: {1} name = {2}", a, Balance, name);
         }
         public void depemail(double a, double Balance, string name)
         {
             Console.WriteLine(" E-mail : Amount Credited successfully : {0} ramaining balance is: {1} name = {2}", a, Balance, name);
         }

         public void depmobile(double a, double Balance, string name)
         {
             Console.WriteLine("Mobile : Amount Credited successfully : {0} ramaining balance is: {1} name = {2}", a, Balance, name);
         }
     }
 delegate void wd(double a, double Balance, string name);

     abstract class SBIAccount
     {
         public event wd wdevent;
         public event wd depevent;
         string name;
         double balance;
         const double interest = 0.07;

         public void Onwithdraw(double a, double Balance, string name)
         {
             if(wdevent !=null)
                 wdevent(a, Balance, name);
         }
         public void Ondeposite(double a, double Balance, string name)
         {
             if(depevent !=null)
                 depevent(a, Balance, name);
         }

         abstract public void withdraw(double amt);
         public virtual void deposite(double amt)
         {
             balance = amt;
         }
         public static double payint(SBIAccount s2)
         {
             double balance = s2.balance * interest;
             return balance;
         }

         public virtual string display()
         {
             return string.Format(" {0} {1} ", name, balance);
         }
     }













     class saving : SBIAccount
     {
         int savid;
         static int accid;
         string name;
         double balance;
         static double interest = 0.7;
         string Type_acc;
         // string Saving_Account;


         static saving()
         {
             Console.WriteLine("STATE BANK OF INDIA");
         }

         public saving(string nm, double bal)
         {
             savid = ++accid;
             name = nm;
             balance = bal;
             Type_acc = "Saving_Account";

         }


         public string ui
         {
             get { return Type_acc; }
         }
         public string Name
         {
             get
             {
                 return name;
             }
             set
             {
                 name = value;
             }
         }
         public double Balance
         {
             get
             {
                 return balance;
             }
             set
             {

                 balance = value;
             }
         }
         public int ID
         {
             get
             {
                 return savid;
             }
         }
         public override string display()
         {
             return "savId: " + ID + " Name:" + name + " balance= " + balance + " Type: " + Type_acc;
             // string.Format(" {0} {1} {2} {3}", ID, name, balance, ui);
         }
         public override void deposite(double amt)
         {
             balance += amt;
             Ondeposite(amt, balance, name);
         }
         public override void withdraw(double amt)
         {
             const float minbal = 1000f;      //const value

             if (balance - amt < minbal)
             {
                 Console.WriteLine("insufficient balance");
             }
             else
                 balance -= amt;
             Onwithdraw(amt, balance, name);


         }


     }





























     class current : SBIAccount,ICloneable
     {
         int curid;
         static int accid;
         string name;
         double balance;
         string Type_acc;


         static current()
         {
             Console.WriteLine("STATE BANK OF INDIA");
         }
         public current(string nm, double bal)
         {
             curid = ++accid;
             name = nm;
             balance = bal;
             Type_acc = " Current_Account ";
         }

         public string Name
         {
             get
             {
                 return name;
             }
             set
             {
                 name = value;
             }
         }
         public double Balance
         {
             get
             {
                 return balance;
             }
             set
             {
                 if (value < 1 || value < 5000000)
                 {
                     throw new Exception("invalid balance");
                 }
                 else
                     balance = value;
             }
         }
         public int ID
         {
             get
             {
                 return curid;
             }

         }
         public override string display()
         {
             return "curId: " + ID + " Name:" + name + " balance= " + balance + " Type: " + Type_acc;
         }
         public override void deposite(double amt)
         {
             balance += amt;
             Ondeposite(amt,balance,name);
         }
         public override void withdraw(double amt)
         {
             balance -= amt;
             Onwithdraw(amt,balance,name);
         }

         public object Clone()
         {
             throw new NotImplementedException();
         }
     }



















     class AccountMain
     {
         static void Main(string[] args)
         {
             Message m=new Message();

                SBIAccount[] a = new SBIAccount[100];
                a[0] = new saving("Rohit", 45000);
                a[1] = new current("Rohan", 98050);
                a[2] = new saving("Ishan", 84000);
                a[3] = new current("Jitesh", 89050);
                a[4] = new saving("Gill", 45050);




             Console.WriteLine("Before Transaction balance ....");
             Console.WriteLine(a[0].display());
             Console.WriteLine(a[1].display());
             Console.WriteLine(a[2].display());
             Console.WriteLine(a[3].display());
             Console.WriteLine(a[4].display());


             for (int i = 0; i < 5; i++)
             {
                 a[i].depevent += m.depemail;
                 a[i].depevent += m.depmobile;
             }

             Console.WriteLine("After Deposite Balance is");
             a[0].deposite(3500);
             a[1].deposite(8500);
             a[2].deposite(1000);
             a[3].deposite(6500);
             a[4].deposite(1000);

             for (int i = 0; i < 5; i++)
             {
                 a[i].wdevent += m.wemail;
                 a[i].wdevent += m.wmobile;
             }
             Console.WriteLine("After Transaction Balance is");
             a[0].withdraw(1570);
             a[1].withdraw(700);
             a[2].withdraw(100);
             a[3].withdraw(890);
             a[4].withdraw(586);
             Array.Sort(a, (a, b) => string.Compare(a.Name, b.Name));

             // Display the account details
             foreach (SBIAccount account in a)
             {
                 Console.WriteLine("Name: {0}\nAccount Number: {1}\nBalance: {2:C}\n",
                     SBIAccount.Name, SBIAccount.AccountNumber, SBIAccount.Balance);
             }

         }
     }*/

    // Sort the array by name in ascending order
    /*Array.Sort(accounts, (a, b) => string.Compare(a.Name, b.Name));

    // Display the account details
    foreach (Account account in accounts)
    {
        Console.WriteLine("Name: {0}\nAccount Number: {1}\nBalance: {2:C}\n",
            account.Name, account.AccountNumber, account.Balance);
    }*/
    /* class Program
     {
         static void Main(string[] args)
         {
             Console.WriteLine("***** Fun with Anonymous Types *****\n");

             // Make an anonymous type representing a car using hard coded data. 
             var myCar = new { Color = "Bright Pink", Make = "Saab", CurrentSpeed = 55 };
             ReflectOverAnonymousType(myCar);
             Console.ReadKey();

         }
         static void ReflectOverAnonymousType(object obj)
         {
             Console.WriteLine("Base class of {0} is {1}", obj.GetType().Name, obj.GetType().BaseType);

             Console.WriteLine("obj.ToString() == {0}", obj.ToString());
             Console.WriteLine("obj.GetHashCode() == {0}", obj.GetHashCode());
             Console.WriteLine();
         }
     }*/
    /*delegate void MyEventHandler();

    // Declare an event class. 
    class MyEvent
    {
        public event MyEventHandler SomeEvent;

        // This is called to fire the event. 
        public void OnSomeEvent()
        {
            if (SomeEvent != null)
                SomeEvent();
        }
    }

    class X
    {
        public void Xhandler()
        {
            Console.WriteLine("Event received by X object");
        }
    }
    class Y
    {
        public void Yhandler()
        {
            Console.WriteLine("Event received by Y object");
        }
    }

    class EventDemo
    {
        static void handler()
        {
            Console.WriteLine("Event received by EventDemo");
        }



    
    public static void Main()
    {
        MyEvent evt = new MyEvent();
        X xOb = new X();
        Y yOb = new Y();
        // Add handlers to the event list. 

        evt.SomeEvent += new MyEventHandler(handler);

        evt.SomeEvent += new MyEventHandler(xOb.Xhandler);

        evt.SomeEvent += yOb.Yhandler;

        // Fire the event. 
        evt.OnSomeEvent();
        Console.WriteLine();

        // Remove a handler. 
        evt.SomeEvent -= new MyEventHandler(xOb.Xhandler);
        evt.OnSomeEvent();
    }
}*/



    /*Create abstract class Employee having member id, name, salary, netsalary
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
Crate Array of Employee and store all child class object.     */

    /*abstract class Employee
    {
        int id;
        string name;
        double salary;
        double netsalary;
        abstract public void givebouns(double amt);
        public Employee(string name, double salary)
        {
            id = ++id;
            this.name = name;
            this.salary = salary;
        }
        public string Name
        {
            get { return name; }
            set { name = value; }
        }
        public double Salary
        {
            get { return salary; }
            set { salary = value; }
        }
        public int ID
        {
            get
            {
                return id;
            }
        }
    }
    class tempemp : Employee
    {
       
    }
    public class main
    {

    }*/

    /* delegate void CountIt(int end);
     class AnonMethDemo2
     {

         static void Main()
         {
             // Here, the ending value for the count
             // is passed to the anonymous method.
             int nn = 1;
             CountIt count, c, call;
             count = delegate (int end)
             {
                 for (int i = 0; i <= end; i++)
                     Console.WriteLine(i);
             };

             c = delegate (int no) { Console.WriteLine(no * no); };
             call = count + c;
             call(3);
             Console.WriteLine();
             call -= c;
             call(5);
             /*demodel obj=new demodel();
            CountIt dem=obj.printnum;
             dem(5);

         }
     }
    */
    /*  delegate int CountIt(int end);

      class AnonMethDemo3
      {
          static void Main()
          {
              int result;
              // Here, the ending value for the count
              // is passed to the anonymous method.
              // A summation of the count is returned.
              CountIt count = delegate (int end)
              {

                  for (int i = 0; i <= end; i++)
                  {
                      Console.WriteLine(i);

                  }
                  return end; // return a value from an anonymous method
              };
              result = count(3);
              Console.WriteLine("Summation of 3 is " + result);
              Console.WriteLine();
              result = count(5);
              Console.WriteLine("Summation of 5 is " + result);
          }
      }*/
    /* using System;
     using System.Linq;

     public class Account
     {
         public string Name { get; set; }
         public decimal Balance { get; set; }
     }

     public class ChildAccount : Account
     {
         public string ParentName { get; set; }
     }

     class Program
     {
         static void Main(string[] args)
         {
             // Create an array of Account class objects
             Account[] accounts = new Account[3];

             // Populate the array with child objects
             accounts[0] = new ChildAccount { Name = "Alice", Balance = 100, ParentName = "Bob" };
             accounts[1] = new ChildAccount { Name = "Charlie", Balance = 50, ParentName = "Dave" };
             accounts[2] = new ChildAccount { Name = "Eve", Balance = 75, ParentName = "Frank" };

             // Display the balances of the users in descending order
             var sortedAccounts = accounts.OrderBy(a => a.Name);
             foreach (var account in sortedAccounts)
             {
                 Console.WriteLine("{0}: {1}", account.Name, account.Balance);
             }
         }
     }*/

    /*internal class Notification
    {
        public void EmailWD(double amount, double balance, string name)
        {
            Console.WriteLine($"EMAIL: Hello {name}, ₹{amount} withdrawn from your account. New Balance: ₹{balance}");
        }

        public void SMSWD(double amount, double balance, string name)
        {
            Console.WriteLine($"SMS: Hello {name}, ₹{amount} withdrawn from your account. New Balance: ₹{balance}");
        }
        public void EmailD(double amount, double balance, string name)
        {
            Console.WriteLine($"EMAIL: Hello {name}, ₹{amount} deposited to your account. New Balance: ₹{balance}");
        }

        public void SMSD(double amount, double balance, string name)
        {
            Console.WriteLine($"SMS: Hello {name}, ₹{amount} deposited to your account. New Balance: ₹{balance}");
        }
    }


    public delegate void Withdraw(double amount, double balance, string name);
    public delegate void Deposit(double amount, double balance, string name);
    public abstract class Account : IComparable<Account>
    {
        public event Withdraw OnWd;
        public event Deposit OnD;
        static int getID;
        int id;
        string name;
        double balance;
        string type;
        public string Name
        {
            get { return name; }
            set { name = value; }
        }
        public double Balance
        {
            get
            {
                return balance;
            }
            set
            {
                if (this is SavingsAccount)
                {
                    if (value < 0)
                        throw new Exception("Invalid Minimum Balance");
                    balance = value;
                }
                if (this is CurrentAccount)
                {
                    balance = value;
                }
            }
        }
        public int ID
        {
            get { return id; }
        }

        public string Type
        {
            get { return type; }
        }
        static Account()
        {
            Console.WriteLine("HDFC Bank");
        }

        public Account(string name, double balance, string type)
        {
            Name = name;
            Balance = balance;
            id = ++getID;
            this.type = type;
        }

        public abstract void WithDraw(double amount);
        public abstract void Display();

        public virtual void Deposit(double amount)
        {
            if (amount > 0)
            {
                Balance += amount;
                OnDeposit(amount, Balance, Name);
            }
            else
                throw new Exception("Invalid Deposit Amount");
        }


        //Sorting by Balance
        public int CompareTo(Account? other)
        {
            Account obj = other as Account;
            return this.Balance.CompareTo(obj?.Balance);
        }

        //Event for Withdraw
        public void OnWithdraw(double amount, double balance, string name)
        {
            if (OnWd != null)
            {
                OnWd(amount, balance, name);
            }
        }

        //Event for Deposit
        public void OnDeposit(double amount, double balance, string name)
        {
            if (OnD != null)
            {
                OnD(amount, balance, name);
            }
        }
    }



    internal class CurrentAccount : Account
    {
        double ODLimit;

        public double ODLIMIT
        {
            get { return ODLimit; }

        }
        public CurrentAccount(string name, double balance, string type, double ODLimit) : base(name, balance, type)
        {
            if (ODLimit > 0)
            {
                this.ODLimit = ODLimit;
            }
        }
        public override void WithDraw(double amount)
        {
            if (amount > 0)
            {
                Balance -= amount;
            }
            OnWithdraw(amount, Balance, Name);
        }

        public override void Display()
        {
            Console.WriteLine($"ID: {ID}, Name: {Name}, Balance: {Balance}, Type: {Type}");
        }
    }




    internal class SavingsAccount : Account
    {
        const int minBalance = 1000;

        public SavingsAccount(string name, double balance, string type) : base(name, balance, type) { }

        public override void WithDraw(double amount)
        {
            if ((Balance - amount) > minBalance)
                Balance -= amount;
            else
                throw new Exception("Balance not Sufficient");
            OnWithdraw(amount, Balance, Name);
        }

        public override void Display()
        {
            Console.WriteLine($"ID: {ID}, Name: {Name}, Balance: {Balance}, Type: {Type}");
        }




    }



    internal class AccMain
    {
        public static void Main()
        {
            Account[] Saving = new SavingsAccount[5];
            Account[] Current = new CurrentAccount[5];

            try
            {
                Saving[0] = new SavingsAccount("Raj", 10000, "Savings Account");
                Saving[1] = new SavingsAccount("Mona", 20000, "Savings Account");
                Current[1] = new CurrentAccount("InFo", 80000, "Current Account", 600000);
                Current[2] = new CurrentAccount("MaxIT", 66000, "Current Account", 790000);
                Saving[2] = new SavingsAccount("Axel", 5000, "Savings Account");

                Saving[4] = new SavingsAccount("Raghav", 65000, "Savings Account");

                Current[0] = new CurrentAccount("Apple", 100000, "Current Account", 1000000);
                Saving[3] = new SavingsAccount("Mohan", 57000, "Savings Account");
                Current[3] = new CurrentAccount("Jekin", 86000, "Current Account", 96000);
                Current[4] = new CurrentAccount("RexDL", 83000, "Current Account", 458000);
            }
            catch (Exception e)
            {
                Console.WriteLine(e.ToString());
            }


            //Displaying All Savings Account
            foreach (Account a in Saving)
            {
                a.Display();
            }
            Console.WriteLine();

            //Displaying all Current Accounts
            foreach (Account a in Current)
            {
                a.Display();
            }
            Console.WriteLine();

            //Sorting by Salary Saving Accounts
            Array.Sort(Saving);
            Console.WriteLine("After Sort Using Comparable on Balance on Savings Account\n");
            foreach (Account a in Saving)
            {
                a.Display();
            }

            Console.WriteLine();

            //Sorting by Salary Current Accounts
            Array.Sort(Current);
            Console.WriteLine("After Sort Using Comparable on Balance on Current Account\n");
            foreach (Account a in Current)
            {
                a.Display();
            }

            Console.WriteLine();

            //Sorting By NameSort Class
            Array.Sort(Current, new NameSort());
            Console.WriteLine("After Name Sort Using Comparer(DESCENDING)\n");
            foreach (Account a in Current)
            {
                a.Display();
            }

            Console.WriteLine();

            //Creating Object of Notification
            Notification n = new Notification();


            //Subscribing
            for (int i = 0; i < 5; i++)
            {
                Saving[i].OnWd += n.SMSWD;
                Saving[i].OnWd += n.EmailWD;
                Current[i].OnWd += n.SMSWD;
                Current[i].OnWd += n.EmailWD;
                //Events for deposit
                Saving[i].OnD += n.SMSD;
                Saving[i].OnD += n.EmailD;
                Current[i].OnD += n.SMSD;
                Current[i].OnD += n.EmailD;
            }

            Console.WriteLine();

            //Withdrawing
            for (int i = 0; i < 2; i++)
            {
                try
                {
                    Saving[i].WithDraw(100);
                    Console.WriteLine();
                    Current[i].WithDraw(100);
                }
                catch (Exception e)
                {
                    Console.WriteLine(e.ToString());
                }

            }

            //Depositing
            for (int i = 0; i < 2; i++)
            {
                try
                {
                    Saving[i].Deposit(100);
                    Console.WriteLine();
                    Current[i].Deposit(100);
                }
                catch (Exception e) { Console.WriteLine(e.ToString()); }

            }
        }
    }


    internal class NameSort : IComparer<Account>
    {
        public int Compare(Account? x, Account? y)
        {
            Account A1 = x as Account;
            Account A2 = y as Account;
            return String.Compare(y.Name, x.Name);
        }
    }*/
    /*class a
    {
        static void QueryOverInts()
        {
            int[] numbers = { 10, 20, 30, 40, 1, 2, 3, 8 };
            // Get numbers less than ten.
            var subset = from i in numbers where i < 10 select i;

            // LINQ statement evaluated here!
            foreach (var i in subset)
                Console.WriteLine("{0} < 10", i);
            Console.WriteLine();


            // Change some data in the array.
            numbers[0] = 4;

            // Evaluated again!
            foreach (var j in subset)
                Console.WriteLine("{0} < 10", j);
            Console.WriteLine();
            
        }
    }*/

    /*class Num
    {
        static void Query()
        {
            int[] a = { 5, 8, 9, 2, 1 };
            string[] str = { "hello", "hi", "go", "bye" };
            var subset = from i in a where i <= 5 select i;

            //LINQ
            Console.WriteLine(" array grater equal to 5 ");
            foreach (var i in subset)
            {
                Console.WriteLine(i);
            }
            //updated 
            Console.WriteLine("Deferred execution");
            a[0]= 3;
            foreach (var y in subset)
            {
                Console.WriteLine(y);
            }
            Console.WriteLine();

            var subset1 = from g in a where g % 2 == 0 select g;
            Console.WriteLine(" Divide by 2 numbers ");
            foreach (var g in subset1)
            {
                Console.WriteLine(g);
               
            }

            Console.WriteLine();
            var subset2 = from f in a where f % 2 == 1 select f;
            Console.WriteLine("display all odd number\r\n");

            foreach (var f in subset2)
            {
                Console.WriteLine(f);
            }


            Console.WriteLine();
            var subset3 = from w in a where w > 8 select w;
            Console.WriteLine("display all number>=8\r\n");
            foreach (var w in subset3)
            {
                Console.WriteLine(w);
            }
            Console.WriteLine();


            var subset4 = from p in str where p.StartsWith("h") select p;
            Console.WriteLine("satrt with h");
            foreach (var p in subset4)
            {
                Console.WriteLine(p);
            }
        }
        
            static void Main(string[] args)
            {
                Query();
            }
        
    }*/
   /* class ProductInfo
    {
        public string Name { get; set; }
        public string Description { get; set; }
        public int NumberInStock { get; set; }
        public override string ToString()
        {
            return string.Format("Name={0}, Description={1}, Number in Stock={2}",
            Name, Description, NumberInStock);
        }
    }
    class entry
    {
        static void Main(string[] args)
        {
            Console.WriteLine("***** Fun with Query Expressions *****\n");
            // This array will be the basis of our testing...
            ProductInfo[] itemsInStock = new[]
             {
        new ProductInfo{ Name = "Mac's Coffee", Description = "Coffee with TEETH",
                                         NumberInStock = 24},

        new ProductInfo { Name = "Milk Maid Milk",Description = "Milk cow's love",
                                            NumberInStock = 100},

         new ProductInfo{ Name = "Pure Silk Tofu",  Description = "Bland as Possible",
                                            NumberInStock = 120},

        new ProductInfo{ Name = "Cruchy Pops",  Description = "Cheezy, peppery goodness",
                                        NumberInStock = 2},

       new ProductInfo{ Name = "RipOff Water",   Description = "From the tap to your wallet",
                                        NumberInStock = 100},

    new ProductInfo{ Name = "Classic Valpo Pizza", Description = "Everyone loves pizza!",
         NumberInStock = 73}
                                    };


            Console.WriteLine("Q1. Display all product detail");
            var query = from r in itemsInStock select r;
            foreach (var item in query)
            {
                Console.WriteLine(item);
            }


            Console.WriteLine();
            Console.WriteLine("Q2. Display all product name");
            var query1 = (from r in itemsInStock select r.Name);
            foreach (var item in query1)
            { Console.WriteLine(item); }


            Console.WriteLine();
            Console.WriteLine("Q3.All product part of data as anonymous object");
            var query2 = (from r in itemsInStock select new {Name= r.Name, des = r.Description });
            foreach(var item in query2) 
            {
                Console.WriteLine( item); 
            }

            Console.WriteLine();
            Console.WriteLine("Q4.Display all product Name ,and Description where NumberInStock=100 as anonymous object");
            var Query4 = (from r in itemsInStock where(r.NumberInStock==100) select r);
            foreach (var item in Query4)
            {
                Console.WriteLine( item);
            }

            Console.WriteLine();
            Console.WriteLine("Q.5 Display all product name having letter ‘s’ in it’s name in  ascending order");
            var Query5 = (from r in itemsInStock where r.Name.Contains("s") orderby r.Name select r);
            foreach (var item in Query5)
            {
                Console.WriteLine(item);
            }

            Console.WriteLine();
            Console.WriteLine("Q6. Display all product name having letter ‘s’ in it’s name in descending order");
            var q1 = from r in itemsInStock where r.Name.Contains("s") orderby r.Name descending select r;
            foreach (var item in q1)
            {
                Console.WriteLine(item);
            }

            Console.WriteLine();
            Console.WriteLine("Q7.count all product who’s stock is < 100");
            var r1 = from r in itemsInStock where(r.NumberInStock<100) select r;
            foreach (var item in r1)
            {
                Console.WriteLine( item);
            }

        }


    }*/


    



 }




