using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

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
                    string query = "SELECT [FoodOrder], [OrderDateTime], [OrderStatus], [OrderID] FROM [ioop].[dbo].[Order]";
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

