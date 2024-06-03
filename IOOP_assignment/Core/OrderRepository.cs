using IOOP_assignment.Models;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IOOP_assignment.Core
{
    internal class OrderRepository
    {
        private readonly DBManager _database;

        public OrderRepository(DBManager dbManager)
        {
            _database = dbManager;
        }

        public void CreateOrder(Guid customerId, List<MenuItem> items)
        {
            string query = "INSERT INTO [dbo].[Order] (OrderID, CustomerID, OrderDateTime, OrderStatus) VALUES (@OrderID, @CustomerID, @OrderDateTime, @OrderStatus)";
            string orderItemQuery = "INSERT INTO [dbo].[OrderItem] (OrderItemID, ItemID, OrderID) VALUES (@OrderItemID, @ItemID, @OrderID)";

            Guid orderId = Guid.NewGuid();
            Guid orderItemId;

            using (SqlConnection connection = _database.GetConnection())
            {
                connection.Open();
                SqlTransaction transaction = connection.BeginTransaction();

                try
                {
                    SqlCommand command = new SqlCommand(query, connection, transaction);
                    command.Parameters.AddWithValue("@OrderID", orderId);
                    command.Parameters.AddWithValue("@CustomerID", customerId);
                    command.Parameters.AddWithValue("@OrderDateTime", DateTime.Now);
                    command.Parameters.AddWithValue("@OrderStatus", "Pending");
                    command.ExecuteNonQuery();

                    foreach (var item in items)
                    {
                        orderItemId = Guid.NewGuid();
                        SqlCommand orderItemCommand = new SqlCommand(orderItemQuery, connection, transaction);
                        orderItemCommand.Parameters.AddWithValue("@OrderItemID", orderItemId);
                        orderItemCommand.Parameters.AddWithValue("@ItemID", item.ItemID);
                        orderItemCommand.Parameters.AddWithValue("@OrderID", orderId);
                        orderItemCommand.ExecuteNonQuery();
                    }

                    transaction.Commit();
                }
                catch (Exception ex)
                {
                    Console.WriteLine("An error occurred: " + ex.Message);
                    transaction.Rollback();
                }
            }
        }
    }
}

