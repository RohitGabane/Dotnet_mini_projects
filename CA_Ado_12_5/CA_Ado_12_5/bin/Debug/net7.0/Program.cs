using CA_Ado_12_5.DAL;
using CA_Ado_12_5.Modal;
using Microsoft.Extensions.Configuration;

namespace CA_Ado_12_5
{
    internal class Program
    {
        private static IConfiguration _iconfiguration;
        static void Main(string[] args)
        {
            GetAppSettingsFile();
            StoreAcc();
        }
        static void GetAppSettingsFile()
        {
            var builder = new ConfigurationBuilder()
            .SetBasePath(Directory.GetCurrentDirectory())
            .AddJsonFile("appsettings.json", optional: false, reloadOnChange: true);
            _iconfiguration = builder.Build();
        }
        static void StoreAcc()
        {
            Acclayer Acc1 = new Acclayer(_iconfiguration);
           /* Account a = new Account { Name="PRIYA" , Balance=500};
            Acc1.AddData(a);*/
            //Console.WriteLine("Enter the  Id you want to search ");
            //string? str = Console.ReadLine();
            //int id = Convert.ToInt32(str);
            Acc1.search(1,"Rohit");

            List<Account> Acc = Acc1.search(3, "Rohit");
            foreach (Account account in Acc)
            { Console.WriteLine(account); }

            int row = Acc1.deletedata(50);
            Console.WriteLine("The number of row affected is " + row);
            Account e = new Account();
            e.Name = "shubhs";
            e.Balance = 145112;
            row = Acc1.updatedata(e);
            Console.WriteLine();



        }

    }
}