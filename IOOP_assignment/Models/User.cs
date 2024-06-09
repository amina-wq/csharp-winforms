using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace IOOP_assignment.Models
{
    public class User
    {
        public Guid UserID { get; set; }
        public string UserName { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
        public Role UserRole { get; set; }

        public User(Guid userID, string userName, string email, string password, Role role)
        {
            UserID = userID;
            UserName = userName;
            Email = email;
            Password = password;
            UserRole = role;
        }

        public static User FromDB(SqlDataReader rd)
        {
            return new User(
                userID: rd.GetGuid(0),
                userName: rd.GetString(1),
                email: rd.GetString(2),
                password: Encoding.UTF8.GetString(rd.GetSqlBytes(3).Buffer),
                role: RoleUtility.ToRole(rd.GetGuid(4).ToString())
            );
        }
    }
}
