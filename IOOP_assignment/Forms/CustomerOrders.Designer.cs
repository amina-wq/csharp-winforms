namespace IOOP_assignment.Forms
{
    partial class CustomerOrders
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CustomerOrders));
            this.flowLayoutOrdersPanels = new System.Windows.Forms.FlowLayoutPanel();
            this.viewCustomerMenuButton = new System.Windows.Forms.PictureBox();
            this.restarauntLogo = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnClose = new System.Windows.Forms.Button();
            this.titleOrders = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.viewCustomerMenuButton)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.restarauntLogo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // flowLayoutOrdersPanels
            // 
            this.flowLayoutOrdersPanels.AutoScroll = true;
            this.flowLayoutOrdersPanels.Location = new System.Drawing.Point(428, 159);
            this.flowLayoutOrdersPanels.Name = "flowLayoutOrdersPanels";
            this.flowLayoutOrdersPanels.Size = new System.Drawing.Size(534, 421);
            this.flowLayoutOrdersPanels.TabIndex = 4;
            // 
            // viewCustomerMenuButton
            // 
            this.viewCustomerMenuButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(234)))), ((int)(((byte)(206)))), ((int)(((byte)(170)))));
            this.viewCustomerMenuButton.Image = global::IOOP_assignment.Properties.Resources.menu_button_icon;
            this.viewCustomerMenuButton.Location = new System.Drawing.Point(12, 12);
            this.viewCustomerMenuButton.Name = "viewCustomerMenuButton";
            this.viewCustomerMenuButton.Size = new System.Drawing.Size(58, 51);
            this.viewCustomerMenuButton.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.viewCustomerMenuButton.TabIndex = 5;
            this.viewCustomerMenuButton.TabStop = false;
            // 
            // restarauntLogo
            // 
            this.restarauntLogo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(234)))), ((int)(((byte)(206)))), ((int)(((byte)(170)))));
            this.restarauntLogo.Image = global::IOOP_assignment.Properties.Resources.restaurants_at_the_corners_logo;
            this.restarauntLogo.Location = new System.Drawing.Point(610, 26);
            this.restarauntLogo.Name = "restarauntLogo";
            this.restarauntLogo.Size = new System.Drawing.Size(198, 73);
            this.restarauntLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.restarauntLogo.TabIndex = 3;
            this.restarauntLogo.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(2, -2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(420, 592);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // btnClose
            // 
            this.btnClose.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(234)))), ((int)(((byte)(206)))), ((int)(((byte)(170)))));
            this.btnClose.FlatAppearance.BorderSize = 0;
            this.btnClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClose.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.btnClose.Location = new System.Drawing.Point(922, 12);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(40, 40);
            this.btnClose.TabIndex = 6;
            this.btnClose.Text = "X";
            this.btnClose.UseVisualStyleBackColor = false;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // titleOrders
            // 
            this.titleOrders.AutoSize = true;
            this.titleOrders.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F);
            this.titleOrders.ForeColor = System.Drawing.SystemColors.Control;
            this.titleOrders.Location = new System.Drawing.Point(458, 117);
            this.titleOrders.Name = "titleOrders";
            this.titleOrders.Size = new System.Drawing.Size(129, 39);
            this.titleOrders.TabIndex = 7;
            this.titleOrders.Text = "Orders:";
            // 
            // CustomerOrders
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlText;
            this.ClientSize = new System.Drawing.Size(974, 592);
            this.Controls.Add(this.titleOrders);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.viewCustomerMenuButton);
            this.Controls.Add(this.flowLayoutOrdersPanels);
            this.Controls.Add(this.restarauntLogo);
            this.Controls.Add(this.pictureBox1);
            this.Name = "CustomerOrders";
            this.Text = "CustomerOrders";
            this.Load += new System.EventHandler(this.CustomerOrders_Load);
            ((System.ComponentModel.ISupportInitialize)(this.viewCustomerMenuButton)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.restarauntLogo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox restarauntLogo;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutOrdersPanels;
        private System.Windows.Forms.PictureBox viewCustomerMenuButton;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Label titleOrders;
    }
}