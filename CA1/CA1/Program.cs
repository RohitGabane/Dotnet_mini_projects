using Microsoft.Extensions.Configuration;

namespace CA1
{
  
        class Program
        {
            private static IConfiguration _iconfiguration;
            static void Main(string[] args)
            {
                GetAppSettingsFile();
            PrintProduct();
            }

       

        static void GetAppSettingsFile()
            {
                var builder = new ConfigurationBuilder()
                .SetBasePath(Directory.GetCurrentDirectory())
                .AddJsonFile("json1.json", optional: false, reloadOnChange: true);
                _iconfiguration = builder.Build();
            }
       
        static void Printproduct()
            {
                Productlayer obj = new Productlayer();
                obj.Products();

            }
        }

    
}