namespace IOOP_assignment.Forms
{
    partial class CustomerReservations
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
            this.flowLayoutReservations = new System.Windows.Forms.FlowLayoutPanel();
            this.viewCustomerMenuButton = new System.Windows.Forms.PictureBox();
            this.btnClose = new System.Windows.Forms.Button();
            this.reservationsLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.viewCustomerMenuButton)).BeginInit();
            this.SuspendLayout();
            // 
            // flowLayoutReservations
            // 
            this.flowLayoutReservations.AutoScroll = true;
            this.flowLayoutReservations.Location = new System.Drawing.Point(12, 52);
            this.flowLayoutReservations.Name = "flowLayoutReservations";
            this.flowLayoutReservations.Size = new System.Drawing.Size(911, 535);
            this.flowLayoutReservations.TabIndex = 0;
            // 
            // viewCustomerMenuButton
            // 
            this.viewCustomerMenuButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(234)))), ((int)(((byte)(206)))), ((int)(((byte)(170)))));
            this.viewCustomerMenuButton.Image = global::IOOP_assignment.Properties.Resources.menu_button_icon;
            this.viewCustomerMenuButton.Location = new System.Drawing.Point(12, 12);
            this.viewCustomerMenuButton.Name = "viewCustomerMenuButton";
            this.viewCustomerMenuButton.Size = new System.Drawing.Size(58, 51);
            this.viewCustomerMenuButton.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.viewCustomerMenuButton.TabIndex = 4;
            this.viewCustomerMenuButton.TabStop = false;
            this.viewCustomerMenuButton.Click += new System.EventHandler(this.viewCustomerMenuButton_Click);
            // 
            // btnClose
            // 
            this.btnClose.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(234)))), ((int)(((byte)(206)))), ((int)(((byte)(170)))));
            this.btnClose.FlatAppearance.BorderSize = 0;
            this.btnClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClose.Font = new System.Drawing.Font("Segoe Print", 12F, System.Drawing.FontStyle.Bold);
            this.btnClose.Location = new System.Drawing.Point(883, 12);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(40, 40);
            this.btnClose.TabIndex = 7;
            this.btnClose.Text = "X";
            this.btnClose.UseVisualStyleBackColor = false;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // reservationsLabel
            // 
            this.reservationsLabel.AutoSize = true;
            this.reservationsLabel.Font = new System.Drawing.Font("Segoe Print", 24F);
            this.reservationsLabel.Location = new System.Drawing.Point(326, 9);
            this.reservationsLabel.Name = "reservationsLabel";
            this.reservationsLabel.Size = new System.Drawing.Size(252, 46);
            this.reservationsLabel.TabIndex = 8;
            this.reservationsLabel.Text = "Reservations";
            // 
            // CustomerReservations
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(234)))), ((int)(((byte)(206)))), ((int)(((byte)(170)))));
            this.ClientSize = new System.Drawing.Size(935, 599);
            this.Controls.Add(this.reservationsLabel);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.viewCustomerMenuButton);
            this.Controls.Add(this.flowLayoutReservations);
            this.Name = "CustomerReservations";
            this.Text = "CustomerReservations";
            this.Load += new System.EventHandler(this.CustomerReservations_Load);
            ((System.ComponentModel.ISupportInitialize)(this.viewCustomerMenuButton)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.FlowLayoutPanel flowLayoutReservations;
        private System.Windows.Forms.PictureBox viewCustomerMenuButton;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Label reservationsLabel;
    }
}