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
        private readonly MenuRepository _menuRepository;


        public OrderRepository(DBManager dbManager)
        {
            _database = dbManager;
            _menuRepository = new MenuRepository(dbManager);
        }

        public List<Order> GetOrders(Customer customer)
        {
            List<Order> orders = new List<Order>();

            using (SqlConnection con = new SqlConnection(_database.GetConnection().ConnectionString))
            {
                con.Open();

                string queryOrders = @"
                    SELECT OrderID, CustomerID, OrderDateTime, OrderStatus
                    FROM [Order]
                    WHERE CustomerID = @CustomerID
                    ORDER BY OrderDateTime DESC";

                using (SqlCommand cmd = new SqlCommand(queryOrders, con))
                {
                    cmd.Parameters.AddWithValue("@CustomerID", customer.UserID);

                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            Order order = new Order
                            {
                                OrderID = reader.GetGuid(0),
                                Customer = customer,
                                DateTime = reader.GetDateTime(2),
                                OrderStatus = reader.GetString(3),
                                MenuItems = new List<MenuItem>()
                            };

                            orders.Add(order);
                        }
                    }
                }

                if (orders.Count > 0)
                {
                    string orderIds = string.Join(",", orders.Select(o => $"'{o.OrderID}'"));
                    string queryOrderItems = $@"
                        SELECT oi.OrderID, oi.ItemID
                        FROM [OrderItem] oi
                        WHERE oi.OrderID IN ({orderIds})";

                    using (SqlCommand cmd = new SqlCommand(queryOrderItems, con))
                    {
                        using (SqlDataReader reader = cmd.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                Guid orderId = reader.GetGuid(0);
                                Guid itemId = reader.GetGuid(1);

                                Order order = orders.FirstOrDefault(o => o.OrderID == orderId);
                                if (order != null)
                                {
                                    MenuItem menuItem = _menuRepository.GetItem(itemId);
                                    order.MenuItems.Add(menuItem);
                                }
                            }
                        }
                    }
                }
            }

            return orders;
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

