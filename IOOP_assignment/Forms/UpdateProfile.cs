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
    internal partial class UpdateProfile : Form
    {
        public User UserData { get; set; }
        public UserRepository _userRepository;

        public UpdateProfile(User user)
        {
            DBManager database = new DBManager(ConfigurationManager.ConnectionStrings["ioop"].ToString());
            _userRepository = new UserRepository(database);
            UserData = user;
            InitializeComponent();
            nameTextBox.Text = UserData.UserName;
            emailTextBox.Text = UserData.Email;
        }

        private void submitButton_Click(object sender, EventArgs e)
        {
            _userRepository.UpdateProfile(userId: UserData.UserID, newName: nameTextBox.Text, newEmail: emailTextBox.Text, newPassword: passwordTextBox.Text);
        }
    }
}
