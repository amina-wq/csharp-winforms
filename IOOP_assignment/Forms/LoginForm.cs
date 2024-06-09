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
        public Models.User UserData { get; set; }
        public UserRepository _userRepository;
        private static LoginForm instance;
        private AdminDashboard adminDashboard;

        public LoginForm()
        {
            DBManager database = new DBManager(ConfigurationManager.ConnectionStrings["ioop"].ToString());
            _userRepository = new UserRepository(database);
            InitializeComponent();
        }


        public static LoginForm Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = new LoginForm();
                }

                return instance;
            }
        }

        private void loginButton_Click(object sender, EventArgs e)
        {
            try
            {
                UserData = _userRepository.Login(email: emailTextBox.Text, password: passwordTextBox.Text);
                switch (UserData.UserRole)
                {
                    case Role.Customer:
                        CustomerHomePage customerHomePage = new CustomerHomePage(UserData as Customer);
                        customerHomePage.Show();
                        this.Hide();
                        break;
                    case Role.Administrator:
                        this.Hide();
                        AdminDashboard.Instance.Show();
                        break;
                    case Role.Chef:
                        // Handle Chef case
                        break;
                    case Role.Manager:
                        // Handle Manager case
                        break;
                }
            }
            catch
            {
                MessageBox.Show("Invalid Email or Password. Please try again.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void CloseLoginFormAndShowAdminDashboard()
        {
            this.Close();
            adminDashboard.Show();
        }


        private void btnClose_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}



