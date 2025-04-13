using ProductManagementApp.AppCode.Extensions;
using ProductManagementApp.DataAccess.DataSets;
using System.Data;
using System.Windows.Forms;

namespace ProductManagementApp.DataAccess.Helpers
{
    public static partial class Dal
    {
        public static void FillUnits(this DataTable table)
        {
            using (IDbCommand command = Connection
                .CreateCommand("select id, name from units where deleted_date is null;"))
            {
                IDataReader reader = command.ExecuteReader();
                table.Clear();
                table.Load(reader);
            }
        }

        public static void FillUnitsToComboBox(this ComboBox box)
        {
            ProductManagementDs ds = new ProductManagementDs();
            ds.Units.FillUnits();
            box.DataSource = ds.Units;
            box.DisplayMember = "name";
            box.ValueMember = "id";
        }

        public static void AddUnit(this DataTable table, string unitName)
        {
            using (IDbCommand command = Connection
                .CreateCommand("insert into units (`name`) values (@name);")
                .AddParameter("@name", unitName))
            {
                command.ExecuteNonQuery();
                table.FillUnits();
            }
        }

        public static void EditUnit(this DataTable table, string unitName, int unitId)
        {
            using (IDbCommand command = Connection
                .CreateCommand("update units set `name` = @name where id = @id;")
                .AddParameter("@name", unitName)
                .AddParameter("@id", unitId))
            {
                command.ExecuteNonQuery();
                table.FillUnits();
            }
        }

        public static void DeleteUnit(this DataTable table, int unitId)
        {
            using (IDbCommand command = Connection
                .CreateCommand("update units set deleted_date = now() where id = @id;")
                .AddParameter("@id", unitId))
            {
                command.ExecuteNonQuery();
                table.FillUnits();
            }
        }
    }
}
