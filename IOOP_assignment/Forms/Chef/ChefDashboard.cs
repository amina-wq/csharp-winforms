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
    public partial class ChefDashboard : BorderlessForm
    {
        private static ChefDashboard instance;

        public static ChefDashboard Instance
        {
            get
            {
                if (instance == null || instance.IsDisposed)
                {
                    instance = new ChefDashboard();
                }
                return instance;
            }
        }

        public ChefDashboard()
        {
            InitializeComponent();
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

        private void btnManageInventory_Click(object sender, EventArgs e)
        {
            ManageInventoryForm manageInventoryForm = new ManageInventoryForm();
            manageInventoryForm.Show();
        }

    }
}
