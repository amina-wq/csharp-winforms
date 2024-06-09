using System.Windows.Forms;

namespace IOOP_assignment.Components
{
    partial class CustomerNavBar
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.viewProfileButton = new System.Windows.Forms.Button();
            this.viewFeedbackButton = new System.Windows.Forms.Button();
            this.viewReservationButton = new System.Windows.Forms.Button();
            this.viewOrdersButton = new System.Windows.Forms.Button();
            this.menuButton = new System.Windows.Forms.Button();
            this.homeButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // viewProfileButton
            // 
            this.viewProfileButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.viewProfileButton.FlatAppearance.BorderSize = 0;
            this.viewProfileButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.viewProfileButton.Font = new System.Drawing.Font("Segoe Print", 13F);
            this.viewProfileButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.viewProfileButton.Location = new System.Drawing.Point(15, 400);
            this.viewProfileButton.Name = "viewProfileButton";
            this.viewProfileButton.Size = new System.Drawing.Size(170, 40);
            this.viewProfileButton.TabIndex = 5;
            this.viewProfileButton.Text = "Profile";
            this.viewProfileButton.UseVisualStyleBackColor = false;
            this.viewProfileButton.Click += new System.EventHandler(this.viewProfileButton_Click);
            // 
            // viewFeedbackButton
            // 
            this.viewFeedbackButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.viewFeedbackButton.FlatAppearance.BorderSize = 0;
            this.viewFeedbackButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.viewFeedbackButton.Font = new System.Drawing.Font("Segoe Print", 13F);
            this.viewFeedbackButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.viewFeedbackButton.Location = new System.Drawing.Point(15, 330);
            this.viewFeedbackButton.Name = "viewFeedbackButton";
            this.viewFeedbackButton.Size = new System.Drawing.Size(170, 40);
            this.viewFeedbackButton.TabIndex = 4;
            this.viewFeedbackButton.Text = "Feedback";
            this.viewFeedbackButton.UseVisualStyleBackColor = false;
            this.viewFeedbackButton.Click += new System.EventHandler(this.viewFeedbackButton_Click);
            // 
            // viewReservationButton
            // 
            this.viewReservationButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.viewReservationButton.FlatAppearance.BorderSize = 0;
            this.viewReservationButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.viewReservationButton.Font = new System.Drawing.Font("Segoe Print", 13F);
            this.viewReservationButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.viewReservationButton.Location = new System.Drawing.Point(15, 260);
            this.viewReservationButton.Name = "viewReservationButton";
            this.viewReservationButton.Size = new System.Drawing.Size(170, 40);
            this.viewReservationButton.TabIndex = 3;
            this.viewReservationButton.Text = "Reservations ";
            this.viewReservationButton.UseVisualStyleBackColor = false;
            this.viewReservationButton.Click += new System.EventHandler(this.viewReservationButton_Click);
            // 
            // viewOrdersButton
            // 
            this.viewOrdersButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.viewOrdersButton.FlatAppearance.BorderSize = 0;
            this.viewOrdersButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.viewOrdersButton.Font = new System.Drawing.Font("Segoe Print", 13F);
            this.viewOrdersButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.viewOrdersButton.Location = new System.Drawing.Point(15, 190);
            this.viewOrdersButton.Name = "viewOrdersButton";
            this.viewOrdersButton.Size = new System.Drawing.Size(170, 40);
            this.viewOrdersButton.TabIndex = 2;
            this.viewOrdersButton.Text = "Orders";
            this.viewOrdersButton.UseVisualStyleBackColor = false;
            this.viewOrdersButton.Click += new System.EventHandler(this.viewOrdersButton_Click);
            // 
            // menuButton
            // 
            this.menuButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.menuButton.FlatAppearance.BorderSize = 0;
            this.menuButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.menuButton.Font = new System.Drawing.Font("Segoe Print", 13F);
            this.menuButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.menuButton.Location = new System.Drawing.Point(15, 120);
            this.menuButton.Name = "menuButton";
            this.menuButton.Size = new System.Drawing.Size(170, 40);
            this.menuButton.TabIndex = 1;
            this.menuButton.Text = "Menu";
            this.menuButton.UseVisualStyleBackColor = false;
            this.menuButton.Click += new System.EventHandler(this.menuButton_Click);
            // 
            // homeButton
            // 
            this.homeButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.homeButton.FlatAppearance.BorderSize = 0;
            this.homeButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.homeButton.Font = new System.Drawing.Font("Segoe Print", 13F);
            this.homeButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.homeButton.Location = new System.Drawing.Point(15, 50);
            this.homeButton.Name = "homeButton";
            this.homeButton.Size = new System.Drawing.Size(170, 40);
            this.homeButton.TabIndex = 0;
            this.homeButton.Text = "Home";
            this.homeButton.UseVisualStyleBackColor = false;
            this.homeButton.Click += new System.EventHandler(this.homeButton_Click);
            // 
            // CustomerNavBar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(234)))), ((int)(((byte)(206)))), ((int)(((byte)(170)))));
            this.Controls.Add(this.viewProfileButton);
            this.Controls.Add(this.viewFeedbackButton);
            this.Controls.Add(this.homeButton);
            this.Controls.Add(this.viewReservationButton);
            this.Controls.Add(this.menuButton);
            this.Controls.Add(this.viewOrdersButton);
            this.Name = "CustomerNavBar";
            this.Size = new System.Drawing.Size(200, 473);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button homeButton;
        private Button viewProfileButton;
        private Button viewFeedbackButton;
        private Button viewReservationButton;
        private Button viewOrdersButton;
        private Button menuButton;
    }
}
