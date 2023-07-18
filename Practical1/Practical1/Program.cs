using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practical1
{ 
    using System.Collections.Generic;
    using System.Security.Claims;
    using System;




    internal class Notification
    {
        public void EmailWD(double amount, double balance, string name)
        {
            Console.WriteLine($"EMAIL: Hello {name}, {amount} withdrawn from your account. New Balance: {balance}");
        }

        public void SMSWD(double amount, double balance, string name)
        {
            Console.WriteLine($"SMS: Hello {name}, {amount} withdrawn from your account. New Balance: {balance}");
        }
        public void EmailD(double amount, double balance, string name)
        {
            Console.WriteLine($"EMAIL: Hello {name}, {amount} deposited to your account. New Balance: {balance}");
        }

        public void SMSD(double amount, double balance, string name)
        {
            Console.WriteLine($"SMS: Hello {name}, {amount} deposited to your account. New Balance: {balance}");
        }
    }



    public delegate void Withdraw(double amount, double balance, string name);
    public delegate void Deposit(double amount, double balance, string name);
    public abstract class Account 
    {
        public event Withdraw OnWd;
        public event Deposit OnDep;
        static int getID;
        int id;
        string name;
        double balance;
        string type;
        public string Name
        {
            get { return name; }
            set {
                if (value.Length > 2 || value.Length < 15)
                  
                name = value; 
                else
                    throw new Exception("invalid name");
            }

        }
        public double Balance
        {
            get
            {
                return balance;
            }
           protected set
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
            Console.WriteLine("Bank of Baroda");
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




        public void OnWithdraw(double amount, double balance, string name)
        {
            if (OnWd != null)
            {
                OnWd(amount, balance, name);
            }
        }

        public void OnDeposit(double amount, double balance, string name)
        {
            if (OnDep != null)
            {
                OnDep(amount, balance, name);
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
        static double interest = 0.07;
        public static double payinterest(double Balance)
        {
            double bal = Balance * 0.07;
            return Balance;
        }

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
                Account[] acc = new Account[5];
          

            try
            {
                acc[0] = new SavingsAccount("Raj", 10000, "Savings Account");
            }
            catch (Exception e)
            {
                Console.WriteLine(e.ToString());
            }
            try
            {
                acc[1] = new SavingsAccount("Roman", 10500, "Current Account");
            }
            catch (Exception e)
            {
                Console.WriteLine(e.ToString());
            }
            try
            {
                acc[2] = new SavingsAccount("Hardik", 40000, "Current Account");
            }
            catch (Exception e)
            {
                Console.WriteLine(e.ToString());
            }
            try
            {
                acc[3] = new SavingsAccount("Saha", 17000, "Savings Account");
            }
            catch (Exception e)
            {
                Console.WriteLine(e.ToString());
            }
            try
            {
                acc[4] = new SavingsAccount("Shukla", 10680, "Savings Account");
            }
            catch (Exception e)
            {
                Console.WriteLine(e.ToString());
            }
            try
            {
                acc[5] = new SavingsAccount("Rajiv", 10680, "Current Account");
            }
            catch (Exception e)
            {

                Console.WriteLine("can't create object");
            }

            acc[0].Display();
            acc[1].Display();
            acc[2].Display();
            acc[3].Display();
            acc[4].Display();

            Console.WriteLine();

            //Creating Object of Notification
            Notification n = new Notification();


            //Subscribe
            for (int i = 0; i <5; i++)
            {
                acc[i].OnWd += n.SMSWD;
                acc[i].OnWd += n.EmailWD;
            

                //Events for deposit
                acc[i].OnDep += n.SMSD;
                acc[i].OnDep += n.EmailD;
             
            }
                   acc[0].WithDraw(100);
                    Console.WriteLine();
                    acc[3].WithDraw(100);
                    Console.WriteLine();

            //deposite
                    acc[1].Deposit(100);
                    Console.WriteLine();
                    acc[4].Deposit(100);
           
        }
    }




}
