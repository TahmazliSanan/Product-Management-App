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
    }
}
