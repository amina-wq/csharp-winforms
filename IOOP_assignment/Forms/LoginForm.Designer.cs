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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LoginForm));
            this.panel1 = new System.Windows.Forms.Panel();
            this.BtnLogout = new System.Windows.Forms.Button();
            this.btnViewProfile = new System.Windows.Forms.Button();
            this.btnManageReserv = new System.Windows.Forms.Button();
            this.btnManageCategory = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Black;
            this.panel1.Controls.Add(this.BtnLogout);
            this.panel1.Controls.Add(this.btnViewProfile);
            this.panel1.Controls.Add(this.btnManageReserv);
            this.panel1.Controls.Add(this.btnManageCategory);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel1.Location = new System.Drawing.Point(449, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(351, 442);
            this.panel1.TabIndex = 1;
            // 
            // BtnLogout
            // 
            this.BtnLogout.BackColor = System.Drawing.Color.BlanchedAlmond;
            this.BtnLogout.Font = new System.Drawing.Font("Sylfaen", 7.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnLogout.Location = new System.Drawing.Point(230, 3);
            this.BtnLogout.Name = "BtnLogout";
            this.BtnLogout.Size = new System.Drawing.Size(118, 37);
            this.BtnLogout.TabIndex = 4;
            this.BtnLogout.Text = "Logout";
            this.BtnLogout.UseVisualStyleBackColor = false;
            this.BtnLogout.Click += new System.EventHandler(this.BtnLogout_Click);
            // 
            // btnViewProfile
            // 
            this.btnViewProfile.BackColor = System.Drawing.Color.BlanchedAlmond;
            this.btnViewProfile.Font = new System.Drawing.Font("Sylfaen", 7.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnViewProfile.Location = new System.Drawing.Point(74, 309);
            this.btnViewProfile.Name = "btnViewProfile";
            this.btnViewProfile.Size = new System.Drawing.Size(204, 43);
            this.btnViewProfile.TabIndex = 3;
            this.btnViewProfile.Text = "View Profile";
            this.btnViewProfile.UseVisualStyleBackColor = false;
            this.btnViewProfile.Click += new System.EventHandler(this.btnViewProfile_Click);
            // 
            // btnManageReserv
            // 
            this.btnManageReserv.BackColor = System.Drawing.Color.BlanchedAlmond;
            this.btnManageReserv.Font = new System.Drawing.Font("Sylfaen", 7.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnManageReserv.Location = new System.Drawing.Point(74, 238);
            this.btnManageReserv.Name = "btnManageReserv";
            this.btnManageReserv.Size = new System.Drawing.Size(204, 43);
            this.btnManageReserv.TabIndex = 2;
            this.btnManageReserv.Text = "Manage Reservation";
            this.btnManageReserv.UseVisualStyleBackColor = false;
            this.btnManageReserv.Click += new System.EventHandler(this.btnManageReserv_Click);
            // 
            // btnManageCategory
            // 
            this.btnManageCategory.BackColor = System.Drawing.Color.BlanchedAlmond;
            this.btnManageCategory.Font = new System.Drawing.Font("Sylfaen", 7.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnManageCategory.Location = new System.Drawing.Point(74, 166);
            this.btnManageCategory.Name = "btnManageCategory";
            this.btnManageCategory.Size = new System.Drawing.Size(204, 43);
            this.btnManageCategory.TabIndex = 1;
            this.btnManageCategory.Text = "Manage Category";
            this.btnManageCategory.UseVisualStyleBackColor = false;
            this.btnManageCategory.Click += new System.EventHandler(this.btnManageCategory_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Sylfaen", 19.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(17, 95);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(316, 43);
            this.label1.TabIndex = 0;
            this.label1.Text = "Manager Dashboard";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(108, 33);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(218, 92);
            this.pictureBox1.TabIndex = 5;
            this.pictureBox1.TabStop = false;
            // 
            // LoginForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(800, 442);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "LoginForm";
            this.Text = "LoginForm";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnViewProfile;
        private System.Windows.Forms.Button btnManageReserv;
        private System.Windows.Forms.Button btnManageCategory;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button BtnLogout;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}