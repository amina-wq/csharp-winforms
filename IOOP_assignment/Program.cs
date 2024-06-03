using IOOP_assignment.Core;
using IOOP_assignment.Forms;
using IOOP_assignment.Models;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace IOOP_assignment
{
    internal static class Program
    {
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            // Development code
            DBManager database = new DBManager(ConfigurationManager.ConnectionStrings["ioop"].ToString());
            UserRepository userRepository = new UserRepository(database);
            User user = userRepository.AddUser("admin", "admin@gmail.com", "admin", Role.Customer);
            Application.Run(new CustomerMenu(new Customer(user.UserID, user.UserName, user.Email, user.Password)));
        }
    }
}
