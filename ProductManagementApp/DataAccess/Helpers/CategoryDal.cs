using System.Data;

namespace ProductManagementApp.DataAccess.Helpers
{
    public static partial class Dal
    {
        public static void FillCategories(this DataTable table)
        {
            using (IDbCommand command = Connection.CreateCommand())
            {
                command.CommandText = "select id, name from categories";

                if (command.Connection.State != ConnectionState.Open)
                {
                    command.Connection.Open();
                }

                IDataReader reader = command.ExecuteReader();
                table.Load(reader);
            }
        }

        public static void AddCategory(this DataTable table, string categoryName)
        {
            using (IDbCommand command = Connection.CreateCommand())
            {
                command.CommandText = "insert into categories (`name`) values (@name)";

                if (command.Connection.State != ConnectionState.Open)
                {
                    command.Connection.Open();
                }

                IDbDataParameter parameter = command.CreateParameter();
                parameter.ParameterName = "@name";
                parameter.Value = categoryName;
                command.Parameters.Add(parameter);
                command.ExecuteNonQuery();
                table.FillCategories();
            }
        }
    }
}
