using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoffeShop
{
    public class DBConnector
    {
        string connectionString = @"server=(local)\SQLEXPRESS; Integrated Security=SSPI; Initial Catalog=CoffeShopLogIn";

        SqlConnection connection = null;
        public DBConnector()
        {
            connection = new SqlConnection(connectionString);

        }

        public SqlConnection Connection { get => connection; }
    }
}
