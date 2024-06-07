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
            this.MenuPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewSales)).BeginInit();
            this.SuspendLayout();
            // 
            // AdminExit
            // 
            this.AdminExit.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AdminExit.Location = new System.Drawing.Point(1578, 12);
            this.AdminExit.Name = "AdminExit";
            this.AdminExit.Size = new System.Drawing.Size(60, 60);
            this.AdminExit.TabIndex = 39;
            this.AdminExit.Text = "X";
            this.AdminExit.UseVisualStyleBackColor = true;
            this.AdminExit.Click += new System.EventHandler(this.AdminExit_Click);
            // 
            // MenuPanel
            // 
            this.MenuPanel.Controls.Add(this.btnAdminDashboard);
            this.MenuPanel.Controls.Add(this.AdminLogOut);
            this.MenuPanel.Controls.Add(this.btnFeedback);
            this.MenuPanel.Controls.Add(this.btnSalesReport);
            this.MenuPanel.Controls.Add(this.btnManageUser);
            this.MenuPanel.Controls.Add(this.btnManageAccount);
            this.MenuPanel.Location = new System.Drawing.Point(12, 72);
            this.MenuPanel.Name = "MenuPanel";
            this.MenuPanel.Size = new System.Drawing.Size(331, 10);
            this.MenuPanel.TabIndex = 41;
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
            this.AdmimDropDown.Location = new System.Drawing.Point(12, 6);
            this.AdmimDropDown.Name = "AdmimDropDown";
            this.AdmimDropDown.Size = new System.Drawing.Size(60, 60);
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
            this.txtSearch.Location = new System.Drawing.Point(1019, 181);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(539, 26);
            this.txtSearch.TabIndex = 42;
            this.txtSearch.TextChanged += new System.EventHandler(this.txtSearch_TextChanged);
            // 
            // dataGridViewSales
            // 
            this.dataGridViewSales.AllowUserToAddRows = false;
            this.dataGridViewSales.AllowUserToDeleteRows = false;
            this.dataGridViewSales.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewSales.Location = new System.Drawing.Point(347, 291);
            this.dataGridViewSales.Name = "dataGridViewSales";
            this.dataGridViewSales.ReadOnly = true;
            this.dataGridViewSales.RowHeadersWidth = 62;
            this.dataGridViewSales.RowTemplate.Height = 28;
            this.dataGridViewSales.Size = new System.Drawing.Size(1211, 536);
            this.dataGridViewSales.TabIndex = 43;
            // 
            // lblTotalAmount
            // 
            this.lblTotalAmount.AutoSize = true;
            this.lblTotalAmount.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotalAmount.Location = new System.Drawing.Point(1116, 830);
            this.lblTotalAmount.Name = "lblTotalAmount";
            this.lblTotalAmount.Size = new System.Drawing.Size(114, 46);
            this.lblTotalAmount.TabIndex = 44;
            this.lblTotalAmount.Text = "Total";
            // 
            // listBoxOrders
            // 
            this.listBoxOrders.FormattingEnabled = true;
            this.listBoxOrders.ItemHeight = 20;
            this.listBoxOrders.Location = new System.Drawing.Point(347, 181);
            this.listBoxOrders.Name = "listBoxOrders";
            this.listBoxOrders.Size = new System.Drawing.Size(666, 104);
            this.listBoxOrders.TabIndex = 45;
            this.listBoxOrders.SelectedIndexChanged += new System.EventHandler(this.listBoxOrders_SelectedIndexChanged);
            // 
            // btnSort
            // 
            this.btnSort.Location = new System.Drawing.Point(1019, 213);
            this.btnSort.Name = "btnSort";
            this.btnSort.Size = new System.Drawing.Size(233, 64);
            this.btnSort.TabIndex = 46;
            this.btnSort.Text = "Sort";
            this.btnSort.UseVisualStyleBackColor = true;
            this.btnSort.Click += new System.EventHandler(this.btnSort_Click);
            // 
            // listBoxSort
            // 
            this.listBoxSort.FormattingEnabled = true;
            this.listBoxSort.ItemHeight = 20;
            this.listBoxSort.Location = new System.Drawing.Point(1258, 213);
            this.listBoxSort.Name = "listBoxSort";
            this.listBoxSort.Size = new System.Drawing.Size(300, 64);
            this.listBoxSort.TabIndex = 47;
            this.listBoxSort.SelectedIndexChanged += new System.EventHandler(this.listBoxSort_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 22F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(832, 115);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(398, 52);
            this.label1.TabIndex = 48;
            this.label1.Text = "View Sales Report";
            // 
            // AdminSalesReport
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1650, 900);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.listBoxSort);
            this.Controls.Add(this.btnSort);
            this.Controls.Add(this.listBoxOrders);
            this.Controls.Add(this.lblTotalAmount);
            this.Controls.Add(this.dataGridViewSales);
            this.Controls.Add(this.txtSearch);
            this.Controls.Add(this.AdminExit);
            this.Controls.Add(this.MenuPanel);
            this.Controls.Add(this.AdmimDropDown);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "AdminSalesReport";
            this.Text = "AdminSalesReport";
            this.MenuPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewSales)).EndInit();
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
    }
}