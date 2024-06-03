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

namespace IOOP_assignment.Models
{
    internal class Administrator : User
    {
        public Administrator(Guid userID, string userName, string email, string password)
        : base(userID, userName, email, password, Role.Administrator)
        {
            
        }

        public static User EditUser(User user)
        {
            return user;
        }

        public static User AddUser(string userName, string email, string password, Role role)
        {
            return new User(Guid.NewGuid(), userName, email, password, role);
        }

        public void DeleteUser(string userID)
        {

        }

        

    }
}
