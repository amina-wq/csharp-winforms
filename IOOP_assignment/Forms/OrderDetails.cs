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
        private Manage_Order_Status _manageOrderStatus;
        private OrderLoader _orderLoader;
        private int rowToShow;

        public OrderDetails(int rowToShow)
        {
            InitializeComponent();
            this.rowToShow = rowToShow;
            _dropdownAnimator = new DropdownAnimator(DropdownPanel, 300, 10);
            _manageOrderStatus = new Manage_Order_Status(new SQLConnect());
            _orderLoader = new OrderLoader(new SQLConnect());
        }

        public void SetTableNumber(string tableNumber)
        {
            lblTableNum.Text = "TABLE " + tableNumber;
        }
        private void OrderDetails_Load(object sender, EventArgs e)
        {
            LoadData();
        }
        private void LoadData()
        {
            DataTable table = _orderLoader.GetOrders();
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

        private void DropDown_Click(object sender, EventArgs e)
        {
            _dropdownAnimator.Toggle();
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

        private void btnBack_Click(object sender, EventArgs e)
        {
            ViewOrdersForm viewOrdersForm = new ViewOrdersForm();
            viewOrdersForm.Show();
            this.Close();
        }

        private void btnComplete_Click(object sender, EventArgs e)
        {
            UpdateOrderStatus("Completed");
        }

        private void btnReceiveOrder_Click(object sender, EventArgs e)
        {
            UpdateOrderStatus("In Progress");
        }
        private void UpdateOrderStatus(string newStatus)
        {
            if (dataGridView.SelectedRows.Count > 0)
            {
                int rowIndex = dataGridView.SelectedRows[0].Index;
                Guid orderId = (Guid)dataGridView.Rows[rowIndex].Cells["OrderID"].Value;
                _manageOrderStatus.UpdateOrderStatus(orderId, newStatus);
                dataGridView.Rows[rowIndex].Cells["OrderStatus"].Value = newStatus;
            }
            else
            {
                MessageBox.Show("Please select a row in the table.");
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            UpdateOrderStatus("Pending");
        }
    }
}
