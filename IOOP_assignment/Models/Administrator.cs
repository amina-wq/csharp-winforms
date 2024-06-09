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
    }
}