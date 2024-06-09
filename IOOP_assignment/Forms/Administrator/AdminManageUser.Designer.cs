using System.Windows.Forms;

namespace IOOP_assignment.Forms
{
    partial class AdminManageUser
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AdminManageUser));
            this.label1 = new System.Windows.Forms.Label();
            this.MUAddUser = new System.Windows.Forms.Button();
            this.AddUserPanel = new System.Windows.Forms.Panel();
            this.MUAddManager = new System.Windows.Forms.Button();
            this.MUAddChef = new System.Windows.Forms.Button();
            this.MUAddCustomer = new System.Windows.Forms.Button();
            this.AUPanelTimer = new System.Windows.Forms.Timer(this.components);
            this.AdmimDropDown = new System.Windows.Forms.Button();
            this.MenuPanel = new System.Windows.Forms.Panel();
            this.btnAdminDashboard = new System.Windows.Forms.Button();
            this.AdminLogOut = new System.Windows.Forms.Button();
            this.btnFeedback = new System.Windows.Forms.Button();
            this.btnSalesReport = new System.Windows.Forms.Button();
            this.btnManageUser = new System.Windows.Forms.Button();
            this.btnManageAccount = new System.Windows.Forms.Button();
            this.dropdownTimer = new System.Windows.Forms.Timer(this.components);
            this.AdminExit = new System.Windows.Forms.Button();
            this.MUEditUser = new System.Windows.Forms.Button();
            this.EditUserPanel = new System.Windows.Forms.Panel();
            this.MUEditManager = new System.Windows.Forms.Button();
            this.MUEditChef = new System.Windows.Forms.Button();
            this.MUEditCustomer = new System.Windows.Forms.Button();
            this.EUPanelTimer = new System.Windows.Forms.Timer(this.components);
            this.panel1 = new System.Windows.Forms.Panel();
            this.AddUserPanel.SuspendLayout();
            this.MenuPanel.SuspendLayout();
            this.EditUserPanel.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 26F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label1.Location = new System.Drawing.Point(568, 225);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(318, 52);
            this.label1.TabIndex = 0;
            this.label1.Text = "Manage Users";
            // 
            // MUAddUser
            // 
            this.MUAddUser.BackColor = System.Drawing.Color.Wheat;
            this.MUAddUser.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MUAddUser.ForeColor = System.Drawing.Color.Black;
            this.MUAddUser.Location = new System.Drawing.Point(630, 292);
            this.MUAddUser.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.MUAddUser.Name = "MUAddUser";
            this.MUAddUser.Size = new System.Drawing.Size(227, 75);
            this.MUAddUser.TabIndex = 1;
            this.MUAddUser.Text = "Add User";
            this.MUAddUser.UseVisualStyleBackColor = false;
            this.MUAddUser.Click += new System.EventHandler(this.MUAddUser_Click);
            // 
            // AddUserPanel
            // 
            this.AddUserPanel.BackColor = System.Drawing.Color.Transparent;
            this.AddUserPanel.Controls.Add(this.MUAddManager);
            this.AddUserPanel.Controls.Add(this.MUAddChef);
            this.AddUserPanel.Controls.Add(this.MUAddCustomer);
            this.AddUserPanel.Location = new System.Drawing.Point(861, 283);
            this.AddUserPanel.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.AddUserPanel.Name = "AddUserPanel";
            this.AddUserPanel.Size = new System.Drawing.Size(260, 8);
            this.AddUserPanel.TabIndex = 2;
            this.AddUserPanel.Paint += new System.Windows.Forms.PaintEventHandler(this.AddUserPanel_Paint);
            // 
            // MUAddManager
            // 
            this.MUAddManager.BackColor = System.Drawing.Color.Wheat;
            this.MUAddManager.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MUAddManager.Location = new System.Drawing.Point(12, 9);
            this.MUAddManager.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.MUAddManager.Name = "MUAddManager";
            this.MUAddManager.Size = new System.Drawing.Size(235, 75);
            this.MUAddManager.TabIndex = 4;
            this.MUAddManager.Text = "Add Manager";
            this.MUAddManager.UseVisualStyleBackColor = false;
            this.MUAddManager.Click += new System.EventHandler(this.MUAddManager_Click);
            // 
            // MUAddChef
            // 
            this.MUAddChef.BackColor = System.Drawing.Color.Wheat;
            this.MUAddChef.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MUAddChef.Location = new System.Drawing.Point(12, 82);
            this.MUAddChef.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.MUAddChef.Name = "MUAddChef";
            this.MUAddChef.Size = new System.Drawing.Size(235, 75);
            this.MUAddChef.TabIndex = 3;
            this.MUAddChef.Text = "Add Chef";
            this.MUAddChef.UseVisualStyleBackColor = false;
            this.MUAddChef.Click += new System.EventHandler(this.MUAddChef_Click);
            // 
            // MUAddCustomer
            // 
            this.MUAddCustomer.BackColor = System.Drawing.Color.Wheat;
            this.MUAddCustomer.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MUAddCustomer.Location = new System.Drawing.Point(12, 152);
            this.MUAddCustomer.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.MUAddCustomer.Name = "MUAddCustomer";
            this.MUAddCustomer.Size = new System.Drawing.Size(235, 75);
            this.MUAddCustomer.TabIndex = 2;
            this.MUAddCustomer.Text = "Add Customer";
            this.MUAddCustomer.UseVisualStyleBackColor = false;
            this.MUAddCustomer.Click += new System.EventHandler(this.MUAddCustomer_Click);
            // 
            // AUPanelTimer
            // 
            this.AUPanelTimer.Interval = 2000;
            this.AUPanelTimer.Tick += new System.EventHandler(this.EUPanelTimer_Tick);
            // 
            // AdmimDropDown
            // 
            this.AdmimDropDown.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("AdmimDropDown.BackgroundImage")));
            this.AdmimDropDown.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.AdmimDropDown.Location = new System.Drawing.Point(11, 5);
            this.AdmimDropDown.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.AdmimDropDown.Name = "AdmimDropDown";
            this.AdmimDropDown.Size = new System.Drawing.Size(53, 48);
            this.AdmimDropDown.TabIndex = 3;
            this.AdmimDropDown.UseVisualStyleBackColor = true;
            this.AdmimDropDown.Click += new System.EventHandler(this.AdmimDropDown_Click);
            // 
            // MenuPanel
            // 
            this.MenuPanel.BackColor = System.Drawing.Color.Transparent;
            this.MenuPanel.Controls.Add(this.btnAdminDashboard);
            this.MenuPanel.Controls.Add(this.AdminLogOut);
            this.MenuPanel.Controls.Add(this.btnFeedback);
            this.MenuPanel.Controls.Add(this.btnSalesReport);
            this.MenuPanel.Controls.Add(this.btnManageUser);
            this.MenuPanel.Controls.Add(this.btnManageAccount);
            this.MenuPanel.Location = new System.Drawing.Point(11, 58);
            this.MenuPanel.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.MenuPanel.Name = "MenuPanel";
            this.MenuPanel.Size = new System.Drawing.Size(294, 8);
            this.MenuPanel.TabIndex = 4;
            // 
            // btnAdminDashboard
            // 
            this.btnAdminDashboard.Font = new System.Drawing.Font("Times New Roman", 16F);
            this.btnAdminDashboard.Location = new System.Drawing.Point(19, 450);
            this.btnAdminDashboard.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnAdminDashboard.Name = "btnAdminDashboard";
            this.btnAdminDashboard.Size = new System.Drawing.Size(241, 85);
            this.btnAdminDashboard.TabIndex = 6;
            this.btnAdminDashboard.Text = "Admin Dashboard";
            this.btnAdminDashboard.UseVisualStyleBackColor = true;
            this.btnAdminDashboard.Click += new System.EventHandler(this.btnAdminDashboard_Click);
            // 
            // AdminLogOut
            // 
            this.AdminLogOut.Font = new System.Drawing.Font("Times New Roman", 16F);
            this.AdminLogOut.Location = new System.Drawing.Point(19, 558);
            this.AdminLogOut.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.AdminLogOut.Name = "AdminLogOut";
            this.AdminLogOut.Size = new System.Drawing.Size(241, 85);
            this.AdminLogOut.TabIndex = 5;
            this.AdminLogOut.Text = "Log Out";
            this.AdminLogOut.UseVisualStyleBackColor = true;
            this.AdminLogOut.Click += new System.EventHandler(this.AdminLogOut_Click);
            // 
            // btnFeedback
            // 
            this.btnFeedback.Font = new System.Drawing.Font("Times New Roman", 16F);
            this.btnFeedback.Location = new System.Drawing.Point(19, 222);
            this.btnFeedback.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnFeedback.Name = "btnFeedback";
            this.btnFeedback.Size = new System.Drawing.Size(241, 85);
            this.btnFeedback.TabIndex = 4;
            this.btnFeedback.Text = "Feedback";
            this.btnFeedback.UseVisualStyleBackColor = true;
            this.btnFeedback.Click += new System.EventHandler(this.btnFeedback_Click);
            // 
            // btnSalesReport
            // 
            this.btnSalesReport.Font = new System.Drawing.Font("Times New Roman", 16F);
            this.btnSalesReport.Location = new System.Drawing.Point(19, 336);
            this.btnSalesReport.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnSalesReport.Name = "btnSalesReport";
            this.btnSalesReport.Size = new System.Drawing.Size(241, 85);
            this.btnSalesReport.TabIndex = 3;
            this.btnSalesReport.Text = "Sales Report";
            this.btnSalesReport.UseVisualStyleBackColor = true;
            this.btnSalesReport.Click += new System.EventHandler(this.btnSalesReport_Click);
            // 
            // btnManageUser
            // 
            this.btnManageUser.Font = new System.Drawing.Font("Times New Roman", 16F);
            this.btnManageUser.Location = new System.Drawing.Point(19, 18);
            this.btnManageUser.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnManageUser.Name = "btnManageUser";
            this.btnManageUser.Size = new System.Drawing.Size(241, 85);
            this.btnManageUser.TabIndex = 1;
            this.btnManageUser.Text = "Manage User";
            this.btnManageUser.UseVisualStyleBackColor = true;
            this.btnManageUser.Click += new System.EventHandler(this.btnManageUser_Click);
            // 
            // btnManageAccount
            // 
            this.btnManageAccount.Font = new System.Drawing.Font("Times New Roman", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnManageAccount.Location = new System.Drawing.Point(19, 117);
            this.btnManageAccount.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnManageAccount.Name = "btnManageAccount";
            this.btnManageAccount.Size = new System.Drawing.Size(241, 85);
            this.btnManageAccount.TabIndex = 2;
            this.btnManageAccount.Text = "Manage Account";
            this.btnManageAccount.UseVisualStyleBackColor = true;
            this.btnManageAccount.Click += new System.EventHandler(this.btnManageAccount_Click);
            // 
            // dropdownTimer
            // 
            this.dropdownTimer.Interval = 15;
            this.dropdownTimer.Tick += new System.EventHandler(this.dropdownTimer_Tick);
            // 
            // AdminExit
            // 
            this.AdminExit.BackColor = System.Drawing.Color.Transparent;
            this.AdminExit.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AdminExit.Location = new System.Drawing.Point(1412, 19);
            this.AdminExit.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.AdminExit.Name = "AdminExit";
            this.AdminExit.Size = new System.Drawing.Size(53, 48);
            this.AdminExit.TabIndex = 29;
            this.AdminExit.Text = "X";
            this.AdminExit.UseVisualStyleBackColor = false;
            this.AdminExit.Click += new System.EventHandler(this.AdminExit_Click);
            // 
            // MUEditUser
            // 
            this.MUEditUser.BackColor = System.Drawing.Color.Wheat;
            this.MUEditUser.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MUEditUser.Location = new System.Drawing.Point(630, 382);
            this.MUEditUser.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.MUEditUser.Name = "MUEditUser";
            this.MUEditUser.Size = new System.Drawing.Size(227, 75);
            this.MUEditUser.TabIndex = 30;
            this.MUEditUser.Text = "Edit User";
            this.MUEditUser.UseVisualStyleBackColor = false;
            this.MUEditUser.Click += new System.EventHandler(this.MUEditUser_Click);
            // 
            // EditUserPanel
            // 
            this.EditUserPanel.BackColor = System.Drawing.Color.Transparent;
            this.EditUserPanel.Controls.Add(this.MUEditManager);
            this.EditUserPanel.Controls.Add(this.MUEditChef);
            this.EditUserPanel.Controls.Add(this.MUEditCustomer);
            this.EditUserPanel.Location = new System.Drawing.Point(861, 373);
            this.EditUserPanel.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.EditUserPanel.Name = "EditUserPanel";
            this.EditUserPanel.Size = new System.Drawing.Size(237, 8);
            this.EditUserPanel.TabIndex = 5;
            this.EditUserPanel.Paint += new System.Windows.Forms.PaintEventHandler(this.EditUserPanel_Paint);
            // 
            // MUEditManager
            // 
            this.MUEditManager.BackColor = System.Drawing.Color.Wheat;
            this.MUEditManager.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MUEditManager.Location = new System.Drawing.Point(3, 10);
            this.MUEditManager.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.MUEditManager.Name = "MUEditManager";
            this.MUEditManager.Size = new System.Drawing.Size(235, 75);
            this.MUEditManager.TabIndex = 4;
            this.MUEditManager.Text = "Edit Manager";
            this.MUEditManager.UseVisualStyleBackColor = false;
            this.MUEditManager.Click += new System.EventHandler(this.MUEditManager_Click);
            // 
            // MUEditChef
            // 
            this.MUEditChef.BackColor = System.Drawing.Color.Wheat;
            this.MUEditChef.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MUEditChef.Location = new System.Drawing.Point(3, 81);
            this.MUEditChef.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.MUEditChef.Name = "MUEditChef";
            this.MUEditChef.Size = new System.Drawing.Size(235, 75);
            this.MUEditChef.TabIndex = 3;
            this.MUEditChef.Text = "Edit Chef";
            this.MUEditChef.UseVisualStyleBackColor = false;
            this.MUEditChef.Click += new System.EventHandler(this.MUEditChef_Click);
            // 
            // MUEditCustomer
            // 
            this.MUEditCustomer.BackColor = System.Drawing.Color.Wheat;
            this.MUEditCustomer.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MUEditCustomer.Location = new System.Drawing.Point(3, 150);
            this.MUEditCustomer.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.MUEditCustomer.Name = "MUEditCustomer";
            this.MUEditCustomer.Size = new System.Drawing.Size(235, 75);
            this.MUEditCustomer.TabIndex = 2;
            this.MUEditCustomer.Text = "Edit Customer";
            this.MUEditCustomer.UseVisualStyleBackColor = false;
            this.MUEditCustomer.Click += new System.EventHandler(this.MUEditCustomer_Click);
            // 
            // EUPanelTimer
            // 
            this.EUPanelTimer.Interval = 2000;
            this.EUPanelTimer.Tick += new System.EventHandler(this.EUPanelTimer_Tick);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.panel1.Controls.Add(this.AdminExit);
            this.panel1.Location = new System.Drawing.Point(-9, -10);
            this.panel1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1489, 67);
            this.panel1.TabIndex = 31;
            // 
            // AdminManageUser
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1467, 720);
            this.Controls.Add(this.EditUserPanel);
            this.Controls.Add(this.MUEditUser);
            this.Controls.Add(this.MenuPanel);
            this.Controls.Add(this.AdmimDropDown);
            this.Controls.Add(this.AddUserPanel);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.MUAddUser);
            this.Controls.Add(this.panel1);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "AdminManageUser";
            this.Text = "AdminManageUser";
            this.Load += new System.EventHandler(this.AdminManageUser_Load);
            this.AddUserPanel.ResumeLayout(false);
            this.MenuPanel.ResumeLayout(false);
            this.EditUserPanel.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button MUAddUser;
        private System.Windows.Forms.Panel AddUserPanel;
        private System.Windows.Forms.Button MUAddManager;
        private System.Windows.Forms.Button MUAddChef;
        private System.Windows.Forms.Button MUAddCustomer;
        private Timer AUPanelTimer;
        private Button AdmimDropDown;
        private Panel MenuPanel;
        private Button btnFeedback;
        private Button btnSalesReport;
        private Button btnManageUser;
        private Button btnManageAccount;
        private Timer dropdownTimer;
        private Button AdminExit;
        private Button MUEditUser;
        private Panel EditUserPanel;
        private Button MUEditManager;
        private Button MUEditChef;
        private Button MUEditCustomer;
        private Timer EUPanelTimer;
        private Button btnAdminDashboard;
        private Button AdminLogOut;
        private Panel panel1;
    }
}