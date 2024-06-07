namespace IOOP_assignment.Manager_Forms
{
    partial class FrmCategory
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
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnCategorySearch = new System.Windows.Forms.Button();
            this.btnCategoryDelete = new System.Windows.Forms.Button();
            this.btnCategoryEdit = new System.Windows.Forms.Button();
            this.btnCategoryAdd = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.txtboxCategoryName = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtboxPrice = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtboxItemName = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtboxCategoryID = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtboxItemID = new System.Windows.Forms.TextBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.Dropdown = new System.Windows.Forms.Button();
            this.Dropdownlist = new System.Windows.Forms.Panel();
            this.button9 = new System.Windows.Forms.Button();
            this.button8 = new System.Windows.Forms.Button();
            this.button7 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.panel1.SuspendLayout();
            this.Dropdownlist.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.btnCategorySearch);
            this.panel2.Controls.Add(this.btnCategoryDelete);
            this.panel2.Controls.Add(this.btnCategoryEdit);
            this.panel2.Controls.Add(this.btnCategoryAdd);
            this.panel2.Controls.Add(this.label6);
            this.panel2.Controls.Add(this.txtboxCategoryName);
            this.panel2.Controls.Add(this.label5);
            this.panel2.Controls.Add(this.txtboxPrice);
            this.panel2.Controls.Add(this.label4);
            this.panel2.Controls.Add(this.txtboxItemName);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Controls.Add(this.txtboxCategoryID);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.txtboxItemID);
            this.panel2.Location = new System.Drawing.Point(138, 344);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(833, 213);
            this.panel2.TabIndex = 1;
            // 
            // btnCategorySearch
            // 
            this.btnCategorySearch.Location = new System.Drawing.Point(559, 174);
            this.btnCategorySearch.Name = "btnCategorySearch";
            this.btnCategorySearch.Size = new System.Drawing.Size(126, 30);
            this.btnCategorySearch.TabIndex = 14;
            this.btnCategorySearch.Text = "Search";
            this.btnCategorySearch.UseVisualStyleBackColor = true;
            this.btnCategorySearch.Click += new System.EventHandler(this.button4_Click);
            // 
            // btnCategoryDelete
            // 
            this.btnCategoryDelete.Location = new System.Drawing.Point(427, 174);
            this.btnCategoryDelete.Name = "btnCategoryDelete";
            this.btnCategoryDelete.Size = new System.Drawing.Size(126, 30);
            this.btnCategoryDelete.TabIndex = 13;
            this.btnCategoryDelete.Text = "Delete";
            this.btnCategoryDelete.UseVisualStyleBackColor = true;
            this.btnCategoryDelete.Click += new System.EventHandler(this.button3_Click);
            // 
            // btnCategoryEdit
            // 
            this.btnCategoryEdit.Location = new System.Drawing.Point(295, 174);
            this.btnCategoryEdit.Name = "btnCategoryEdit";
            this.btnCategoryEdit.Size = new System.Drawing.Size(126, 30);
            this.btnCategoryEdit.TabIndex = 12;
            this.btnCategoryEdit.Text = "Edit";
            this.btnCategoryEdit.UseVisualStyleBackColor = true;
            this.btnCategoryEdit.Click += new System.EventHandler(this.button2_Click);
            // 
            // btnCategoryAdd
            // 
            this.btnCategoryAdd.Location = new System.Drawing.Point(163, 174);
            this.btnCategoryAdd.Name = "btnCategoryAdd";
            this.btnCategoryAdd.Size = new System.Drawing.Size(126, 30);
            this.btnCategoryAdd.TabIndex = 11;
            this.btnCategoryAdd.Text = "Add";
            this.btnCategoryAdd.UseVisualStyleBackColor = true;
            this.btnCategoryAdd.Click += new System.EventHandler(this.Button1_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(375, 66);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(105, 16);
            this.label6.TabIndex = 10;
            this.label6.Text = "Category Name:";
            // 
            // txtboxCategoryName
            // 
            this.txtboxCategoryName.Location = new System.Drawing.Point(486, 63);
            this.txtboxCategoryName.Name = "txtboxCategoryName";
            this.txtboxCategoryName.Size = new System.Drawing.Size(172, 22);
            this.txtboxCategoryName.TabIndex = 9;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(69, 106);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(59, 16);
            this.label5.TabIndex = 8;
            this.label5.Text = "Price ($):";
            // 
            // txtboxPrice
            // 
            this.txtboxPrice.Location = new System.Drawing.Point(134, 103);
            this.txtboxPrice.Name = "txtboxPrice";
            this.txtboxPrice.Size = new System.Drawing.Size(172, 22);
            this.txtboxPrice.TabIndex = 7;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(53, 72);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(75, 16);
            this.label4.TabIndex = 6;
            this.label4.Text = "Item Name:";
            // 
            // txtboxItemName
            // 
            this.txtboxItemName.Location = new System.Drawing.Point(134, 66);
            this.txtboxItemName.Name = "txtboxItemName";
            this.txtboxItemName.Size = new System.Drawing.Size(172, 22);
            this.txtboxItemName.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(399, 26);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(81, 16);
            this.label3.TabIndex = 4;
            this.label3.Text = "Category ID:";
            // 
            // txtboxCategoryID
            // 
            this.txtboxCategoryID.Location = new System.Drawing.Point(486, 23);
            this.txtboxCategoryID.Name = "txtboxCategoryID";
            this.txtboxCategoryID.Size = new System.Drawing.Size(172, 22);
            this.txtboxCategoryID.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(77, 31);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(51, 16);
            this.label2.TabIndex = 2;
            this.label2.Text = "Item ID:";
            // 
            // txtboxItemID
            // 
            this.txtboxItemID.Location = new System.Drawing.Point(134, 28);
            this.txtboxItemID.Name = "txtboxItemID";
            this.txtboxItemID.Size = new System.Drawing.Size(172, 22);
            this.txtboxItemID.TabIndex = 0;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(16, 21);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(799, 286);
            this.dataGridView1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(22, 2);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(106, 16);
            this.label1.TabIndex = 1;
            this.label1.Text = "Data of Products";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.dataGridView1);
            this.panel1.Location = new System.Drawing.Point(138, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(832, 329);
            this.panel1.TabIndex = 2;
            // 
            // Dropdown
            // 
            this.Dropdown.Location = new System.Drawing.Point(34, 12);
            this.Dropdown.Name = "Dropdown";
            this.Dropdown.Size = new System.Drawing.Size(75, 48);
            this.Dropdown.TabIndex = 3;
            this.Dropdown.Text = "------------";
            this.Dropdown.UseVisualStyleBackColor = true;
            this.Dropdown.Click += new System.EventHandler(this.Dropdown_Click);
            // 
            // Dropdownlist
            // 
            this.Dropdownlist.BackColor = System.Drawing.Color.Transparent;
            this.Dropdownlist.Controls.Add(this.button9);
            this.Dropdownlist.Controls.Add(this.button8);
            this.Dropdownlist.Controls.Add(this.button7);
            this.Dropdownlist.Controls.Add(this.button6);
            this.Dropdownlist.Location = new System.Drawing.Point(12, 75);
            this.Dropdownlist.Name = "Dropdownlist";
            this.Dropdownlist.Size = new System.Drawing.Size(120, 10);
            this.Dropdownlist.TabIndex = 4;
            this.Dropdownlist.Paint += new System.Windows.Forms.PaintEventHandler(this.Dropdownlist_Paint);
            // 
            // button9
            // 
            this.button9.Location = new System.Drawing.Point(3, 175);
            this.button9.Name = "button9";
            this.button9.Size = new System.Drawing.Size(114, 48);
            this.button9.TabIndex = 7;
            this.button9.Text = "View Profile";
            this.button9.UseVisualStyleBackColor = true;
            // 
            // button8
            // 
            this.button8.Location = new System.Drawing.Point(6, 121);
            this.button8.Name = "button8";
            this.button8.Size = new System.Drawing.Size(114, 48);
            this.button8.TabIndex = 6;
            this.button8.Text = "Reservation";
            this.button8.UseVisualStyleBackColor = true;
            // 
            // button7
            // 
            this.button7.Location = new System.Drawing.Point(3, 67);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(114, 48);
            this.button7.TabIndex = 5;
            this.button7.Text = "Category";
            this.button7.UseVisualStyleBackColor = true;
            // 
            // button6
            // 
            this.button6.Location = new System.Drawing.Point(3, 13);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(114, 48);
            this.button6.TabIndex = 4;
            this.button6.Text = "Dashboard";
            this.button6.UseVisualStyleBackColor = true;
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // FrmCategory
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(982, 564);
            this.Controls.Add(this.Dropdownlist);
            this.Controls.Add(this.Dropdown);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel2);
            this.Name = "FrmCategory";
            this.Text = "Category";
            this.Load += new System.EventHandler(this.FrmCategory_Load);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.Dropdownlist.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtboxPrice;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtboxItemName;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtboxCategoryID;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtboxItemID;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtboxCategoryName;
        private System.Windows.Forms.Button btnCategorySearch;
        private System.Windows.Forms.Button btnCategoryDelete;
        private System.Windows.Forms.Button btnCategoryEdit;
        private System.Windows.Forms.Button btnCategoryAdd;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button Dropdown;
        private System.Windows.Forms.Panel Dropdownlist;
        private System.Windows.Forms.Button button9;
        private System.Windows.Forms.Button button8;
        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Timer timer1;
    }
}