namespace IOOP_assignment.Forms
{
    partial class AdminDashboard
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AdminDashboard));
            this.label1 = new System.Windows.Forms.Label();
            this.ManageUserOpen = new System.Windows.Forms.Button();
            this.ManageAccountOpen = new System.Windows.Forms.Button();
            this.SalesReportOpen = new System.Windows.Forms.Button();
            this.FeedbackOpen = new System.Windows.Forms.Button();
            this.AdminDashboardLogOut = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 28F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.Location = new System.Drawing.Point(893, 255);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(489, 64);
            this.label1.TabIndex = 2;
            this.label1.Text = "Admin Dashboard";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // ManageUserOpen
            // 
            this.ManageUserOpen.Location = new System.Drawing.Point(978, 335);
            this.ManageUserOpen.Name = "ManageUserOpen";
            this.ManageUserOpen.Size = new System.Drawing.Size(320, 84);
            this.ManageUserOpen.TabIndex = 3;
            this.ManageUserOpen.Text = "Manage User";
            this.ManageUserOpen.UseVisualStyleBackColor = true;
            this.ManageUserOpen.Click += new System.EventHandler(this.ManageUserOpen_Click);
            // 
            // ManageAccountOpen
            // 
            this.ManageAccountOpen.Location = new System.Drawing.Point(978, 425);
            this.ManageAccountOpen.Name = "ManageAccountOpen";
            this.ManageAccountOpen.Size = new System.Drawing.Size(320, 84);
            this.ManageAccountOpen.TabIndex = 4;
            this.ManageAccountOpen.Text = "Manage Account";
            this.ManageAccountOpen.UseVisualStyleBackColor = true;
            this.ManageAccountOpen.Click += new System.EventHandler(this.ManageAccountOpen_Click);
            // 
            // SalesReportOpen
            // 
            this.SalesReportOpen.Location = new System.Drawing.Point(978, 515);
            this.SalesReportOpen.Name = "SalesReportOpen";
            this.SalesReportOpen.Size = new System.Drawing.Size(320, 84);
            this.SalesReportOpen.TabIndex = 5;
            this.SalesReportOpen.Text = "Sales Report";
            this.SalesReportOpen.UseVisualStyleBackColor = true;
            this.SalesReportOpen.Click += new System.EventHandler(this.SalesReportOpen_Click);
            // 
            // FeedbackOpen
            // 
            this.FeedbackOpen.Location = new System.Drawing.Point(978, 605);
            this.FeedbackOpen.Name = "FeedbackOpen";
            this.FeedbackOpen.Size = new System.Drawing.Size(320, 84);
            this.FeedbackOpen.TabIndex = 6;
            this.FeedbackOpen.Text = "Feedback";
            this.FeedbackOpen.UseVisualStyleBackColor = true;
            this.FeedbackOpen.Click += new System.EventHandler(this.FeedbackOpen_Click);
            // 
            // AdminDashboardLogOut
            // 
            this.AdminDashboardLogOut.Location = new System.Drawing.Point(1406, 12);
            this.AdminDashboardLogOut.Name = "AdminDashboardLogOut";
            this.AdminDashboardLogOut.Size = new System.Drawing.Size(232, 60);
            this.AdminDashboardLogOut.TabIndex = 7;
            this.AdminDashboardLogOut.Text = "Log Out";
            this.AdminDashboardLogOut.UseVisualStyleBackColor = true;
            this.AdminDashboardLogOut.Click += new System.EventHandler(this.AdminDashboardLogOut_Click);
            // 
            // AdminDashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ClientSize = new System.Drawing.Size(1650, 900);
            this.Controls.Add(this.AdminDashboardLogOut);
            this.Controls.Add(this.FeedbackOpen);
            this.Controls.Add(this.SalesReportOpen);
            this.Controls.Add(this.ManageAccountOpen);
            this.Controls.Add(this.ManageUserOpen);
            this.Controls.Add(this.label1);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "AdminDashboard";
            this.Text = "AdminDashboard";
            this.Load += new System.EventHandler(this.AdminDashboard_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button ManageUserOpen;
        private System.Windows.Forms.Button ManageAccountOpen;
        private System.Windows.Forms.Button SalesReportOpen;
        private System.Windows.Forms.Button FeedbackOpen;
        private System.Windows.Forms.Button AdminDashboardLogOut;
    }
}