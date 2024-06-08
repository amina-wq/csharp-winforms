namespace IOOP_assignment
{
    partial class ViewOrdersForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ViewOrdersForm));
            this.lbl1 = new System.Windows.Forms.Label();
            this.DropDown = new System.Windows.Forms.Button();
            this.DropdownPanel = new System.Windows.Forms.Panel();
            this.btnProfile = new System.Windows.Forms.Button();
            this.btnViewOrder = new System.Windows.Forms.Button();
            this.btnInventory = new System.Windows.Forms.Button();
            this.btnDashboard = new System.Windows.Forms.Button();
            this.btnTb1 = new System.Windows.Forms.Button();
            this.btnTb2 = new System.Windows.Forms.Button();
            this.btnTb3 = new System.Windows.Forms.Button();
            this.btnTb4 = new System.Windows.Forms.Button();
            this.btnTb5 = new System.Windows.Forms.Button();
            this.btnTb6 = new System.Windows.Forms.Button();
            this.btnTb7 = new System.Windows.Forms.Button();
            this.btnTb8 = new System.Windows.Forms.Button();
            this.btnTb9 = new System.Windows.Forms.Button();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.DropdownPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // lbl1
            // 
            this.lbl1.AutoSize = true;
            this.lbl1.BackColor = System.Drawing.Color.Black;
            this.lbl1.Font = new System.Drawing.Font("Britannic Bold", 25.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl1.ForeColor = System.Drawing.Color.LightSalmon;
            this.lbl1.Location = new System.Drawing.Point(295, 29);
            this.lbl1.Name = "lbl1";
            this.lbl1.Size = new System.Drawing.Size(246, 48);
            this.lbl1.TabIndex = 0;
            this.lbl1.Text = "View Orders";
            this.lbl1.Click += new System.EventHandler(this.label1_Click);
            // 
            // DropDown
            // 
            this.DropDown.BackColor = System.Drawing.Color.Transparent;
            this.DropDown.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("DropDown.BackgroundImage")));
            this.DropDown.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.DropDown.Location = new System.Drawing.Point(43, 9);
            this.DropDown.Name = "DropDown";
            this.DropDown.Size = new System.Drawing.Size(61, 49);
            this.DropDown.TabIndex = 17;
            this.DropDown.UseVisualStyleBackColor = false;
            this.DropDown.Click += new System.EventHandler(this.DropDown_Click);
            // 
            // DropdownPanel
            // 
            this.DropdownPanel.BackColor = System.Drawing.Color.Transparent;
            this.DropdownPanel.Controls.Add(this.btnProfile);
            this.DropdownPanel.Controls.Add(this.btnViewOrder);
            this.DropdownPanel.Controls.Add(this.btnInventory);
            this.DropdownPanel.Controls.Add(this.btnDashboard);
            this.DropdownPanel.ForeColor = System.Drawing.SystemColors.Control;
            this.DropdownPanel.Location = new System.Drawing.Point(3, 64);
            this.DropdownPanel.Name = "DropdownPanel";
            this.DropdownPanel.Size = new System.Drawing.Size(171, 13);
            this.DropdownPanel.TabIndex = 18;
            this.DropdownPanel.Paint += new System.Windows.Forms.PaintEventHandler(this.DropdownPanel_Paint);
            // 
            // btnProfile
            // 
            this.btnProfile.BackColor = System.Drawing.Color.LemonChiffon;
            this.btnProfile.Font = new System.Drawing.Font("Cooper Black", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnProfile.ForeColor = System.Drawing.Color.Black;
            this.btnProfile.Location = new System.Drawing.Point(11, 237);
            this.btnProfile.Name = "btnProfile";
            this.btnProfile.Size = new System.Drawing.Size(146, 57);
            this.btnProfile.TabIndex = 22;
            this.btnProfile.Text = "Profile";
            this.btnProfile.UseVisualStyleBackColor = false;
            this.btnProfile.Click += new System.EventHandler(this.btnProfile_Click);
            // 
            // btnViewOrder
            // 
            this.btnViewOrder.BackColor = System.Drawing.Color.Tan;
            this.btnViewOrder.Font = new System.Drawing.Font("Cooper Black", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnViewOrder.ForeColor = System.Drawing.Color.Black;
            this.btnViewOrder.Location = new System.Drawing.Point(11, 91);
            this.btnViewOrder.Name = "btnViewOrder";
            this.btnViewOrder.Size = new System.Drawing.Size(146, 57);
            this.btnViewOrder.TabIndex = 21;
            this.btnViewOrder.Text = "View Orders";
            this.btnViewOrder.UseVisualStyleBackColor = false;
            this.btnViewOrder.Click += new System.EventHandler(this.btnViewOrder_Click);
            // 
            // btnInventory
            // 
            this.btnInventory.BackColor = System.Drawing.Color.LemonChiffon;
            this.btnInventory.Font = new System.Drawing.Font("Cooper Black", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnInventory.ForeColor = System.Drawing.Color.Black;
            this.btnInventory.Location = new System.Drawing.Point(11, 163);
            this.btnInventory.Name = "btnInventory";
            this.btnInventory.Size = new System.Drawing.Size(146, 57);
            this.btnInventory.TabIndex = 20;
            this.btnInventory.Text = "Inventory";
            this.btnInventory.UseVisualStyleBackColor = false;
            this.btnInventory.Click += new System.EventHandler(this.btnInventory_Click);
            // 
            // btnDashboard
            // 
            this.btnDashboard.BackColor = System.Drawing.Color.LemonChiffon;
            this.btnDashboard.Font = new System.Drawing.Font("Cooper Black", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDashboard.ForeColor = System.Drawing.Color.Black;
            this.btnDashboard.Location = new System.Drawing.Point(11, 18);
            this.btnDashboard.Name = "btnDashboard";
            this.btnDashboard.Size = new System.Drawing.Size(146, 57);
            this.btnDashboard.TabIndex = 19;
            this.btnDashboard.Text = "Dashboard";
            this.btnDashboard.UseVisualStyleBackColor = false;
            this.btnDashboard.Click += new System.EventHandler(this.btnDashboard_Click);
            // 
            // btnTb1
            // 
            this.btnTb1.BackColor = System.Drawing.Color.Sienna;
            this.btnTb1.Font = new System.Drawing.Font("Stencil", 10F);
            this.btnTb1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnTb1.Location = new System.Drawing.Point(166, 111);
            this.btnTb1.Name = "btnTb1";
            this.btnTb1.Size = new System.Drawing.Size(117, 83);
            this.btnTb1.TabIndex = 23;
            this.btnTb1.Text = "TABLE 1";
            this.btnTb1.UseVisualStyleBackColor = false;
            this.btnTb1.Click += new System.EventHandler(this.btnTb1_Click);
            // 
            // btnTb2
            // 
            this.btnTb2.BackColor = System.Drawing.Color.Sienna;
            this.btnTb2.Font = new System.Drawing.Font("Stencil", 10F);
            this.btnTb2.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnTb2.Location = new System.Drawing.Point(357, 111);
            this.btnTb2.Name = "btnTb2";
            this.btnTb2.Size = new System.Drawing.Size(117, 83);
            this.btnTb2.TabIndex = 24;
            this.btnTb2.Text = "TABLE 2";
            this.btnTb2.UseVisualStyleBackColor = false;
            // 
            // btnTb3
            // 
            this.btnTb3.BackColor = System.Drawing.Color.Sienna;
            this.btnTb3.Font = new System.Drawing.Font("Stencil", 10F);
            this.btnTb3.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnTb3.Location = new System.Drawing.Point(545, 111);
            this.btnTb3.Name = "btnTb3";
            this.btnTb3.Size = new System.Drawing.Size(117, 83);
            this.btnTb3.TabIndex = 25;
            this.btnTb3.Text = "TABLE 3";
            this.btnTb3.UseVisualStyleBackColor = false;
            // 
            // btnTb4
            // 
            this.btnTb4.BackColor = System.Drawing.Color.Sienna;
            this.btnTb4.Font = new System.Drawing.Font("Stencil", 10F);
            this.btnTb4.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btnTb4.Location = new System.Drawing.Point(166, 230);
            this.btnTb4.Name = "btnTb4";
            this.btnTb4.Size = new System.Drawing.Size(117, 83);
            this.btnTb4.TabIndex = 26;
            this.btnTb4.Text = "TABLE 4";
            this.btnTb4.UseVisualStyleBackColor = false;
            // 
            // btnTb5
            // 
            this.btnTb5.BackColor = System.Drawing.Color.Sienna;
            this.btnTb5.Font = new System.Drawing.Font("Stencil", 10F);
            this.btnTb5.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnTb5.Location = new System.Drawing.Point(357, 230);
            this.btnTb5.Name = "btnTb5";
            this.btnTb5.Size = new System.Drawing.Size(117, 83);
            this.btnTb5.TabIndex = 27;
            this.btnTb5.Text = "TABLE 5";
            this.btnTb5.UseVisualStyleBackColor = false;
            // 
            // btnTb6
            // 
            this.btnTb6.BackColor = System.Drawing.Color.Sienna;
            this.btnTb6.Font = new System.Drawing.Font("Stencil", 10F);
            this.btnTb6.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnTb6.Location = new System.Drawing.Point(545, 230);
            this.btnTb6.Name = "btnTb6";
            this.btnTb6.Size = new System.Drawing.Size(117, 83);
            this.btnTb6.TabIndex = 28;
            this.btnTb6.Text = "TABLE 6";
            this.btnTb6.UseVisualStyleBackColor = false;
            // 
            // btnTb7
            // 
            this.btnTb7.BackColor = System.Drawing.Color.Sienna;
            this.btnTb7.Font = new System.Drawing.Font("Stencil", 10F);
            this.btnTb7.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnTb7.Location = new System.Drawing.Point(166, 358);
            this.btnTb7.Name = "btnTb7";
            this.btnTb7.Size = new System.Drawing.Size(117, 83);
            this.btnTb7.TabIndex = 29;
            this.btnTb7.Text = "TABLE 7";
            this.btnTb7.UseVisualStyleBackColor = false;
            // 
            // btnTb8
            // 
            this.btnTb8.BackColor = System.Drawing.Color.Sienna;
            this.btnTb8.Font = new System.Drawing.Font("Stencil", 10F);
            this.btnTb8.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnTb8.Location = new System.Drawing.Point(357, 358);
            this.btnTb8.Name = "btnTb8";
            this.btnTb8.Size = new System.Drawing.Size(117, 83);
            this.btnTb8.TabIndex = 30;
            this.btnTb8.Text = "TABLE 8";
            this.btnTb8.UseVisualStyleBackColor = false;
            // 
            // btnTb9
            // 
            this.btnTb9.BackColor = System.Drawing.Color.Sienna;
            this.btnTb9.Font = new System.Drawing.Font("Stencil", 10F);
            this.btnTb9.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnTb9.Location = new System.Drawing.Point(545, 358);
            this.btnTb9.Name = "btnTb9";
            this.btnTb9.Size = new System.Drawing.Size(117, 83);
            this.btnTb9.TabIndex = 31;
            this.btnTb9.Text = "TABLE 9";
            this.btnTb9.UseVisualStyleBackColor = false;
            // 
            // timer1
            // 
            this.timer1.Interval = 20;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // ViewOrdersForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(845, 511);
            this.Controls.Add(this.btnTb9);
            this.Controls.Add(this.btnTb8);
            this.Controls.Add(this.btnTb7);
            this.Controls.Add(this.btnTb6);
            this.Controls.Add(this.btnTb5);
            this.Controls.Add(this.btnTb4);
            this.Controls.Add(this.btnTb3);
            this.Controls.Add(this.btnTb2);
            this.Controls.Add(this.btnTb1);
            this.Controls.Add(this.DropdownPanel);
            this.Controls.Add(this.DropDown);
            this.Controls.Add(this.lbl1);
            this.DoubleBuffered = true;
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "ViewOrdersForm";
            this.Text = "ViewOrdersForm";
            this.Load += new System.EventHandler(this.ViewOrdersForm_Load);
            this.DropdownPanel.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl1;
        private System.Windows.Forms.Button DropDown;
        private System.Windows.Forms.Panel DropdownPanel;
        private System.Windows.Forms.Button btnDashboard;
        private System.Windows.Forms.Button btnProfile;
        private System.Windows.Forms.Button btnViewOrder;
        private System.Windows.Forms.Button btnInventory;
        private System.Windows.Forms.Button btnTb1;
        private System.Windows.Forms.Button btnTb2;
        private System.Windows.Forms.Button btnTb3;
        private System.Windows.Forms.Button btnTb4;
        private System.Windows.Forms.Button btnTb5;
        private System.Windows.Forms.Button btnTb6;
        private System.Windows.Forms.Button btnTb7;
        private System.Windows.Forms.Button btnTb8;
        private System.Windows.Forms.Button btnTb9;
        private System.Windows.Forms.Timer timer1;
    }
}