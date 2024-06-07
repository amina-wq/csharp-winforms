namespace IOOP_assignment.Forms
{
    partial class AdminManageAccount
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AdminManageAccount));
            this.MAEditUser = new System.Windows.Forms.Button();
            this.lblManageAccount = new System.Windows.Forms.Label();
            this.MAAddUser = new System.Windows.Forms.Button();
            this.AdminExit = new System.Windows.Forms.Button();
            this.MenuPanel = new System.Windows.Forms.Panel();
            this.btnAdminDashboard = new System.Windows.Forms.Button();
            this.AdminLogOut = new System.Windows.Forms.Button();
            this.btnFeedback = new System.Windows.Forms.Button();
            this.btnSalesReport = new System.Windows.Forms.Button();
            this.btnManageUser = new System.Windows.Forms.Button();
            this.btnManageAccount = new System.Windows.Forms.Button();
            this.AdmimDropDown = new System.Windows.Forms.Button();
            this.dropdownTimer = new System.Windows.Forms.Timer(this.components);
            this.panel1 = new System.Windows.Forms.Panel();
            this.MenuPanel.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // MAEditUser
            // 
            this.MAEditUser.BackColor = System.Drawing.Color.Wheat;
            this.MAEditUser.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MAEditUser.Location = new System.Drawing.Point(690, 485);
            this.MAEditUser.Name = "MAEditUser";
            this.MAEditUser.Size = new System.Drawing.Size(255, 94);
            this.MAEditUser.TabIndex = 33;
            this.MAEditUser.Text = "Edit User";
            this.MAEditUser.UseVisualStyleBackColor = false;
            this.MAEditUser.Click += new System.EventHandler(this.MAEditUser_Click);
            // 
            // lblManageAccount
            // 
            this.lblManageAccount.AutoSize = true;
            this.lblManageAccount.BackColor = System.Drawing.Color.Transparent;
            this.lblManageAccount.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblManageAccount.Location = new System.Drawing.Point(637, 299);
            this.lblManageAccount.Name = "lblManageAccount";
            this.lblManageAccount.Size = new System.Drawing.Size(400, 55);
            this.lblManageAccount.TabIndex = 31;
            this.lblManageAccount.Text = "Manage Account";
            // 
            // MAAddUser
            // 
            this.MAAddUser.BackColor = System.Drawing.Color.Wheat;
            this.MAAddUser.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MAAddUser.ForeColor = System.Drawing.SystemColors.ControlText;
            this.MAAddUser.Location = new System.Drawing.Point(690, 372);
            this.MAAddUser.Name = "MAAddUser";
            this.MAAddUser.Size = new System.Drawing.Size(255, 94);
            this.MAAddUser.TabIndex = 32;
            this.MAAddUser.Text = "Add User";
            this.MAAddUser.UseVisualStyleBackColor = false;
            this.MAAddUser.Click += new System.EventHandler(this.MAAddUser_Click);
            // 
            // AdminExit
            // 
            this.AdminExit.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AdminExit.Location = new System.Drawing.Point(1582, 15);
            this.AdminExit.Name = "AdminExit";
            this.AdminExit.Size = new System.Drawing.Size(60, 60);
            this.AdminExit.TabIndex = 34;
            this.AdminExit.Text = "X";
            this.AdminExit.UseVisualStyleBackColor = true;
            this.AdminExit.Click += new System.EventHandler(this.AdminExit_Click);
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
            this.MenuPanel.Location = new System.Drawing.Point(12, 96);
            this.MenuPanel.Name = "MenuPanel";
            this.MenuPanel.Size = new System.Drawing.Size(331, 10);
            this.MenuPanel.TabIndex = 36;
            this.MenuPanel.Paint += new System.Windows.Forms.PaintEventHandler(this.MenuPanel_Paint);
            // 
            // btnAdminDashboard
            // 
            this.btnAdminDashboard.Font = new System.Drawing.Font("Times New Roman", 16F);
            this.btnAdminDashboard.Location = new System.Drawing.Point(21, 563);
            this.btnAdminDashboard.Name = "btnAdminDashboard";
            this.btnAdminDashboard.Size = new System.Drawing.Size(271, 106);
            this.btnAdminDashboard.TabIndex = 6;
            this.btnAdminDashboard.Text = "Admin Dashboard";
            this.btnAdminDashboard.UseVisualStyleBackColor = true;
            this.btnAdminDashboard.Click += new System.EventHandler(this.btnAdminDashboard_Click);
            // 
            // AdminLogOut
            // 
            this.AdminLogOut.Font = new System.Drawing.Font("Times New Roman", 16F);
            this.AdminLogOut.Location = new System.Drawing.Point(21, 698);
            this.AdminLogOut.Name = "AdminLogOut";
            this.AdminLogOut.Size = new System.Drawing.Size(271, 106);
            this.AdminLogOut.TabIndex = 5;
            this.AdminLogOut.Text = "Log Out";
            this.AdminLogOut.UseVisualStyleBackColor = true;
            this.AdminLogOut.Click += new System.EventHandler(this.AdminLogOut_Click);
            // 
            // btnFeedback
            // 
            this.btnFeedback.Font = new System.Drawing.Font("Times New Roman", 16F);
            this.btnFeedback.Location = new System.Drawing.Point(21, 277);
            this.btnFeedback.Name = "btnFeedback";
            this.btnFeedback.Size = new System.Drawing.Size(271, 106);
            this.btnFeedback.TabIndex = 4;
            this.btnFeedback.Text = "Feedback";
            this.btnFeedback.UseVisualStyleBackColor = true;
            this.btnFeedback.Click += new System.EventHandler(this.btnFeedback_Click);
            // 
            // btnSalesReport
            // 
            this.btnSalesReport.Font = new System.Drawing.Font("Times New Roman", 16F);
            this.btnSalesReport.Location = new System.Drawing.Point(21, 420);
            this.btnSalesReport.Name = "btnSalesReport";
            this.btnSalesReport.Size = new System.Drawing.Size(271, 106);
            this.btnSalesReport.TabIndex = 3;
            this.btnSalesReport.Text = "Sales Report";
            this.btnSalesReport.UseVisualStyleBackColor = true;
            this.btnSalesReport.Click += new System.EventHandler(this.btnSalesReport_Click);
            // 
            // btnManageUser
            // 
            this.btnManageUser.Font = new System.Drawing.Font("Times New Roman", 16F);
            this.btnManageUser.Location = new System.Drawing.Point(21, 22);
            this.btnManageUser.Name = "btnManageUser";
            this.btnManageUser.Size = new System.Drawing.Size(271, 106);
            this.btnManageUser.TabIndex = 1;
            this.btnManageUser.Text = "Manage User";
            this.btnManageUser.UseVisualStyleBackColor = true;
            this.btnManageUser.Click += new System.EventHandler(this.btnManageUser_Click);
            // 
            // btnManageAccount
            // 
            this.btnManageAccount.Font = new System.Drawing.Font("Times New Roman", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnManageAccount.Location = new System.Drawing.Point(21, 146);
            this.btnManageAccount.Name = "btnManageAccount";
            this.btnManageAccount.Size = new System.Drawing.Size(271, 106);
            this.btnManageAccount.TabIndex = 2;
            this.btnManageAccount.Text = "Manage Account";
            this.btnManageAccount.UseVisualStyleBackColor = true;
            this.btnManageAccount.Click += new System.EventHandler(this.btnManageAccount_Click);
            // 
            // AdmimDropDown
            // 
            this.AdmimDropDown.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("AdmimDropDown.BackgroundImage")));
            this.AdmimDropDown.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.AdmimDropDown.Location = new System.Drawing.Point(12, 8);
            this.AdmimDropDown.Name = "AdmimDropDown";
            this.AdmimDropDown.Size = new System.Drawing.Size(60, 60);
            this.AdmimDropDown.TabIndex = 35;
            this.AdmimDropDown.UseVisualStyleBackColor = true;
            this.AdmimDropDown.Click += new System.EventHandler(this.AdmimDropDown_Click);
            // 
            // dropdownTimer
            // 
            this.dropdownTimer.Interval = 15;
            this.dropdownTimer.Tick += new System.EventHandler(this.dropdownTimer_Tick);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.panel1.Controls.Add(this.AdminExit);
            this.panel1.Location = new System.Drawing.Point(-4, -3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1682, 93);
            this.panel1.TabIndex = 45;
            // 
            // AdminManageAccount
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1650, 900);
            this.Controls.Add(this.MenuPanel);
            this.Controls.Add(this.AdmimDropDown);
            this.Controls.Add(this.MAEditUser);
            this.Controls.Add(this.lblManageAccount);
            this.Controls.Add(this.MAAddUser);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "AdminManageAccount";
            this.Text = "AdminManageAccount";
            this.MenuPanel.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button MAEditUser;
        private System.Windows.Forms.Label lblManageAccount;
        private System.Windows.Forms.Button MAAddUser;
        private System.Windows.Forms.Button AdminExit;
        private System.Windows.Forms.Panel MenuPanel;
        private System.Windows.Forms.Button btnAdminDashboard;
        private System.Windows.Forms.Button AdminLogOut;
        private System.Windows.Forms.Button btnFeedback;
        private System.Windows.Forms.Button btnSalesReport;
        private System.Windows.Forms.Button btnManageUser;
        private System.Windows.Forms.Button btnManageAccount;
        private System.Windows.Forms.Button AdmimDropDown;
        private System.Windows.Forms.Timer dropdownTimer;
        private System.Windows.Forms.Panel panel1;
    }
}