using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Account
{
    /* abstract class SBIAccount
     {
         string name;
         double balance;
         const double interest = 0.07;
         abstract public void withdraw(double amt);
         public virtual void deposite(double amt)
         {
             balance = amt;
         }
         public static double payint(SBIAccount s2)
         {
             double balance= s2.balance * interest;
             return balance;
         }

         public virtual string display()
         {
             return string.Format(" {0} {1} " , name ,balance);
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
            return "savId: " +ID + " Name:" +name + " balance= " +balance + " Type: " +Type_acc;
           // string.Format(" {0} {1} {2} {3}", ID, name, balance, ui);
         }
         public override void deposite(double amt)
         {
             balance += amt;
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
         }
     }





























     class current : SBIAccount
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
         }
         public override void withdraw(double amt)
         {
             balance -= amt;
         }


     }



















     class AccountMain
     {
         static void Main(string[] args)
         {
             saving s1 = new saving("Rohit",45000);
             current c1 = new current("Rohan",98050);
             saving s2 = new saving("Ishan", 84000);
             current c2 = new current("Jitesh", 89050);
             saving s3 = new saving("Gill", 45050);


             Console.WriteLine(" Before Transaction balance ....");
             Console.WriteLine(c1.display());
             Console.WriteLine(s1.display());
             Console.WriteLine(c2.display());
             Console.WriteLine(s2.display());
             Console.WriteLine(s3.display());

             Console.WriteLine(" After Deposite Balance is ");
             c1.deposite(3500);
             c2.deposite(8500);
             s1.deposite(1000);
             s2.deposite(6500);
             s3.deposite(1000);

             Console.WriteLine(c1.display());
             Console.WriteLine(s1.display());
             Console.WriteLine(c2.display());
             Console.WriteLine(s2.display());
             Console.WriteLine(s3.display());



             Console.WriteLine(" After Transaction Balance is ");
             s2.withdraw(100);
             s1.withdraw(100);
             s3.withdraw(100);
             c1.withdraw(100);
             c2.withdraw(1000000);

             Console.WriteLine(c1.display());
             Console.WriteLine(s1.display());
             Console.WriteLine(c2.display());
             Console.WriteLine(s2.display());
             Console.WriteLine(s3.display());

         }
     }*/











    class Message
    {
        public void wemail(double a, double Balance, string name)
        {
            Console.WriteLine(" E-mail : Amount withdrawn successfully : {0} ramaining balance is: {1} name = {2}", a, Balance, name);
        }

        public void wmobile(double a, double Balance, string name)
        {
            Console.WriteLine("Mobile : Amount withdrawn successfully : {0} ramaining balance is: {1} name = {2}", a, Balance, name);
        }
        public void depemail(double a, double Balance, string name)
        {
            Console.WriteLine(" E-mail : Amount deposite successfully : {0} ramaining balance is: {1} name = {2}", a, Balance, name);
        }

        public void depmobile(double a, double Balance, string name)
        {
            Console.WriteLine("Mobile : Amount deposite successfully : {0} ramaining balance is: {1} name = {2}", a, Balance, name);
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
            if (wdevent != null)
                wdevent(a, Balance, name);
        }
        public void Ondeposite(double a, double Balance, string name)
        {
            if (depevent != null)
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





























    class current : SBIAccount
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
            Ondeposite(amt, balance, name);
        }
        public override void withdraw(double amt)
        {
            balance -= amt;
            Onwithdraw(amt, balance, name);
        }


    }



















    class AccountMain
    {
        static void Main(string[] args)
        {
            Message m = new Message();

            SBIAccount[] a = new SBIAccount[5];
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

        }
    }

}
