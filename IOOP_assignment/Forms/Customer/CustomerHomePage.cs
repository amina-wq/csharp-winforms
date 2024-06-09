using IOOP_assignment.Components;
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

namespace IOOP_assignment.Forms
{
    public partial class CustomerHomePage : BorderlessForm
    {
        private Customer _customer;
        private CustomerNavBar _customerNavBar;

        public CustomerHomePage(Customer customer)
        {
            InitializeComponent();
            _customer = customer;
        }

        private void CustomerHomePage_Load(object sender, EventArgs e)
        {
            _customerNavBar = new CustomerNavBar(_customer);
            _customerNavBar.BackColor = Color.FromArgb(((int)(((byte)(234)))), ((int)(((byte)(206)))), ((int)(((byte)(170)))));
            _customerNavBar.Location = new Point(restarauntLogo.Location.X, restarauntLogo.Location.Y + restarauntLogo.Size.Height);
            _customerNavBar.Name = "customerNavBar";
            _customerNavBar.Size = new Size(restarauntLogo.Width, this.Height - (restarauntLogo.Location.Y + restarauntLogo.Size.Height) - 30);

            this.Controls.Add(_customerNavBar);
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
