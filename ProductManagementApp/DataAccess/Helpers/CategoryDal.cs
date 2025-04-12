using ProductManagementApp.AppCode.Extensions;
using System.Data;

namespace ProductManagementApp.DataAccess.Helpers
{
    public static partial class Dal
    {
        public static void FillCategories(this DataTable table)
        {
            using (IDbCommand command = Connection.CreateCommand("select id, name from categories;"))
            {
                IDataReader reader = command.ExecuteReader();
                table.Load(reader);
            }
        }

        public static void AddCategory(this DataTable table, string categoryName)
        {
            using (IDbCommand command = Connection
                .CreateCommand("insert into categories (`name`) values (@name);")
                .AddParameter("@name", categoryName))
            {
                command.ExecuteNonQuery();
                table.FillCategories();
            }
        }

        public static void EditCategory(this DataTable table, string categoryName, int categoryId)
        {
            using (IDbCommand command = Connection
                .CreateCommand("update categories set `name` = @name where id = @id;")
                .AddParameter("@name", categoryName)
                .AddParameter("@id", categoryId))
            {
                command.ExecuteNonQuery();
                table.FillCategories();
            }
        }
    }
}
