namespace IOOP_assignment.Forms
{
    partial class AdminSalesReport
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AdminSalesReport));
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
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.dataGridViewSales = new System.Windows.Forms.DataGridView();
            this.lblTotalAmount = new System.Windows.Forms.Label();
            this.listBoxOrders = new System.Windows.Forms.ListBox();
            this.btnSort = new System.Windows.Forms.Button();
            this.listBoxSort = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.MenuPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewSales)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // AdminExit
            // 
            this.AdminExit.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AdminExit.Location = new System.Drawing.Point(1401, 14);
            this.AdminExit.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.AdminExit.Name = "AdminExit";
            this.AdminExit.Size = new System.Drawing.Size(53, 48);
            this.AdminExit.TabIndex = 39;
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
            this.MenuPanel.Location = new System.Drawing.Point(2, 70);
            this.MenuPanel.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.MenuPanel.Name = "MenuPanel";
            this.MenuPanel.Size = new System.Drawing.Size(294, 8);
            this.MenuPanel.TabIndex = 41;
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
            // AdmimDropDown
            // 
            this.AdmimDropDown.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("AdmimDropDown.BackgroundImage")));
            this.AdmimDropDown.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.AdmimDropDown.Location = new System.Drawing.Point(11, 5);
            this.AdmimDropDown.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.AdmimDropDown.Name = "AdmimDropDown";
            this.AdmimDropDown.Size = new System.Drawing.Size(53, 48);
            this.AdmimDropDown.TabIndex = 40;
            this.AdmimDropDown.UseVisualStyleBackColor = true;
            this.AdmimDropDown.Click += new System.EventHandler(this.AdmimDropDown_Click);
            // 
            // dropdownTimer
            // 
            this.dropdownTimer.Interval = 15;
            this.dropdownTimer.Tick += new System.EventHandler(this.dropdownTimer_Tick);
            // 
            // txtSearch
            // 
            this.txtSearch.Location = new System.Drawing.Point(906, 145);
            this.txtSearch.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(480, 22);
            this.txtSearch.TabIndex = 42;
            this.txtSearch.TextChanged += new System.EventHandler(this.txtSearch_TextChanged);
            // 
            // dataGridViewSales
            // 
            this.dataGridViewSales.AllowUserToAddRows = false;
            this.dataGridViewSales.AllowUserToDeleteRows = false;
            this.dataGridViewSales.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewSales.Location = new System.Drawing.Point(308, 233);
            this.dataGridViewSales.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dataGridViewSales.Name = "dataGridViewSales";
            this.dataGridViewSales.ReadOnly = true;
            this.dataGridViewSales.RowHeadersWidth = 62;
            this.dataGridViewSales.RowTemplate.Height = 28;
            this.dataGridViewSales.Size = new System.Drawing.Size(1076, 429);
            this.dataGridViewSales.TabIndex = 43;
            // 
            // lblTotalAmount
            // 
            this.lblTotalAmount.AutoSize = true;
            this.lblTotalAmount.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotalAmount.Location = new System.Drawing.Point(992, 664);
            this.lblTotalAmount.Name = "lblTotalAmount";
            this.lblTotalAmount.Size = new System.Drawing.Size(98, 39);
            this.lblTotalAmount.TabIndex = 44;
            this.lblTotalAmount.Text = "Total";
            // 
            // listBoxOrders
            // 
            this.listBoxOrders.FormattingEnabled = true;
            this.listBoxOrders.ItemHeight = 16;
            this.listBoxOrders.Location = new System.Drawing.Point(308, 145);
            this.listBoxOrders.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.listBoxOrders.Name = "listBoxOrders";
            this.listBoxOrders.Size = new System.Drawing.Size(592, 84);
            this.listBoxOrders.TabIndex = 45;
            this.listBoxOrders.SelectedIndexChanged += new System.EventHandler(this.listBoxOrders_SelectedIndexChanged);
            // 
            // btnSort
            // 
            this.btnSort.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.btnSort.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnSort.Location = new System.Drawing.Point(906, 170);
            this.btnSort.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnSort.Name = "btnSort";
            this.btnSort.Size = new System.Drawing.Size(207, 51);
            this.btnSort.TabIndex = 46;
            this.btnSort.Text = "Sort";
            this.btnSort.UseVisualStyleBackColor = false;
            this.btnSort.Click += new System.EventHandler(this.btnSort_Click);
            // 
            // listBoxSort
            // 
            this.listBoxSort.FormattingEnabled = true;
            this.listBoxSort.ItemHeight = 16;
            this.listBoxSort.Location = new System.Drawing.Point(1118, 170);
            this.listBoxSort.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.listBoxSort.Name = "listBoxSort";
            this.listBoxSort.Size = new System.Drawing.Size(267, 52);
            this.listBoxSort.TabIndex = 47;
            this.listBoxSort.SelectedIndexChanged += new System.EventHandler(this.listBoxSort_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 22F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.label1.Location = new System.Drawing.Point(740, 92);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(342, 42);
            this.label1.TabIndex = 48;
            this.label1.Text = "View Sales Report";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.panel1.Controls.Add(this.AdminExit);
            this.panel1.Location = new System.Drawing.Point(-13, -4);
            this.panel1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1510, 70);
            this.panel1.TabIndex = 49;
            // 
            // AdminSalesReport
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1467, 720);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.listBoxSort);
            this.Controls.Add(this.btnSort);
            this.Controls.Add(this.listBoxOrders);
            this.Controls.Add(this.lblTotalAmount);
            this.Controls.Add(this.dataGridViewSales);
            this.Controls.Add(this.txtSearch);
            this.Controls.Add(this.MenuPanel);
            this.Controls.Add(this.AdmimDropDown);
            this.Controls.Add(this.panel1);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "AdminSalesReport";
            this.Text = "AdminSalesReport";
            this.MenuPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewSales)).EndInit();
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

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
        private System.Windows.Forms.TextBox txtSearch;
        private System.Windows.Forms.DataGridView dataGridViewSales;
        private System.Windows.Forms.Label lblTotalAmount;
        private System.Windows.Forms.ListBox listBoxOrders;
        private System.Windows.Forms.Button btnSort;
        private System.Windows.Forms.ListBox listBoxSort;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel1;
    }
}