namespace IOOP_assignment.Manager_Forms
{
    partial class FrmReservation
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmReservation));
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.label2 = new System.Windows.Forms.Label();
            this.txtboxReservID = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtboxCusID = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.cmboxReservType = new System.Windows.Forms.ComboBox();
            this.DTPBookingDate = new System.Windows.Forms.DateTimePicker();
            this.label4 = new System.Windows.Forms.Label();
            this.btnReservAdd = new System.Windows.Forms.Button();
            this.btnReservEdit = new System.Windows.Forms.Button();
            this.btnReservDelete = new System.Windows.Forms.Button();
            this.cmboxReservDetails = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.btnReservSearch = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnBack = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridView1.DefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridView1.Location = new System.Drawing.Point(280, 22);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(721, 269);
            this.dataGridView1.TabIndex = 0;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Sylfaen", 7.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(232, 321);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(106, 18);
            this.label2.TabIndex = 4;
            this.label2.Text = "Reservation ID:";
            // 
            // txtboxReservID
            // 
            this.txtboxReservID.Location = new System.Drawing.Point(387, 319);
            this.txtboxReservID.Name = "txtboxReservID";
            this.txtboxReservID.Size = new System.Drawing.Size(172, 22);
            this.txtboxReservID.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Sylfaen", 7.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(508, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(92, 18);
            this.label1.TabIndex = 6;
            this.label1.Text = "Customer ID:";
            // 
            // txtboxCusID
            // 
            this.txtboxCusID.Location = new System.Drawing.Point(764, 316);
            this.txtboxCusID.Name = "txtboxCusID";
            this.txtboxCusID.Size = new System.Drawing.Size(172, 22);
            this.txtboxCusID.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Sylfaen", 7.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(216, 367);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(122, 18);
            this.label3.TabIndex = 7;
            this.label3.Text = "Reservation Type:";
            // 
            // cmboxReservType
            // 
            this.cmboxReservType.FormattingEnabled = true;
            this.cmboxReservType.Items.AddRange(new object[] {
            "Indoor",
            "Outdoor"});
            this.cmboxReservType.Location = new System.Drawing.Point(360, 365);
            this.cmboxReservType.Name = "cmboxReservType";
            this.cmboxReservType.Size = new System.Drawing.Size(199, 24);
            this.cmboxReservType.TabIndex = 8;
            // 
            // DTPBookingDate
            // 
            this.DTPBookingDate.Location = new System.Drawing.Point(694, 367);
            this.DTPBookingDate.Name = "DTPBookingDate";
            this.DTPBookingDate.Size = new System.Drawing.Size(242, 22);
            this.DTPBookingDate.TabIndex = 9;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Sylfaen", 7.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(441, 74);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(97, 18);
            this.label4.TabIndex = 10;
            this.label4.Text = "Booking Date:";
            // 
            // btnReservAdd
            // 
            this.btnReservAdd.BackColor = System.Drawing.Color.BlanchedAlmond;
            this.btnReservAdd.Font = new System.Drawing.Font("Sylfaen", 7.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnReservAdd.ForeColor = System.Drawing.Color.Black;
            this.btnReservAdd.Location = new System.Drawing.Point(140, 22);
            this.btnReservAdd.Name = "btnReservAdd";
            this.btnReservAdd.Size = new System.Drawing.Size(134, 55);
            this.btnReservAdd.TabIndex = 11;
            this.btnReservAdd.Text = "Add";
            this.btnReservAdd.UseVisualStyleBackColor = false;
            this.btnReservAdd.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnReservEdit
            // 
            this.btnReservEdit.BackColor = System.Drawing.Color.BlanchedAlmond;
            this.btnReservEdit.Font = new System.Drawing.Font("Sylfaen", 7.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnReservEdit.ForeColor = System.Drawing.Color.Black;
            this.btnReservEdit.Location = new System.Drawing.Point(140, 92);
            this.btnReservEdit.Name = "btnReservEdit";
            this.btnReservEdit.Size = new System.Drawing.Size(134, 55);
            this.btnReservEdit.TabIndex = 12;
            this.btnReservEdit.Text = "Edit";
            this.btnReservEdit.UseVisualStyleBackColor = false;
            this.btnReservEdit.Click += new System.EventHandler(this.button2_Click);
            // 
            // btnReservDelete
            // 
            this.btnReservDelete.BackColor = System.Drawing.Color.BlanchedAlmond;
            this.btnReservDelete.Font = new System.Drawing.Font("Sylfaen", 7.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnReservDelete.ForeColor = System.Drawing.Color.Black;
            this.btnReservDelete.Location = new System.Drawing.Point(140, 162);
            this.btnReservDelete.Name = "btnReservDelete";
            this.btnReservDelete.Size = new System.Drawing.Size(134, 55);
            this.btnReservDelete.TabIndex = 13;
            this.btnReservDelete.Text = "Delete";
            this.btnReservDelete.UseVisualStyleBackColor = false;
            this.btnReservDelete.Click += new System.EventHandler(this.button3_Click);
            // 
            // cmboxReservDetails
            // 
            this.cmboxReservDetails.FormattingEnabled = true;
            this.cmboxReservDetails.Items.AddRange(new object[] {
            "Table 1 ",
            "Table 2",
            "Table 3",
            "Table 4",
            "Table 5",
            "Table 6",
            "Table 7",
            "Table 8",
            "Table 9"});
            this.cmboxReservDetails.Location = new System.Drawing.Point(360, 408);
            this.cmboxReservDetails.Name = "cmboxReservDetails";
            this.cmboxReservDetails.Size = new System.Drawing.Size(199, 24);
            this.cmboxReservDetails.TabIndex = 15;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Sylfaen", 7.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(206, 410);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(132, 18);
            this.label5.TabIndex = 14;
            this.label5.Text = "Reservation Details:";
            // 
            // btnReservSearch
            // 
            this.btnReservSearch.BackColor = System.Drawing.Color.BlanchedAlmond;
            this.btnReservSearch.Font = new System.Drawing.Font("Sylfaen", 7.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnReservSearch.ForeColor = System.Drawing.Color.Black;
            this.btnReservSearch.Location = new System.Drawing.Point(140, 236);
            this.btnReservSearch.Name = "btnReservSearch";
            this.btnReservSearch.Size = new System.Drawing.Size(134, 55);
            this.btnReservSearch.TabIndex = 16;
            this.btnReservSearch.Text = "Search";
            this.btnReservSearch.UseVisualStyleBackColor = false;
            this.btnReservSearch.Click += new System.EventHandler(this.button4_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Sylfaen", 7.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(277, 1);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(82, 18);
            this.label6.TabIndex = 17;
            this.label6.Text = "Reservation";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(140, 297);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(861, 221);
            this.panel1.TabIndex = 18;
            // 
            // btnBack
            // 
            this.btnBack.BackColor = System.Drawing.Color.BlanchedAlmond;
            this.btnBack.Font = new System.Drawing.Font("Sylfaen", 7.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBack.ForeColor = System.Drawing.Color.Black;
            this.btnBack.Location = new System.Drawing.Point(0, 486);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(134, 46);
            this.btnBack.TabIndex = 19;
            this.btnBack.Text = "Back";
            this.btnBack.UseVisualStyleBackColor = false;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // FrmReservation
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(1016, 544);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.btnReservSearch);
            this.Controls.Add(this.cmboxReservDetails);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.btnReservDelete);
            this.Controls.Add(this.btnReservEdit);
            this.Controls.Add(this.btnReservAdd);
            this.Controls.Add(this.DTPBookingDate);
            this.Controls.Add(this.cmboxReservType);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtboxCusID);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtboxReservID);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.panel1);
            this.ForeColor = System.Drawing.Color.White;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmReservation";
            this.Text = "Reservation";
            this.Load += new System.EventHandler(this.FrmReservation_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtboxReservID;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtboxCusID;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cmboxReservType;
        private System.Windows.Forms.DateTimePicker DTPBookingDate;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnReservAdd;
        private System.Windows.Forms.Button btnReservEdit;
        private System.Windows.Forms.Button btnReservDelete;
        private System.Windows.Forms.ComboBox cmboxReservDetails;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btnReservSearch;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnBack;
    }
}