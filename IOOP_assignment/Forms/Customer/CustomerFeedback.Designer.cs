namespace IOOP_assignment.Forms
{
    partial class CustomerFeedback
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
            this.btnClose = new System.Windows.Forms.Button();
            this.viewCustomerMenuButton = new System.Windows.Forms.PictureBox();
            this.feedback = new System.Windows.Forms.Label();
            this.txtFeedback = new System.Windows.Forms.TextBox();
            this.btnSubmit = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.viewCustomerMenuButton)).BeginInit();
            this.SuspendLayout();
            // 
            // btnClose
            // 
            this.btnClose.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(234)))), ((int)(((byte)(206)))), ((int)(((byte)(170)))));
            this.btnClose.FlatAppearance.BorderSize = 0;
            this.btnClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClose.Font = new System.Drawing.Font("Segoe Print", 12F, System.Drawing.FontStyle.Bold);
            this.btnClose.Location = new System.Drawing.Point(759, 11);
            this.btnClose.Margin = new System.Windows.Forms.Padding(2);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(30, 32);
            this.btnClose.TabIndex = 8;
            this.btnClose.Text = "X";
            this.btnClose.UseVisualStyleBackColor = false;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // viewCustomerMenuButton
            // 
            this.viewCustomerMenuButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(234)))), ((int)(((byte)(206)))), ((int)(((byte)(170)))));
            this.viewCustomerMenuButton.Image = global::IOOP_assignment.Properties.Resources.menu_button_icon;
            this.viewCustomerMenuButton.Location = new System.Drawing.Point(11, 11);
            this.viewCustomerMenuButton.Margin = new System.Windows.Forms.Padding(2);
            this.viewCustomerMenuButton.Name = "viewCustomerMenuButton";
            this.viewCustomerMenuButton.Size = new System.Drawing.Size(44, 41);
            this.viewCustomerMenuButton.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.viewCustomerMenuButton.TabIndex = 9;
            this.viewCustomerMenuButton.TabStop = false;
            this.viewCustomerMenuButton.Click += new System.EventHandler(this.viewCustomerMenuButton_Click);
            // 
            // feedback
            // 
            this.feedback.AutoSize = true;
            this.feedback.Font = new System.Drawing.Font("Segoe Print", 24F);
            this.feedback.Location = new System.Drawing.Point(308, 11);
            this.feedback.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.feedback.Name = "feedback";
            this.feedback.Size = new System.Drawing.Size(157, 37);
            this.feedback.TabIndex = 10;
            this.feedback.Text = "Feedback";
            // 
            // txtFeedback
            // 
            this.txtFeedback.Font = new System.Drawing.Font("Segoe Print", 14F);
            this.txtFeedback.Location = new System.Drawing.Point(12, 73);
            this.txtFeedback.Multiline = true;
            this.txtFeedback.Name = "txtFeedback";
            this.txtFeedback.Size = new System.Drawing.Size(776, 319);
            this.txtFeedback.TabIndex = 11;
            // 
            // btnSubmit
            // 
            this.btnSubmit.BackColor = System.Drawing.Color.Black;
            this.btnSubmit.FlatAppearance.BorderSize = 0;
            this.btnSubmit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSubmit.Font = new System.Drawing.Font("Segoe Print", 12F, System.Drawing.FontStyle.Bold);
            this.btnSubmit.ForeColor = System.Drawing.Color.White;
            this.btnSubmit.Location = new System.Drawing.Point(345, 398);
            this.btnSubmit.Name = "btnSubmit";
            this.btnSubmit.Size = new System.Drawing.Size(120, 40);
            this.btnSubmit.TabIndex = 12;
            this.btnSubmit.Text = "Submit";
            this.btnSubmit.UseVisualStyleBackColor = false;
            this.btnSubmit.Click += new System.EventHandler(this.btnSubmit_Click);
            // 
            // CustomerFeedback
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(234)))), ((int)(((byte)(206)))), ((int)(((byte)(170)))));
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnSubmit);
            this.Controls.Add(this.txtFeedback);
            this.Controls.Add(this.feedback);
            this.Controls.Add(this.viewCustomerMenuButton);
            this.Controls.Add(this.btnClose);
            this.Name = "CustomerFeedback";
            this.Text = "CustomerFeedback";
            this.Load += new System.EventHandler(this.CustomerFeedback_Load);
            ((System.ComponentModel.ISupportInitialize)(this.viewCustomerMenuButton)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.PictureBox viewCustomerMenuButton;
        private System.Windows.Forms.Label feedback;
        private System.Windows.Forms.TextBox txtFeedback;
        private System.Windows.Forms.Button btnSubmit;
    }
}