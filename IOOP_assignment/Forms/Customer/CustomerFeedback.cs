using IOOP_assignment.Components;
using IOOP_assignment.Core;
using IOOP_assignment.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace IOOP_assignment.Forms
{
    public partial class CustomerFeedback : BorderlessForm
    {
        private Customer _customer;
        private CustomerNavBar _customerNavBar;
        private FeedbackRepository _feedbackRepository;

        public CustomerFeedback(Customer customer)
        {
            InitializeComponent();
            _customer = customer;
            DBManager database = new DBManager(ConfigurationManager.ConnectionStrings["ioop"].ToString());
            _feedbackRepository = new FeedbackRepository(database);
        }

        private void CustomerFeedback_Load(object sender, EventArgs e)
        {
            _customerNavBar = new CustomerNavBar(_customer);
            _customerNavBar.BackColor = Color.FromArgb(((int)(((byte)(234)))), ((int)(((byte)(206)))), ((int)(((byte)(170)))));
            _customerNavBar.Location = new Point(12, viewCustomerMenuButton.Location.Y + viewCustomerMenuButton.Size.Height);
            _customerNavBar.Name = "customerNavBar";
            _customerNavBar.Size = new Size(0, 591);

            this.Controls.Add(_customerNavBar);
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtFeedback.Text))
            {
                MessageBox.Show("Please enter your feedback before submitting.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            Feedback feedback = new Feedback
            {
                FeedbackID = Guid.NewGuid(),
                Customer = _customer,
                FeedbackMessage = txtFeedback.Text,
                FeedbackDateTime = DateTime.Now
            };

            _feedbackRepository.AddFeedback(feedback);
            MessageBox.Show("Thank you for your feedback!", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
            txtFeedback.Clear();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void viewCustomerMenuButton_Click(object sender, EventArgs e)
        {
            if (_customerNavBar.Width == 0)
            {
                _customerNavBar.BringToFront();
                _customerNavBar.Width = 150;
            }
            else
            {
                _customerNavBar.Width = 0;
            }
        }
    }
}
