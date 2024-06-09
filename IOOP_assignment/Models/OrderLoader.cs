using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Reflection;

namespace IOOP_assignment.Models
{
    internal class OrderLoader
    {
        private SQLConnect _sqlConnect;

        public OrderLoader(SQLConnect sqlConnect)
        {
            _sqlConnect = sqlConnect;
        }

        public DataTable GetOrders()
        {
            DataTable table = new DataTable();
            try
            {
                using (SqlConnection connection = _sqlConnect.GetConnection())
                {
                    connection.Open();
                    string query = @"
                    SELECT [Order].OrderID, [Order].OrderDateTime, MenuItem.ItemName,[Order].OrderStatus FROM [Order]
                    INNER JOIN 
                        OrderItem ON [Order].OrderID = OrderItem.OrderID
                    INNER JOIN 
                        MenuItem ON OrderItem.ItemID = MenuItem.ItemID";
                    SqlDataAdapter adapter = new SqlDataAdapter(query, connection);
                    adapter.Fill(table);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error occurred: {ex.Message}");
            }
            return table;
        }
    }
}

