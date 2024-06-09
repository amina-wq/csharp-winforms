using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using IOOP_assignment.Core;
using IOOP_assignment.Models;

namespace IOOP_assignment.Forms
{
    public partial class AdminEditChef : UserControl
    {
        private string connectionString = ConfigurationManager.ConnectionStrings["ioop"].ToString();
        private List<string> allUsernames = new List<string>();
        public AdminEditChef()
        {
            InitializeComponent();
            LoadUsernames();
        }

        private void AdminExit_Click(object sender, EventArgs e)
        {
            this.Visible = false;
        }

        private void LoadUsernames()
        {
            listBoxUsers.Items.Clear();    
            allUsernames.Clear();     
            string query = "SELECT UserName FROM [User] WHERE RoleID = @RoleID";

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@RoleID", RoleUtility.ToUUID(Role.Chef));

                try
                {
                    connection.Open();
                    SqlDataReader reader = command.ExecuteReader();
                    while (reader.Read())
                    {
                        string username = reader["UserName"].ToString();
                        listBoxUsers.Items.Add(username);
                        allUsernames.Add(username);      
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("An error occurred: " + ex.Message);
                }
            }
        }

        private void listBoxUsers_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listBoxUsers.SelectedIndex != -1)
            {
                string selectedUsername = listBoxUsers.SelectedItem.ToString();
                string query = "SELECT UserName, Email, Password FROM [User] WHERE UserName = @UserName";

                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    SqlCommand command = new SqlCommand(query, connection);
                    command.Parameters.AddWithValue("@UserName", selectedUsername);

                    try
                    {
                        connection.Open();
                        SqlDataReader reader = command.ExecuteReader();
                        if (reader.Read())
                        {
                            txtUsername.Text = reader["Username"].ToString();
                            txtEmail.Text = reader["Email"].ToString();
                            ;
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("An error occurred: " + ex.Message);
                    }
                }
            }
        }

        private void btnChangePassword_Click(object sender, EventArgs e)
        {
            if (listBoxUsers.SelectedIndex != -1)
            {
                string selectedUsername = listBoxUsers.SelectedItem.ToString();
                string newPassword = txtPassword.Text;

                if (!PasswordValidator.IsPasswordComplex(newPassword))
                {
                    MessageBox.Show("Password must contain at least 1 uppercase letter, 1 number, and 1 symbol.", "Validation Error",
                        MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                if (!string.IsNullOrEmpty(newPassword))
                {
                    bool success = UpdatePasswordInDatabase(selectedUsername, newPassword);
                    if (success)
                    {
                        MessageBox.Show("Password updated successfully.");
                        txtPassword.Clear();
                    }
                    else
                    {
                        MessageBox.Show("Failed to update password.");
                    }
                }
                else
                {
                    MessageBox.Show("Please enter a new password.");
                }
            }
            else
            {
                MessageBox.Show("Please select a user.");
            }
        }

        private bool UpdatePasswordInDatabase(string username, string newPassword)
        {
            byte[] hashedPassword = PasswordHasher.HashPassword(newPassword);

            string updateQuery = "UPDATE [User] SET Password = @NewPassword WHERE UserName = @Username";

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                SqlCommand command = new SqlCommand(updateQuery, connection);
                command.Parameters.AddWithValue("@NewPassword", hashedPassword);
                command.Parameters.AddWithValue("@Username", username);

                try
                {
                    connection.Open();
                    int rowsAffected = command.ExecuteNonQuery();
                    return rowsAffected > 0;
                }
                catch (Exception ex)
                {
                    MessageBox.Show("An error occurred: " + ex.Message);
                    return false;
                }
            }
        }

        private void btnSaveEdit_Click(object sender, EventArgs e)
        {
            UserDatabaseManager.SetConnectionString(connectionString);

            if (listBoxUsers.SelectedIndex != -1)
            {
                string selectedUsername = listBoxUsers.SelectedItem.ToString();
                string newUsername = txtUsername.Text;
                string newEmail = txtEmail.Text;

                if (newUsername == selectedUsername && newEmail == UserDatabaseManager.GetUserEmail(selectedUsername))
                {
                    MessageBox.Show("No changes detected.", "Validation Error", MessageBoxButtons.OK,
                        MessageBoxIcon.Warning);
                    return;
                }

                if (!EmailValidator.IsValidEmail(newEmail))
                {
                    MessageBox.Show("Email must be valid.", "Validation Error", MessageBoxButtons.OK,
                        MessageBoxIcon.Warning);
                    return;
                }

                if (UserDatabaseManager.IsUsernameDuplicate(newUsername))
                {
                    MessageBox.Show("Username already exists.", "Duplicate Username",
                        MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                if (UserDatabaseManager.IsEmailDuplicate(newEmail))
                {
                    MessageBox.Show("Email already exists.", "Duplicate Email",
                        MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                if (!string.IsNullOrEmpty(newUsername) && !string.IsNullOrEmpty(newEmail))
                {
                    bool success = UpdateUserDetailsInDatabase(selectedUsername, newUsername, newEmail);
                    if (success)
                    {
                        MessageBox.Show("User details updated successfully.");
                        LoadUsernames();     
                    }
                    else
                    {
                        MessageBox.Show("Failed to update user details.");
                    }
                }
                else
                {
                    MessageBox.Show("Please enter both username and email.");
                }
            }
            else
            {
                MessageBox.Show("Please select a user.");
            }
        }

        private bool UpdateUserDetailsInDatabase(string oldUsername, string newUsername, string newEmail)
        {
            string updateQuery = "UPDATE [User] SET UserName = @NewUsername, Email = @NewEmail WHERE UserName = @OldUsername";

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                SqlCommand command = new SqlCommand(updateQuery, connection);
                command.Parameters.AddWithValue("@NewUsername", newUsername);
                command.Parameters.AddWithValue("@NewEmail", newEmail);
                command.Parameters.AddWithValue("@OldUsername", oldUsername);

                try
                {
                    connection.Open();
                    int rowsAffected = command.ExecuteNonQuery();
                    return rowsAffected > 0;
                }
                catch (Exception ex)
                {
                    MessageBox.Show("An error occurred: " + ex.Message);
                    return false;
                }
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (listBoxUsers.SelectedIndex != -1)
            {
                string selectedUsername = listBoxUsers.SelectedItem.ToString();

                var confirmationResult = MessageBox.Show("Are you sure you want to delete this user?", "Confirm Deletion", MessageBoxButtons.YesNo);
                if (confirmationResult == DialogResult.Yes)
                {
                    bool success = DeleteUserFromDatabase(selectedUsername);
                    if (success)
                    {
                        MessageBox.Show("User deleted successfully.");
                        LoadUsernames();     
                    }
                    else
                    {
                        MessageBox.Show("Failed to delete user.");
                    }
                }
            }
            else
            {
                MessageBox.Show("Please select a user.");
            }
        }

        private bool DeleteUserFromDatabase(string username)
        {
            string deleteQuery = "DELETE FROM [User] WHERE UserName = @Username";

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                SqlCommand command = new SqlCommand(deleteQuery, connection);
                command.Parameters.AddWithValue("@Username", username);

                try
                {
                    connection.Open();
                    int rowsAffected = command.ExecuteNonQuery();
                    if (rowsAffected > 0)
                    {
                        txtUsername.Clear();
                        txtEmail.Clear();
                    }
                    return rowsAffected > 0;
                }
                catch (Exception ex)
                {
                    MessageBox.Show("An error occurred: " + ex.Message);
                    return false;
                }
            }
        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            string searchText = txtSearch.Text.ToLower();
            listBoxUsers.Items.Clear();
            var filteredUsernames = allUsernames.Where(u => u.ToLower().Contains(searchText)).ToArray();
            listBoxUsers.Items.AddRange(filteredUsernames);
        }
    }
}
