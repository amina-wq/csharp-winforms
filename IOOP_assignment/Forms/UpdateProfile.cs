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
    internal partial class UpdateProfile : BorderlessForm
    {
        // Remove after merging
        static List<Role> NavBarEnabledRoles = new List<Role>() { Role.Customer };

        public Models.User UserData { get; set; }
        public UserRepository _userRepository;
        private CustomerNavBar _customerNavBar;

        public UpdateProfile(Models.User user)
        {
            DBManager database = new DBManager(ConfigurationManager.ConnectionStrings["ioop"].ToString());
            _userRepository = new UserRepository(database);
            UserData = user;
            InitializeComponent();
            nameTextBox.Text = UserData.UserName;
            emailTextBox.Text = UserData.Email;
        }

        private void UpdateProfile_Load(object sender, EventArgs e)
        {
            if (!NavBarEnabledRoles.Contains(UserData.UserRole))
            {
                viewMenuButton.Hide();
            }

            if (UserData.UserRole == Role.Customer)
            {
                _customerNavBar = new CustomerNavBar(UserData as Customer);
                _customerNavBar.BackColor = Color.FromArgb(((int)(((byte)(234)))), ((int)(((byte)(206)))), ((int)(((byte)(170)))));
                _customerNavBar.Location = new Point(12, viewMenuButton.Location.Y + viewMenuButton.Size.Height);
                _customerNavBar.Name = "customerNavBar";
                _customerNavBar.Size = new Size(0, 591);

                this.Controls.Add(_customerNavBar);
            }

        }

        private void submitButton_Click(object sender, EventArgs e)
        {
            try
            {
                _userRepository.UpdateProfile(userId: UserData.UserID, newName: nameTextBox.Text, newEmail: emailTextBox.Text, newPassword: passwordTextBox.Text);
                MessageBox.Show("Your Profile changed successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch
            {
                MessageBox.Show("Incorrect Data!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            
        }

        private void viewMenuButton_Click(object sender, EventArgs e)
        {
            if (UserData.UserRole == Role.Customer)
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

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
