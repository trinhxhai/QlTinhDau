using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.Common;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QL_ban_tinh_dau.Business
{
    public class DataBaseConnection
    {
        public static DbConnection GetDatabaseConnection()
        {
            ConnectionStringSettings setting = ConfigurationManager.ConnectionStrings["data_base"];
            DbProviderFactory factory = DbProviderFactories.GetFactory(setting.ProviderName);
            DbConnection conn = factory.CreateConnection();
            conn.ConnectionString = setting.ConnectionString;
            return conn;

        }
    }
}
