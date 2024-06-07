using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace IOOP_assignment.Models
{
    internal class Manage_Order_Status
    {
        private SQLConnect _sqlConnect;

        public Manage_Order_Status(SQLConnect sqlConnect)
        {
            _sqlConnect = sqlConnect;
        }

        public void UpdateOrderStatus(Guid orderId, string newStatus)
        {
            using (SqlConnection connection = _sqlConnect.GetConnection())
            {
                try
                {
                    connection.Open();
                    string query = "UPDATE [ioop].[dbo].[Order] SET [OrderStatus] = @Status WHERE [OrderID] = @OrderID";
                    SqlCommand command = new SqlCommand(query, connection);
                    command.Parameters.AddWithValue("@Status", newStatus);
                    command.Parameters.AddWithValue("@OrderID", orderId);
                    command.ExecuteNonQuery();
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"An error occurred: {ex.Message}");
                }
            }
        }
    }
}
