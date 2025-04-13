using ProductManagementApp.AppCode.Extensions;
using System.Data;

namespace ProductManagementApp.DataAccess.Helpers
{
    public static partial class Dal
    {
        public static void FillProducts(this DataTable table)
        {
            using (IDbCommand command = Connection
                .CreateCommand(@"
                                select
	                                p.id, p.`name`, p.stock_keeping_unit, p.price, p.category_id,
                                    c.`name` category_name, p.unit_id, u.`name` unit_name
                                from products p
                                join categories c on p.category_id = c.id
                                join units u on p.unit_id = u.id
                                where p.deleted_date is null;"))
            {
                IDataReader reader = command.ExecuteReader();
                table.Clear();
                table.Load(reader);
            }
        }

        public static void AddProduct(this DataTable table, string productName, 
            int stockKeepingUnit, decimal price, int categoryId, int unitId)
        {
            using (IDbCommand command = Connection
                .CreateCommand(@"
                                insert into products (`name`, stock_keeping_unit, price, category_id, unit_id)
                                values (@name, @stock_keeping_unit, @price, @category_id, @unit_id);")
                .AddParameter("@name", productName)
                .AddParameter("@stock_keeping_unit", stockKeepingUnit)
                .AddParameter("@price", price)
                .AddParameter("@category_id", categoryId)
                .AddParameter("@unit_id", unitId))
            {
                command.ExecuteNonQuery();
                table.FillProducts();
            }
        }

        public static void EditProduct(this DataTable table, string productName,
            int stockKeepingUnit, decimal price, int categoryId, int unitId, 
            int productId)
        {
            using (IDbCommand command = Connection
                .CreateCommand(@"
                                update products set 
	                                `name` = @name, stock_keeping_unit = @stock_keeping_unit, 
                                    price = @price, category_id = @category_id, unit_id = @unit_id
                                where id = @id;")
                .AddParameter("@name", productName)
                .AddParameter("@stock_keeping_unit", stockKeepingUnit)
                .AddParameter("@price", price)
                .AddParameter("@category_id", categoryId)
                .AddParameter("@unit_id", unitId)
                .AddParameter("@id", productId))
            {
                command.ExecuteNonQuery();
                table.FillProducts();
            }
        }

        public static void DeleteProduct(this DataTable table, int productId)
        {
            using (IDbCommand command = Connection
                .CreateCommand("update products set deleted_date = now() where id = @id;")
                .AddParameter("@id", productId))
            {
                command.ExecuteNonQuery();
                table.FillProducts();
            }
        }
    }
}
