using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data.SqlClient;
using System.Data.SqlTypes;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using IOOP_assignment.Models;

namespace IOOP_assignment.Models
{
    internal class Administrator : User
    {
        public Administrator(string userID, string userName, string email, string password)
            : base(userID, userName, email, password, Role.Administrator)
        {

        }

        public static User EditUser(User user)
        {
            return user;
        }

        public static User AddUser(string userName, string email, string password, Role role)
        {
            return new User("93bf2433-f4cf-450e-9cbc-0e853b098143", userName, email, password, role);
        }

        public void DeleteUser(string userID)
        {

        }

    }
}