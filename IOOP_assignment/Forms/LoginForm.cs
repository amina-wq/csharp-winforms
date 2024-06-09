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
    internal partial class LoginForm : BorderlessForm
    {
        public User UserData { get; set; }
        public UserRepository _userRepository;

        public LoginForm()
        {
            DBManager database = new DBManager(ConfigurationManager.ConnectionStrings["ioop"].ToString());
            _userRepository = new UserRepository(database);
            InitializeComponent();
        }

        private void loginButton_Click(object sender, EventArgs e)
        {
            try
            {
                UserData = _userRepository.Login(email: emailTextBox.Text, password: passwordTextBox.Text);
                CustomerHomePage customerHomePage = new CustomerHomePage(UserData as Customer);
                customerHomePage.Show();
            }
            catch
            {
                MessageBox.Show("Invalid Email or Password. Please try again.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
