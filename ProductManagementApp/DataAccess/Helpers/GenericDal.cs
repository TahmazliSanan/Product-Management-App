using MySql.Data.MySqlClient;
using System.Data;

namespace ProductManagementApp.DataAccess.Helpers
{
    public static partial class Dal
    {
        static MySqlConnection connection = null;
        static object lockObject = new object();

        public static IDbConnection Connection
        {
            get
            {
                if (connection is null)
                {
                    lock (lockObject)
                    {
                        if (connection is null)
                        {
                            connection = new MySqlConnection("Server=localhost;Database=product_management_db;Uid=root;Pwd=23042002;");
                        }
                    }
                }

                return connection;
            }
        }
    }
}
