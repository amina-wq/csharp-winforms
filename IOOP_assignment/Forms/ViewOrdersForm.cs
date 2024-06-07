using IOOP_assignment.Forms;
using IOOP_assignment.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace IOOP_assignment
{
    public partial class ViewOrdersForm : Form
    {
        private DropdownAnimator _dropdownAnimator;
        public ViewOrdersForm()
        {
            InitializeComponent();
            _dropdownAnimator = new DropdownAnimator(DropdownPanel, 300, 10);
        }
        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void ViewOrdersForm_Load(object sender, EventArgs e)
        {
            btnTb1.Tag = "1";
            btnTb2.Tag = "2";
            btnTb3.Tag = "3";
            btnTb4.Tag = "4";
            btnTb5.Tag = "5";
            btnTb6.Tag = "6";
            btnTb7.Tag = "7";
            btnTb8.Tag = "8";
            btnTb9.Tag = "9";

            btnTb1.Click += btnTable_Click;
            btnTb2.Click += btnTable_Click;
            btnTb3.Click += btnTable_Click;
            btnTb4.Click += btnTable_Click;
            btnTb5.Click += btnTable_Click;
            btnTb6.Click += btnTable_Click;
            btnTb7.Click += btnTable_Click;
            btnTb8.Click += btnTable_Click;
            btnTb9.Click += btnTable_Click;
        }
       
        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
           
        }

        private void DropDown_Click(object sender, EventArgs e)
        {
            _dropdownAnimator.Toggle();
        }

        private void DropdownPanel_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnDashboard_Click(object sender, EventArgs e)
        {
            ChefDashboard chefDashboard = new ChefDashboard();
            chefDashboard.Show();
            this.Close();
        }

        private void btnViewOrder_Click(object sender, EventArgs e)
        {
            MessageBox.Show("You're already in this page.");
        }

        private void btnInventory_Click(object sender, EventArgs e)
        {
            ManageInventoryForm manageInventoryForm = new ManageInventoryForm();
            manageInventoryForm.Show();
            this.Close();
        }

        private void btnProfile_Click(object sender, EventArgs e)
        {
           
        }

        private void btnTb1_Click(object sender, EventArgs e)
        {
           
        }
        private void btnTable_Click(object sender, EventArgs e)
        {
            Button clickedButton = sender as Button;
            string tableNumber = clickedButton.Tag.ToString();
            int rowNumber = int.Parse(tableNumber) - 1;

            OrderDetails orderDetailsForm = new OrderDetails(rowNumber);
            orderDetailsForm.SetTableNumber(tableNumber);
            orderDetailsForm.Show();
            this.Close();
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            ChefDashboard chefDashboard = new ChefDashboard();
            chefDashboard.Show();
            this.Close();
        }
    }
}
