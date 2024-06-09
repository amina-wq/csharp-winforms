using IOOP_assignment.Components;
using System.Drawing;
using System.Windows.Forms;

namespace IOOP_assignment.Forms
{
    partial class CustomerMenu
    {
        private System.ComponentModel.IContainer components = null;
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanelMenuItems;
        private System.Windows.Forms.Button btnShowCart;
        private System.Windows.Forms.Button btnClose;

        private void InitializeComponent()
        {
            this.flowLayoutPanelMenuItems = new System.Windows.Forms.FlowLayoutPanel();
            this.btnShowCart = new System.Windows.Forms.Button();
            this.restarauntLogo = new System.Windows.Forms.PictureBox();
            this.headerPanel = new System.Windows.Forms.Panel();
            this.viewCustomerMenuButton = new System.Windows.Forms.PictureBox();
            this.btnClose = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.restarauntLogo)).BeginInit();
            this.headerPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.viewCustomerMenuButton)).BeginInit();
            this.SuspendLayout();
            // 
            // flowLayoutPanelMenuItems
            // 
            this.flowLayoutPanelMenuItems.AutoScroll = true;
            this.flowLayoutPanelMenuItems.BackColor = System.Drawing.Color.Transparent;
            this.flowLayoutPanelMenuItems.Location = new System.Drawing.Point(12, 132);
            this.flowLayoutPanelMenuItems.Name = "flowLayoutPanelMenuItems";
            this.flowLayoutPanelMenuItems.Size = new System.Drawing.Size(640, 446);
            this.flowLayoutPanelMenuItems.TabIndex = 0;
            // 
            // btnShowCart
            // 
            this.btnShowCart.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(234)))), ((int)(((byte)(206)))), ((int)(((byte)(170)))));
            this.btnShowCart.FlatAppearance.BorderSize = 0;
            this.btnShowCart.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnShowCart.Image = global::IOOP_assignment.Properties.Resources.shoppingCart;
            this.btnShowCart.Location = new System.Drawing.Point(664, 3);
            this.btnShowCart.Name = "btnShowCart";
            this.btnShowCart.Size = new System.Drawing.Size(64, 64);
            this.btnShowCart.TabIndex = 1;
            this.btnShowCart.UseVisualStyleBackColor = false;
            this.btnShowCart.Click += new System.EventHandler(this.btnShowCart_Click);
            // 
            // restarauntLogo
            // 
            this.restarauntLogo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(234)))), ((int)(((byte)(206)))), ((int)(((byte)(170)))));
            this.restarauntLogo.Image = global::IOOP_assignment.Properties.Resources.restaurants_at_the_corners_logo;
            this.restarauntLogo.Location = new System.Drawing.Point(93, 0);
            this.restarauntLogo.Name = "restarauntLogo";
            this.restarauntLogo.Size = new System.Drawing.Size(234, 78);
            this.restarauntLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.restarauntLogo.TabIndex = 2;
            this.restarauntLogo.TabStop = false;
            // 
            // headerPanel
            // 
            this.headerPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(234)))), ((int)(((byte)(206)))), ((int)(((byte)(170)))));
            this.headerPanel.Controls.Add(this.viewCustomerMenuButton);
            this.headerPanel.Controls.Add(this.btnClose);
            this.headerPanel.Controls.Add(this.restarauntLogo);
            this.headerPanel.Controls.Add(this.btnShowCart);
            this.headerPanel.Location = new System.Drawing.Point(12, 12);
            this.headerPanel.Name = "headerPanel";
            this.headerPanel.Size = new System.Drawing.Size(795, 78);
            this.headerPanel.TabIndex = 4;
            this.headerPanel.Controls.SetChildIndex(this.btnShowCart, 0);
            this.headerPanel.Controls.SetChildIndex(this.restarauntLogo, 0);
            this.headerPanel.Controls.SetChildIndex(this.viewCustomerMenuButton, 0);
            // 
            // viewCustomerMenuButton
            // 
            this.viewCustomerMenuButton.Image = global::IOOP_assignment.Properties.Resources.menu_button_icon;
            this.viewCustomerMenuButton.Location = new System.Drawing.Point(18, 16);
            this.viewCustomerMenuButton.Name = "viewCustomerMenuButton";
            this.viewCustomerMenuButton.Size = new System.Drawing.Size(58, 51);
            this.viewCustomerMenuButton.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.viewCustomerMenuButton.TabIndex = 3;
            this.viewCustomerMenuButton.TabStop = false;
            this.viewCustomerMenuButton.Click += new System.EventHandler(this.viewCustomerMenuButton_Click);
            // 
            // btnClose
            // 
            this.btnClose.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(234)))), ((int)(((byte)(206)))), ((int)(((byte)(170)))));
            this.btnClose.FlatAppearance.BorderSize = 0;
            this.btnClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClose.Font = new System.Drawing.Font("Segoe Print", 12F, System.Drawing.FontStyle.Bold);
            this.btnClose.Location = new System.Drawing.Point(752, 3);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(40, 40);
            this.btnClose.TabIndex = 3;
            this.btnClose.Text = "X";
            this.btnClose.UseVisualStyleBackColor = false;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // CustomerMenu
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackgroundImage = global::IOOP_assignment.Properties.Resources.menuBackground;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(819, 590);
            this.Controls.Add(this.headerPanel);
            this.Controls.Add(this.flowLayoutPanelMenuItems);
            this.Name = "CustomerMenu";
            this.Text = "Menu";
            this.Load += new System.EventHandler(this.CustomerMenu_Load);
            ((System.ComponentModel.ISupportInitialize)(this.restarauntLogo)).EndInit();
            this.headerPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.viewCustomerMenuButton)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox restarauntLogo;
        private System.Windows.Forms.Panel headerPanel;
        private PictureBox viewCustomerMenuButton;
    }
}