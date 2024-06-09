using IOOP_assignment.Models;
using System;
using System.Windows.Forms;

namespace IOOP_assignment.Components
{
    public partial class CustomerNavBar : UserControl
    {
        private Customer _customer;

        public CustomerNavBar(Customer customer)
        {
            InitializeComponent();
            _customer = customer;
        }

        private void homeButton_Click(object sender, EventArgs e)
        {
            if (!(this.ParentForm is Forms.CustomerHomePage))
            {

                Forms.CustomerHomePage customerMenuForm = new Forms.CustomerHomePage(_customer);
                customerMenuForm.Show();
                this.ParentForm.Close();
            }
        }

        private void viewOrdersButton_Click(object sender, EventArgs e)
        {
            if(!(this.ParentForm is Forms.CustomerOrders))
            {
                Forms.CustomerOrders customerOrderForm = new Forms.CustomerOrders(_customer);
                customerOrderForm.Show();
                this.ParentForm.Close();
            }
        }

        private void menuButton_Click(object sender, EventArgs e)
        {
            if (!(this.ParentForm is Forms.CustomerMenu))
            {

                Forms.CustomerMenu customerMenuForm = new Forms.CustomerMenu(_customer);
                customerMenuForm.Show();
                this.ParentForm.Close();
            }
        }

        private void viewReservationButton_Click(object sender, EventArgs e)
        {
            if (!(this.ParentForm is Forms.CustomerReservations))
            {

                Forms.CustomerReservations customerMenuForm = new Forms.CustomerReservations(_customer);
                customerMenuForm.Show();
                this.ParentForm.Close();
            }
        }

        private void viewFeedbackButton_Click(object sender, EventArgs e)
        {
            if (!(this.ParentForm is Forms.CustomerFeedback))
            {

                Forms.CustomerFeedback customerMenuForm = new Forms.CustomerFeedback(_customer);
                customerMenuForm.Show();
                this.ParentForm.Close();
            }
        }

        private void viewProfileButton_Click(object sender, EventArgs e)
        {
            if (!(this.ParentForm is Forms.UpdateProfile))
            {

                Forms.UpdateProfile customerMenuForm = new Forms.UpdateProfile(_customer);
                customerMenuForm.Show();
                this.ParentForm.Close();
            }
        }
    }
}
