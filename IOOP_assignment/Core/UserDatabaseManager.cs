using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using IOOP_assignment.Models;

namespace IOOP_assignment.Core
{
    public class UserDatabaseManager
    {
        private static string connectionString;

        public static void SetConnectionString(string connString)
        {
            connectionString = connString;
        }

        public static string GetUserEmail(string username)
        {
            if (string.IsNullOrEmpty(connectionString))
            {
                MessageBox.Show("Connection string is not initialized.");
                return null;
            }

            string query = "SELECT Email FROM [User] WHERE UserName = @Username";

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@Username", username);

                try
                {
                    connection.Open();
                    object result = command.ExecuteScalar();
                    if (result != null)
                    {
                        return result.ToString();
                    }
                    else
                    {
                        return null; // User not found
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("An error occurred: " + ex.Message);
                    return null;
                }
            }
        }

        public static bool IsUsernameDuplicate(string username)
        {
            string query = "SELECT COUNT(*) FROM [User] WHERE UserName = @UserName";
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@UserName", username);
                connection.Open();
                int count = (int)command.ExecuteScalar();
                return count > 0;
            }
        }
        
        public static bool IsEmailDuplicate(string email)
        {
            string query = "SELECT COUNT(*) FROM [User] WHERE Email = @Email";
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@Email", email);
                connection.Open();
                int count = (int)command.ExecuteScalar();
                return count > 0;
            }
        }

        public static bool IsAdminDuplicate()
        {
            string query = "SELECT COUNT(*) FROM [User] WHERE RoleID = @RoleID";
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@RoleID", RoleUtility.ToUUID(Role.Administrator));
                connection.Open();
                int count = (int)command.ExecuteScalar();
                return count >= 2;
            }
        }
    }
}

    




