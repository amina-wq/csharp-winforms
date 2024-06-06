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
    internal partial class LoginForm : Form
    {
        public User UserData { get; set; }
        public UserRepository _userRepository;

        public LoginForm()
        {
            DBManager database = new DBManager(ConfigurationManager.ConnectionStrings["ioop"].ToString());
            _userRepository = new UserRepository(database);
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            UserData = _userRepository.Login(email: emailTextBox.Text, password: passwordTextBox.Text);
            Forms.CustomerOrders customerOrderForm = new Forms.CustomerOrders(UserData as Customer);
            // Forms.CustomerMenu customerMenuForm = new Forms.CustomerMenu(UserData as Customer);
            customerOrderForm.Show();
        }
    }
}
