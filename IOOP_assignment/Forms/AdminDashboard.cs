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
    public partial class AdminDashboard : Form
    {
        public AdminDashboard()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void AdminDashboardLogOut_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void ManageUserOpen_Click(object sender, EventArgs e)
        {
            this.Hide();
            AdminManageUser mu = new AdminManageUser();
            mu.Show();
        }

        private void ManageAccountOpen_Click(object sender, EventArgs e)
        {
            this.Hide(); 
            AdminManageAccount ma = new AdminManageAccount();
            ma.Show();
        }

        private void SalesReportOpen_Click(object sender, EventArgs e)
        {
            this.Hide();
            AdminSalesReport sr = new AdminSalesReport();
            sr.Show();
        }

        private void FeedbackOpen_Click(object sender, EventArgs e)
        {
            this.Hide();
            AdminFeedback fb = new AdminFeedback();
            fb.Show();
        }
    }
}

