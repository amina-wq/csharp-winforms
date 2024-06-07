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
    public partial class AdminManageUser : Form
    {
        public readonly Timer panelTimer = new Timer();
        private bool isMouseOverAddUserPanel = false;
        private bool isMouseOverEditUserPanel = false;
        private AdminAddManager adminAddManager;
        private AdminAddChef adminAddChef;
        private AdminAddCustomer adminAddCustomer;
        private AdminEditManager adminEditManager;
        private AdminEditChef adminEditChef;
        private AdminEditCustomer adminEditCustomer;

        public AdminManageUser()
        {

            InitializeComponent();

            adminAddManager = new AdminAddManager();
            adminAddChef = new AdminAddChef();
            adminAddCustomer = new AdminAddCustomer(); 
            adminEditManager = new AdminEditManager();
            adminEditChef = new AdminEditChef();
            adminEditCustomer = new AdminEditCustomer();

            adminAddManager.Dock = DockStyle.Fill;
            adminAddChef.Dock = DockStyle.Fill;
            adminAddCustomer.Dock = DockStyle.Fill;
            adminEditManager.Dock = DockStyle.Fill;
            adminEditChef.Dock = DockStyle.Fill;
            adminEditCustomer.Dock = DockStyle.Fill;

            this.Controls.Add(adminAddManager);
            this.Controls.Add(adminAddChef);
            this.Controls.Add(adminAddCustomer);
            this.Controls.Add(adminEditManager);
            this.Controls.Add(adminEditChef);
            this.Controls.Add(adminEditCustomer);

            adminAddManager.Visible = false;
            adminAddChef.Visible = false;
            adminAddCustomer.Visible = false;
            adminEditManager.Visible = false;
            adminEditChef.Visible = false;
            adminEditCustomer.Visible = false;

            AddUserPanel.Visible = false;
            EditUserPanel.Visible = false;

            MUAddUser.MouseEnter += MUAddUser_MouseEnter;
            MUAddUser.MouseLeave += MUAddUser_MouseLeave;

            AddUserPanel.MouseEnter += AddUserPanel_MouseEnter;
            AddUserPanel.MouseLeave += AddUserPanel_MouseLeave;
            AddUserPanel.Leave += AddUserPanel_Leave;

            MUAddManager.MouseEnter += MUAddManager_MouseEnter;
            MUAddManager.MouseLeave += MUAddManager_MouseLeave;

            MUAddChef.MouseEnter += MUAddChef_MouseEnter;
            MUAddChef.MouseLeave += MUAddChef_MouseLeave;

            MUAddCustomer.MouseEnter += MUAddCustomer_MouseEnter;
            MUAddCustomer.MouseLeave += MUAddCustomer_MouseLeave;

            MUEditUser.MouseEnter += MUEditUser_MouseEnter;
            MUEditUser.MouseLeave += MUEditUser_MouseLeave;

            AddUserPanel.MouseEnter += EditUserPanel_MouseEnter;
            AddUserPanel.MouseLeave += EditUserPanel_MouseLeave;
            AddUserPanel.Leave += EditUserPanel_Leave;

            MUEditManager.MouseEnter += MUEditManager_MouseEnter;
            MUEditManager.MouseLeave += MUEditManager_MouseLeave;

            MUEditChef.MouseEnter += MUEditChef_MouseEnter;
            MUEditChef.MouseLeave += MUEditChef_MouseLeave;

            MUEditCustomer.MouseEnter += MUEditCustomer_MouseEnter;
            MUEditCustomer.MouseLeave += MUEditCustomer_MouseLeave;

            AUPanelTimer.Interval = 400;
            AUPanelTimer.Tick += AUPanelTimer_Tick;

            EUPanelTimer.Interval = 400;
            EUPanelTimer.Tick += EUPanelTimer_Tick;


        }

        private void AdminManageUser_Load(object sender, EventArgs e)
        {

        }
        private void AUShowControl(UserControl control)
        {
            if (adminAddManager.Visible)
            {
                adminAddManager.Visible = false;
            }
            else if (adminAddChef.Visible)
            {
                adminAddChef.Visible = false;
            }
            else if (adminAddCustomer.Visible)
            {
                adminAddCustomer.Visible = false;
            }

            control.Visible = true;

        }

        private void AUPanelTimer_Tick(object sender, EventArgs e)
        {
            if (!isMouseOverAddUserPanel)
            {
                AddUserPanel.Visible = false;
            }
            AUPanelTimer.Stop();
        }

        private void AddUserPanel_MouseEnter(object sender, EventArgs eventArgs)
        {
            isMouseOverAddUserPanel = true;
            AUPanelTimer.Stop();
        }

        private void AddUserPanel_MouseLeave(object sender, EventArgs eventArgs)
        {
            isMouseOverAddUserPanel = false;
            AUPanelTimer.Start();
        }
        private void AddUserPanel_Leave(object sender, EventArgs eventArgs)
        {
            isMouseOverAddUserPanel = false;
            AUPanelTimer.Stop();
        }

        private void AddUserPanel_Paint(object sender, PaintEventArgs e)
        {
            if (isMouseOverAddUserPanel == true)
            {
                AddUserPanel.Height = 200;
                isMouseOverAddUserPanel = false;
            }
        }

        private void MUAddUser_MouseEnter(object sender, EventArgs e)
        {
            AddUserPanel.Visible = true;
            isMouseOverAddUserPanel = true;
            AUPanelTimer.Stop();
            EditUserPanel.Visible = false;
        }
        private void MUAddUser_MouseLeave(object sender, EventArgs e)
        {
            isMouseOverAddUserPanel = false;
            AUPanelTimer.Start();
        }
        private void MUAddUser_Click(object sender, EventArgs e)
        {

        }

        private void MUAddManager_MouseEnter(object sender, EventArgs e)
        {
            isMouseOverAddUserPanel = true;
            AUPanelTimer.Stop();
        }
        
        private void MUAddManager_MouseLeave(object sender, EventArgs e)
        {
            isMouseOverAddUserPanel = false;
            AUPanelTimer.Stop();
        }

        private void MUAddManager_Click(object sender, EventArgs e)
        {
            adminAddManager.BringToFront();      
            AUShowControl(adminAddManager);
        }

        private void MUAddChef_MouseEnter(object sender, EventArgs e)
        {
            isMouseOverAddUserPanel = true;
            AUPanelTimer.Stop();
        }
        private void MUAddChef_MouseLeave(object sender, EventArgs e)
        {
            isMouseOverAddUserPanel = true;
            AUPanelTimer.Stop();
        }

        private void MUAddChef_Click(object sender, EventArgs e)
        {
            adminAddChef.BringToFront();
            AUShowControl(adminAddChef);
        }
        private void MUAddCustomer_MouseEnter(object sender, EventArgs e)
        {
            isMouseOverAddUserPanel = true;
            AUPanelTimer.Stop();
        }
        private void MUAddCustomer_MouseLeave(object sender, EventArgs e)
        {
            isMouseOverAddUserPanel = true;
            AUPanelTimer.Stop();
        }

        private void MUAddCustomer_Click(object sender, EventArgs e)
        {
            adminAddCustomer.BringToFront();
            AUShowControl(adminAddCustomer);
        }

        

        private void EUShowControl(UserControl control)
        {
            EditUserPanel.Visible = false;

            if (adminEditManager.Visible)
            {
                adminEditManager.Visible = false;
            }
            else if (adminEditChef.Visible)
            {
                adminEditChef.Visible = false;
            }
            else if (adminEditCustomer.Visible)
            {
                adminEditCustomer.Visible = false;
            }

            control.Visible = true;
        }

        
        private void EUPanelTimer_Tick(object sender, EventArgs e)
        {
            if (!isMouseOverEditUserPanel)
            {
                EditUserPanel.Visible = false;
            }
            EUPanelTimer.Stop();
        }

        private void EditUserPanel_MouseEnter(object sender, EventArgs eventArgs)
        {
            isMouseOverEditUserPanel = true;
            EUPanelTimer.Stop();
        }

        private void EditUserPanel_MouseLeave(object sender, EventArgs eventArgs)
        {
            isMouseOverEditUserPanel = false;
            EUPanelTimer.Start();
        }
        private void EditUserPanel_Leave(object sender, EventArgs eventArgs)
        {
            isMouseOverEditUserPanel = false;
            EUPanelTimer.Start();
        }

        private void EditUserPanel_Paint(object sender, PaintEventArgs e)
        {

            if (isMouseOverEditUserPanel == true)
            {
                EditUserPanel.Height = 200;
                isMouseOverEditUserPanel = false;
            }
        }

        private void MUEditUser_MouseEnter(object sender, EventArgs e)
        {
            EditUserPanel.Visible = true;
            isMouseOverEditUserPanel = true;
            EUPanelTimer.Stop();
            AddUserPanel.Visible = false;
        }
        private void MUEditUser_MouseLeave(object sender, EventArgs e)
        {
            isMouseOverEditUserPanel = false;
            EUPanelTimer.Start();
        }

        private void MUEditUser_Click(object sender, EventArgs e)
        {

        }

        private void MUEditManager_MouseEnter(object sender, EventArgs e)
        {
            isMouseOverEditUserPanel = true;
            EUPanelTimer.Stop();
        }

        private void MUEditManager_MouseLeave(object sender, EventArgs e)
        {
            isMouseOverEditUserPanel = false;
            EUPanelTimer.Start();
        }

        private void MUEditManager_Click(object sender, EventArgs e)
        {
            adminEditManager.BringToFront();      
            EUShowControl(adminEditManager);
        }

        private void MUEditChef_MouseEnter(object sender, EventArgs e)
        {
            isMouseOverEditUserPanel = true;
            EUPanelTimer.Stop();
        }
        private void MUEditChef_MouseLeave(object sender, EventArgs e)
        {
            isMouseOverEditUserPanel = true;
            EUPanelTimer.Start();
        }

        private void MUEditChef_Click(object sender, EventArgs e)
        {
            adminEditChef.BringToFront();
            EUShowControl(adminEditChef);
        }
        private void MUEditCustomer_MouseEnter(object sender, EventArgs e)
        {
            isMouseOverEditUserPanel = true;
            EUPanelTimer.Stop();
        }
        private void MUEditCustomer_MouseLeave(object sender, EventArgs e)
        {
            isMouseOverEditUserPanel = true;
            EUPanelTimer.Start();
        }

        private void MUEditCustomer_Click(object sender, EventArgs e)
        {
            adminEditCustomer.BringToFront();
            EUShowControl(adminEditCustomer);
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

    }

}
