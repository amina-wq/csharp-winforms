using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace IOOP_assignment.Forms
{
    public partial class AdminFeedback : Form
    {
        private string connectionString =
            "Data Source=LAPTOP-GHUMDV20;Initial Catalog=ioop;Integrated Security=True;TrustServerCertificate=True";
        public AdminFeedback()
        {
            InitializeComponent();
            LoadCustomers();
        }
        public class ListItem
        {
            public string DisplayText { get; set; }
            public string Value { get; set; }

            public ListItem(string displayText, string value)
            {
                DisplayText = displayText;
                Value = value;
            }

            public override string ToString()
            {
                return DisplayText;
            }
        }

        private void LoadCustomers()
        {
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                string query = @"SELECT [User].UserName, [User].Email 
                         FROM [User] 
                         INNER JOIN Role ON [User].RoleID = Role.RoleID 
                         WHERE Role.RoleName = 'Customer'";
                SqlCommand cmd = new SqlCommand(query, conn);
                conn.Open();
                SqlDataReader reader = cmd.ExecuteReader();
                listBoxSearch.Items.Clear();
                while (reader.Read())
                {
                    // Display UserName and Email only in the ListBox
                    string displayText = $"{reader["UserName"]} - {reader["Email"]}";
                    listBoxSearch.Items.Add(displayText);
                }
            }
        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            string searchQuery = txtSearch.Text;
            if (!string.IsNullOrWhiteSpace(searchQuery))
            {
                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    string query = @"SELECT [User].UserName, [User].Email 
                             FROM [User] 
                             INNER JOIN Role ON [User].RoleID = Role.RoleID 
                             WHERE ([User].UserName LIKE @search OR [User].Email LIKE @search) 
                             AND Role.RoleName = 'Customer'";
                    SqlCommand cmd = new SqlCommand(query, conn);
                    cmd.Parameters.AddWithValue("@search", "%" + searchQuery + "%");
                    conn.Open();
                    SqlDataReader reader = cmd.ExecuteReader();
                    listBoxSearch.Items.Clear();
                    while (reader.Read())
                    {
                        // Display UserName and Email only in the ListBox
                        string displayText = $"{reader["UserName"]} - {reader["Email"]}";
                        listBoxSearch.Items.Add(displayText);
                    }
                }
            }
            else
            {
                listBoxSearch.Items.Clear();
            }
        }


        private void listBoxSearch_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listBoxSearch.SelectedItem != null)
            {
                string selectedUsername = listBoxSearch.SelectedItem.ToString().Split('-')[0].Trim();

                // Using block ensures proper disposal of resources, including the connection
                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    conn.Open();

                    // Construct the SQL query to retrieve feedback data for the selected username
                    string query = @"
                SELECT 
                    [User].UserName AS UserName, 
                    [User].Email AS Email,
                    Feedback.FeedbackDateTime AS FeedbackDateTime, 
                    Feedback.FeedbackMessage AS FeedbackMessage
                FROM 
                    [Feedback] 
                INNER JOIN [User] ON Feedback.CustomerID = [User].UserID 
                WHERE 
                    [User].UserName = @username";

                    SqlCommand cmd = new SqlCommand(query, conn);
                    cmd.Parameters.AddWithValue("@username", selectedUsername);

                    // Create a DataTable to hold the retrieved feedback data
                    DataTable dt = new DataTable();

                    // Use a SqlDataAdapter to fill the DataTable with data from the query result
                    SqlDataAdapter da = new SqlDataAdapter(cmd);
                    da.Fill(dt);

                    // Bind the DataTable to the DataGridView to display the feedback data
                    dataGridViewFeedback.DataSource = dt;
                } 
            }
        }


        // Drop Down
        bool _adminDropDown = false;

        private void AdmimDropDown_Click(object sender, EventArgs e)
        {
            dropdownTimer.Start();
        }

        private void AdminExit_Click(object sender, EventArgs e)
        {

            AdminDashboard ad = new AdminDashboard();
            this.Close();
            ad.Visible = true;
        }

        private void dropdownTimer_Tick(object sender, EventArgs e)
        {
            if (_adminDropDown == true)
            {
                MenuPanel.Height -= 10;
                if (MenuPanel.Height > 10) return;
                dropdownTimer.Stop();
                _adminDropDown = false;
            }
            else
            {
                {
                    MenuPanel.Height += 10;
                    if (MenuPanel.Height < 820) return;
                    dropdownTimer.Stop();
                    _adminDropDown = true;
                }
            }
        }

        private void AdminLogOut_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnAdminDashboard_Click(object sender, EventArgs e)
        {
            AdminDashboard ad = new AdminDashboard();
            this.Close();
            ad.Visible = true;
        }

        private void btnManageUser_Click(object sender, EventArgs e)
        {
            AdminManageUser mu = new AdminManageUser();
            this.Close();
            mu.Show();
        }

        private void btnManageAccount_Click(object sender, EventArgs e)
        {
            AdminManageAccount ma = new AdminManageAccount();
            this.Close();
            ma.Show();
        }

        private void btnSalesReport_Click(object sender, EventArgs e)
        {
            AdminSalesReport sr = new AdminSalesReport();
            this.Close();
            sr.Show();
        }

        private void btnFeedback_Click(object sender, EventArgs e)
        {
            AdminFeedback fb = new AdminFeedback();
            this.Close();
            fb.Show();
        }

        private void AdminFeedback_Load(object sender, EventArgs e)
        {

        }

        private void dataGridViewFeedback_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}