using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace IOOP_assignment.Forms
{
    public partial class ChefDashboard : Form
    {
        public ChefDashboard()
        {
            InitializeComponent();
        }

        private void ChefDashboard_Load(object sender, EventArgs e)
        {

        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            MessageBox.Show("You have been logged out.");
            this.Close();
        }

        private void btnViewOrders_Click(object sender, EventArgs e)
        {
            ViewOrdersForm viewOrdersForm = new ViewOrdersForm();
            viewOrdersForm.Show();
            MessageBox.Show("Choose a table to view more details.");
        }

        private void btnProfile_Click(object sender, EventArgs e)
        {
            
        }

        private void btnManageInventory_Click(object sender, EventArgs e)
        {
            ManageInventoryForm manageInventoryForm = new ManageInventoryForm();
            manageInventoryForm.Show();
        }

        private void lbl1_Click(object sender, EventArgs e)
        {

        }
    }
}
