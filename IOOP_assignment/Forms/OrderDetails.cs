using IOOP_assignment.Models;
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
    public partial class OrderDetails : Form
    {
        private DropdownAnimator _dropdownAnimator;
        private string connectionString = "Data Source=localhost;Initial Catalog=ioop;Integrated Security=True;";
        private int rowToShow;

        public OrderDetails(int rowToShow)
        {
            InitializeComponent();
            this.rowToShow = rowToShow;
            _dropdownAnimator = new DropdownAnimator(DropdownPanel, 300, 10);
        }

        public void SetTableNumber(string tableNumber)
        {
            lblTableNum.Text = "TABLE " + tableNumber;
        }
        bool _DropDown = true;
        public static bool IsHidden { get; private set; }

        private void OrderDetails_Load(object sender, EventArgs e)
        {
            LoadData();
        }
        private void LoadData()
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                string query = "SELECT [FoodOrder], [OrderDateTime], [OrderStatus], [OrderID] FROM [ioop].[dbo].[Order]";
                SqlDataAdapter adapter = new SqlDataAdapter(query, connection);
                DataTable table = new DataTable();
                adapter.Fill(table);
                dataGridView.DataSource = table;

                if (rowToShow >= 0 && rowToShow < table.Rows.Count)
                {
                    DataRow row = table.Rows[rowToShow];
                    DataTable filteredTable = table.Clone();
                    filteredTable.ImportRow(row);
                    dataGridView.DataSource = filteredTable;
                }
                else
                {
                    MessageBox.Show("Invalid row number.");
                }
            }
        }

        private void DropDown_Click(object sender, EventArgs e)
        {
            _dropdownAnimator.Toggle();
        }

        private void timer1_Tick_1(object sender, EventArgs e)
        {
            
        }

        private void btnDashboard_Click(object sender, EventArgs e)
        {
            ChefDashboard chefDashboard = new ChefDashboard();
            chefDashboard.Show();
            this.Close();
        }

        private void btnViewOrder_Click(object sender, EventArgs e)
        {
            ViewOrdersForm viewOrdersForm = new ViewOrdersForm();
            viewOrdersForm.Show();
            this.Close();
        }

        private void btnInventory_Click(object sender, EventArgs e)
        {
            ManageInventoryForm manageInventoryForm = new ManageInventoryForm();
            manageInventoryForm.Show();
            this.Close();
        }

        private void btnProfile_Click(object sender, EventArgs e)
        {
           
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            ViewOrdersForm viewOrdersForm = new ViewOrdersForm();
            viewOrdersForm.Show();
            this.Close();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnComplete_Click(object sender, EventArgs e)
        {
            if (dataGridView.SelectedRows.Count > 0)
            {
                int rowIndex = dataGridView.SelectedRows[0].Index;
                UpdateOrderStatus(rowIndex, "Completed");
            }
            else
            {
                MessageBox.Show("Please select a row in the DataGridView.");
            }
        }

        private void btnReceiveOrder_Click(object sender, EventArgs e)
        {
            if (dataGridView.SelectedRows.Count > 0)
            {
                int rowIndex = dataGridView.SelectedRows[0].Index;
                UpdateOrderStatus(rowIndex, "In Progress");
            }
            else
            {
                MessageBox.Show("Please select a row in the DataGridView.");
            }
        }
        private void UpdateOrderStatus(int rowIndex, string newStatus)
        {
            dataGridView.Rows[rowIndex].Cells["OrderStatus"].Value = newStatus;

            Guid orderId = (Guid)dataGridView.Rows[rowIndex].Cells["OrderID"].Value;
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                string query = "UPDATE [ioop].[dbo].[Order] SET [OrderStatus] = @Status WHERE [OrderID] = @OrderID";
                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@Status", newStatus);
                command.Parameters.AddWithValue("@OrderID", orderId);
                command.ExecuteNonQuery();
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            if (dataGridView.SelectedRows.Count > 0)
            {
                int rowIndex = dataGridView.SelectedRows[0].Index;
                UpdateOrderStatus(rowIndex, "Pending");
            }
            else
            {
                MessageBox.Show("Please select a row in the DataGridView.");
            }
        }
    }
}
