using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.Remoting.Contexts;
using IOOP_assignment.Core;
using System.Security.Cryptography;
using System.Text.RegularExpressions;
using System.Configuration;
using IOOP_assignment.Models;

namespace IOOP_assignment.Forms.AdminAddUser
{
    public partial class AdminAddAdmin : UserControl
    {
        private string connectionString;
        private SqlConnection c = new SqlConnection(
                ConfigurationManager.ConnectionStrings["ioop"].ToString());

        public AdminAddAdmin()
        {
            InitializeComponent();
            connectionString =
                (ConfigurationManager.ConnectionStrings["ioop"].ToString());
        }

        private void InsertNewUser(Guid newUserId, Guid managerRoleId, string username, string email,
            byte[] hashedPassword)
        {
            string connectionString =
                (ConfigurationManager.ConnectionStrings["ioop"].ToString());
            string query =
                "INSERT INTO [User] (UserID, RoleID, UserName, Email, Password) VALUES (@UserID, @RoleID, @UserName, @Email, @Password)";

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@UserID", newUserId);
                command.Parameters.AddWithValue("@RoleID", managerRoleId);
                command.Parameters.AddWithValue("@UserName", username);
                command.Parameters.AddWithValue("@Email", email);
                command.Parameters.AddWithValue("@Password", hashedPassword);

                try
                {
                    connection.Open();
                    command.ExecuteNonQuery();
                    Console.WriteLine("User created successfully.");
                }
                catch (Exception ex)
                {
                    Console.WriteLine("An error occurred: " + ex.Message);
                }
            }
        }

        private void btnAddManager_Click(object sender, EventArgs e)
        {
            UserDatabaseManager.SetConnectionString(connectionString);
            string username = txtUsername.Text.Trim();
            string email = txtEmail.Text.Trim();
            string password = txtPassword.Text.Trim();

            if (string.IsNullOrEmpty(username) || string.IsNullOrEmpty(email) || string.IsNullOrEmpty(password))
            {
                MessageBox.Show("Username, Email, and Password cannot be empty.", "Validation Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (!EmailValidator.IsValidEmail(email))
            {
                MessageBox.Show("Email must be valid.", "Validation Error", MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);
                return;
            }

            if (!PasswordValidator.IsPasswordComplex(password))
            {
                MessageBox.Show("Password must be atleast 8 and contain at least 1 uppercase letter, 1 number, and 1 symbol.", "Validation Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (UserDatabaseManager.IsUsernameDuplicate(username))
            {
                MessageBox.Show("Username already exists.", "Duplicate Username",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (UserDatabaseManager.IsEmailDuplicate(email))
            {
                MessageBox.Show("Email already exists.", "Duplicate Email",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            Guid newUserId = Guid.NewGuid();
            Guid managerRoleId = RoleUtility.ToUUID(Role.Manager);

            byte[] hashedPassword = PasswordHasher.HashPassword(password);

            InsertNewUser(newUserId, managerRoleId, username, email, hashedPassword);

            MessageBox.Show("User added successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

            txtUsername.Clear();
            txtEmail.Clear();
            txtPassword.Clear();
        }

        private void AdminExit_Click(object sender, EventArgs e)
        {
            this.Visible = false;
        }

        private void txtEmail_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtUsername_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtPassword_TextChanged(object sender, EventArgs e)
        {

        }

        private void AdminAddAdmin_Load(object sender, EventArgs e)
        {

        }
    }
}
