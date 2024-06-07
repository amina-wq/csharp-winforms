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

namespace IOOP_assignment.Forms
{
    public partial class AdminAddManager : UserControl
    {
        private string connectionString;
        private SqlConnection c = new SqlConnection(
                "Data Source=LAPTOP-GHUMDV20;Initial Catalog=ioop;Integrated Security=True;TrustServerCertificate=True");

        public AdminAddManager()
        {
            InitializeComponent();
            connectionString =
                ("Data Source=LAPTOP-GHUMDV20;Initial Catalog=ioop;Integrated Security=True;TrustServerCertificate=True");
        }

        private void InsertNewUser(Guid newUserId, Guid managerRoleId, string username, string email,
            byte[] hashedPassword)
        {
            string connectionString =
                ("Data Source=LAPTOP-GHUMDV20;Initial Catalog=ioop;Integrated Security=True;TrustServerCertificate=True");
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
                    // Handle the error appropriately
                }
            }
        }

        private void btnAddManager_Click(object sender, EventArgs e)
        {
            UserDatabaseManager.SetConnectionString(connectionString);
            // Get the username, email, and password from TextBox controls
            string username = txtUsername.Text.Trim();
            string email = txtEmail.Text.Trim();
            string password = txtPassword.Text.Trim();

            // Validate input
            if (string.IsNullOrEmpty(username) || string.IsNullOrEmpty(email) || string.IsNullOrEmpty(password))
            {
                MessageBox.Show("Username, Email, and Password cannot be empty.", "Validation Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Validate email format
            if (!EmailValidator.IsValidEmail(email))
            {
                MessageBox.Show("Email must be valid.", "Validation Error", MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);
                return;
            }

            // Validate password complexity
            if (!PasswordValidator.IsPasswordComplex(password))
            {
                MessageBox.Show("Password must be atleast 8 and contain at least 1 uppercase letter, 1 number, and 1 symbol.", "Validation Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Check for duplicate username
            if (UserDatabaseManager.IsUsernameDuplicate(username))
            {
                MessageBox.Show("Username already exists.", "Duplicate Username",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Check for duplicate email
            if (UserDatabaseManager.IsEmailDuplicate(email))
            {
                MessageBox.Show("Email already exists.", "Duplicate Email",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            UserIdGenerator generator = new UserIdGenerator(connectionString);
            Guid newUserId = generator.GenerateNewUserId();

            // Hardcode the manager role ID 
            Guid managerRoleId = new Guid("10000000-0000-1000-0000-000000000001");

            // Hash the password
            byte[] hashedPassword = PasswordHasher.HashPassword(password);

            // Insert the new user into the database
            InsertNewUser(newUserId, managerRoleId, username, email, hashedPassword);

            MessageBox.Show("User added successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

            // Clear textboxes after input
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

        private void AdminAddManager_Load(object sender, EventArgs e)
        {

        }
    }
}