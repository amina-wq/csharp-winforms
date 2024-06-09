using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Diagnostics.Eventing.Reader;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using IOOP_assignment.Core;
using IOOP_assignment.Forms.AdminAddUser;
using IOOP_assignment.Forms.AdminEditUser;
using IOOP_assignment.Models;

namespace IOOP_assignment.Forms
{
    public partial class AdminManageAccount : BorderlessForm
    {
        private AdminAddAdmin adminAddAdmin;
        private AdminEditAdmin adminEditAdmin;
        private string connectionString = ConfigurationManager.ConnectionStrings["ioop"].ToString();

        public AdminManageAccount()
        {
            InitializeComponent();
            UserDatabaseManager.SetConnectionString(connectionString);

            adminAddAdmin = new AdminAddAdmin();
            adminEditAdmin = new AdminEditAdmin();

            adminAddAdmin.Dock = DockStyle.Fill;
            adminEditAdmin.Dock = DockStyle.Fill;

            this.Controls.Add(adminAddAdmin);
            this.Controls.Add(adminEditAdmin);

            adminAddAdmin.Visible = false;
            adminEditAdmin.Visible = false;
        }

        private void MAShowControl(UserControl control)
        {
            if (adminAddAdmin.Visible)
            {
                adminAddAdmin.Visible = false;
            }
            else if (adminAddAdmin.Visible)
            {
                adminAddAdmin.Visible = false;
            }

            control.Visible = true;

        }

        private void MAAddUser_Click(object sender, EventArgs e)
        {
            if (UserDatabaseManager.IsAdminDuplicate())
            {
                MessageBox.Show("Two user already exist. Cannot add another user.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            else
            {
                adminAddAdmin.BringToFront();
                MAShowControl(adminAddAdmin);
            }
        }

        private void MAEditUser_Click(object sender, EventArgs e)
        {
            adminEditAdmin.BringToFront();
            MAShowControl(adminEditAdmin);
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
