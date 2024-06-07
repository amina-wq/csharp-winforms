namespace IOOP_assignment.Forms
{
    partial class LoginForm
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnViewProfile = new System.Windows.Forms.Button();
            this.btnManageReserv = new System.Windows.Forms.Button();
            this.btnManageCategory = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Silver;
            this.panel1.Controls.Add(this.btnViewProfile);
            this.panel1.Controls.Add(this.btnManageReserv);
            this.panel1.Controls.Add(this.btnManageCategory);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel1.Location = new System.Drawing.Point(449, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(351, 450);
            this.panel1.TabIndex = 1;
            // 
            // btnViewProfile
            // 
            this.btnViewProfile.Location = new System.Drawing.Point(74, 309);
            this.btnViewProfile.Name = "btnViewProfile";
            this.btnViewProfile.Size = new System.Drawing.Size(204, 43);
            this.btnViewProfile.TabIndex = 3;
            this.btnViewProfile.Text = "View Profile";
            this.btnViewProfile.UseVisualStyleBackColor = true;
            this.btnViewProfile.Click += new System.EventHandler(this.btnViewProfile_Click);
            // 
            // btnManageReserv
            // 
            this.btnManageReserv.Location = new System.Drawing.Point(74, 238);
            this.btnManageReserv.Name = "btnManageReserv";
            this.btnManageReserv.Size = new System.Drawing.Size(204, 43);
            this.btnManageReserv.TabIndex = 2;
            this.btnManageReserv.Text = "Manage Reservation";
            this.btnManageReserv.UseVisualStyleBackColor = true;
            this.btnManageReserv.Click += new System.EventHandler(this.btnManageReserv_Click);
            // 
            // btnManageCategory
            // 
            this.btnManageCategory.Location = new System.Drawing.Point(74, 166);
            this.btnManageCategory.Name = "btnManageCategory";
            this.btnManageCategory.Size = new System.Drawing.Size(204, 43);
            this.btnManageCategory.TabIndex = 1;
            this.btnManageCategory.Text = "Manage Category";
            this.btnManageCategory.UseVisualStyleBackColor = true;
            this.btnManageCategory.Click += new System.EventHandler(this.btnManageCategory_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(104, 95);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(145, 38);
            this.label1.TabIndex = 0;
            this.label1.Text = "Manager";
            // 
            // LoginForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.panel1);
            this.Name = "LoginForm";
            this.Text = "LoginForm";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnViewProfile;
        private System.Windows.Forms.Button btnManageReserv;
        private System.Windows.Forms.Button btnManageCategory;
        private System.Windows.Forms.Label label1;
    }
}