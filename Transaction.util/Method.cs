using Microsoft.Extensions.Configuration;

namespace Transaction.util
{
    public class Method
    {
        public static string GetStringConn()
        {
            IConfigurationRoot config = new ConfigurationBuilder()
                .SetBasePath(AppDomain.CurrentDomain.BaseDirectory)
                .AddJsonFile("appsettings.json")
                .Build();

            return config.GetConnectionString("Dev");
        }
    }
}
