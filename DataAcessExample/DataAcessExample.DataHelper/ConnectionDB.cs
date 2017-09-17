using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAcessExample.DataHelper
{
    class ConnectionDB
    {

        public static string ConnectionString { get; set; }
        public static string ProviderName { get; set; }

        static ConnectionDB()
        {
            try
            {
                ConnectionString = ConfigurationManager.ConnectionStrings["ConnectionString"].ConnectionString;
                ProviderName = ConfigurationManager.ConnectionStrings["ConnectionString"].ProviderName;
            }
            catch (Exception)
            {
                throw new Exception("Erro ao acessar connections string");
            }
        }

    }
}
