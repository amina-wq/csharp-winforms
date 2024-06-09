﻿using IOOP_assignment.Manager_Forms;
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
    public partial class LoginForm : System.Windows.Forms.Form
    {
        public LoginForm()
        {
            InitializeComponent();
        }

        private void btnManageCategory_Click(object sender, EventArgs e)
        {
            FrmCategory cg = new FrmCategory();
            this.Hide();
            cg.Show();

            var newForm = new FrmCategory();
            newForm.Show();
            this.Hide();

            

        }

        private void btnManageReserv_Click(object sender, EventArgs e)
        {
            FrmReservation cg = new FrmReservation();
            this.Hide();
            cg.Show();

            var nextForm = new FrmReservation();
            nextForm.Show();
            this.Hide();



        }

        private void btnViewProfile_Click(object sender, EventArgs e)
        {
            FrmViewProfile cg = new FrmViewProfile();
            this.Hide();
            cg.Show();
        }

        private void BtnLogout_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are you sure you want to Logout?", "Exit message", MessageBoxButtons.YesNo, MessageBoxIcon.Question)==DialogResult.Yes)
            {
                Application.Exit();
            }

        }
    }
}
