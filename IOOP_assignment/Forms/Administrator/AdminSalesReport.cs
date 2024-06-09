using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace IOOP_assignment.Forms
{
    public partial class AdminSalesReport : BorderlessForm
    {
        private string connectionString =
            ConfigurationManager.ConnectionStrings["ioop"].ToString();
        public AdminSalesReport()
        {
            InitializeComponent();
            PopulateSortCriteria();       

            txtSearch.Text = "Search...";
            txtSearch.ForeColor = SystemColors.GrayText;

            txtSearch.GotFocus += txtSearch_GotFocus;
            txtSearch.LostFocus += txtSearch_LostFocus;

            LoadAllOrders();       
        }

        private bool isInitialized = false;     

        private void LoadAllOrders()
        {
            try
            {
                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    conn.Open();

                    string query = @"
                SELECT 
                    [Order].OrderID, 
                    [Order].OrderDateTime,
                    SUM(MenuItem.Price) AS TotalAmount
                FROM 
                    [Order]
                INNER JOIN 
                    OrderItem ON [Order].OrderID = OrderItem.OrderID
                INNER JOIN 
                    MenuItem ON OrderItem.ItemID = MenuItem.ItemID
                GROUP BY 
                    [Order].OrderID, [Order].OrderDateTime
                ORDER BY 
                    [Order].OrderDateTime DESC";

                    SqlCommand cmd = new SqlCommand(query, conn);
                    SqlDataAdapter da = new SqlDataAdapter(cmd);
                    DataTable dt = new DataTable();
                    da.Fill(dt);

                    dataGridViewSales.DataSource = null;

                    dataGridViewSales.DataSource = dt;

                    if (!isInitialized)
                    {
                        listBoxOrders.Items.Clear();
                    }

                    foreach (DataRow row in dt.Rows)
                    {
                        string orderInfo = $"{row["OrderID"]} - {Convert.ToDateTime(row["OrderDateTime"]):yyyy-MM-dd HH:mm:ss} - Total: {Convert.ToDecimal(row["TotalAmount"]):C}";

                        if (!listBoxOrders.Items.Contains(orderInfo))
                        {
                            listBoxOrders.Items.Add(orderInfo);
                        }
                    }

                    isInitialized = true;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred: " + ex.Message);
            }
        }

        private void UpdateTotalAmount(DataTable dt)
        {
            decimal totalAmount = dt.AsEnumerable().Sum(row => row.Field<decimal>("TotalAmount"));
            lblTotalAmount.Text = $"Total Amount: {totalAmount:C}";
        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            string searchQuery = txtSearch.Text;
            if (!string.IsNullOrWhiteSpace(searchQuery))
            {
                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    conn.Open();

                    string query = @"
                SELECT 
                    [Order].OrderID, 
                    [Order].OrderDateTime,
                    SUM(MenuItem.Price) AS TotalAmount
                FROM 
                    [Order]
                INNER JOIN 
                    OrderItem ON [Order].OrderID = OrderItem.OrderID
                INNER JOIN 
                    MenuItem ON OrderItem.ItemID = MenuItem.ItemID
                WHERE 
                    [Order].OrderID LIKE @search 
                GROUP BY 
                    [Order].OrderID, [Order].OrderDateTime
                ORDER BY 
                    [Order].OrderDateTime";

                    SqlCommand cmd = new SqlCommand(query, conn);
                    cmd.Parameters.AddWithValue("@search", "%" + searchQuery + "%");

                    SqlDataAdapter da = new SqlDataAdapter(cmd);
                    DataTable dt = new DataTable();
                    da.Fill(dt);
                    UpdateTotalAmount(dt);

                    if (!listBoxOrders.Focused)
                    {
                        listBoxOrders.Items.Clear();
                    }

                    foreach (DataRow row in dt.Rows)
                    {
                        string orderInfo = $"{row["OrderID"]} - {Convert.ToDateTime(row["OrderDateTime"]):yyyy-MM-dd HH:mm:ss} - Total: {Convert.ToDecimal(row["TotalAmount"]):C}";

                        listBoxOrders.Items.Add(orderInfo);
                    }
                }
            }
            else
            {
                LoadAllOrders();
            }
        }

        private void listBoxOrders_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listBoxOrders.SelectedItem != null)
            {
                string selectedItem = listBoxOrders.SelectedItem.ToString();

                string[] parts = selectedItem.Split(new string[] { " - " }, StringSplitOptions.None);

                if (parts.Length >= 1)
                {
                    string selectedOrderId = parts[0];     

                    if (Guid.TryParse(selectedOrderId, out Guid orderId))
                    {
                        using (SqlConnection conn = new SqlConnection(connectionString))
                        {
                            conn.Open();

                            string query = @"
                            SELECT 
                                [Order].OrderID, 
                                [Order].OrderDateTime,
                                MenuItem.ItemName, 
                                MenuItem.Price,
                                (MenuItem.Price) AS TotalAmount
                            FROM 
                                [Order]
                            INNER JOIN 
                                OrderItem ON [Order].OrderID = OrderItem.OrderID
                            INNER JOIN 
                                MenuItem ON OrderItem.ItemID = MenuItem.ItemID
                            WHERE 
                                [Order].OrderID = @orderId";

                            SqlCommand cmd = new SqlCommand(query, conn);
                            cmd.Parameters.AddWithValue("@orderId", orderId);

                            SqlDataAdapter da = new SqlDataAdapter(cmd);
                            DataTable dt = new DataTable();
                            da.Fill(dt);

                            dataGridViewSales.DataSource = dt;
                            UpdateTotalAmount(dt);
                        }
                    }
                    else
                    {
                        MessageBox.Show("Invalid order ID format.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else
                {
                    MessageBox.Show("Invalid selected item format.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void txtSearch_GotFocus(object sender, EventArgs e)
        {
            if (txtSearch.Text == "Search...")
            {
                txtSearch.Text = "";
                txtSearch.ForeColor = SystemColors.WindowText;
            }
        }

        private void txtSearch_LostFocus(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtSearch.Text))
            {
                txtSearch.Text = "Search...";
                txtSearch.ForeColor = SystemColors.GrayText;
            }
        }

        private bool ascendingOrder = true;

        private void btnSort_Click(object sender, EventArgs e)
        {
            if (listBoxSort.SelectedItem != null)
            {
                string selectedCriteria = listBoxSort.SelectedItem.ToString();
                string sortBy = selectedCriteria == "Order Date & Time" ? "OrderDateTime" : "TotalAmount";

                ascendingOrder = !ascendingOrder;

                SortOrders(sortBy, ascendingOrder);
            }
            else
            {
                MessageBox.Show("Please select a sort criteria.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void SortOrders(string sortBy, bool ascending)
        {
            DataTable dt = (DataTable)dataGridViewSales.DataSource;        

            if (dt != null)
            {
                string sortOrder = ascending ? "ASC" : "DESC";    
                dt.DefaultView.Sort = sortBy + " " + sortOrder;       

                dataGridViewSales.DataSource = dt;        
                UpdateTotalAmount(dt);
            }
        }

        private void ChooseSort()
        {
            if (listBoxSort.SelectedItem != null)
            {
                string selectedCriteria = listBoxSort.SelectedItem.ToString();
                string sortBy = selectedCriteria == "Order Date & Time" ? "OrderDateTime" : "TotalAmount";
                SortOrders(sortBy, ascendingOrder);     
            }
            else
            {
                MessageBox.Show("Please select a sort criteria.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void listBoxSort_SelectedIndexChanged(object sender, EventArgs e)
        {
            ChooseSort();
        }
        private void PopulateSortCriteria()
        {
            listBoxSort.Items.Add("Order Date & Time");
            listBoxSort.Items.Add("Total Amount");
        }

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
            this.Hide();
            LoginForm li = new LoginForm();
            li.Show();
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

    }
}
