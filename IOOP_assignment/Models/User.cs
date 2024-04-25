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
    internal class User
    {
        public string UserID { get; set; }
        public string UserName { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
        public Role UserRole { get; set; }

        public User(string userID, string userName, string email, string password, Role role)
        {
            UserID = userID;
            UserName = userName;
            Email = email;
            Password = password;
            UserRole = role;
        }

        private static User FromDB(SqlDataReader rd)
        {
            return new User(
                userID: rd.GetGuid(0).ToString(),
                userName: rd.GetString(1),
                email: rd.GetString(2),
                password: Encoding.UTF8.GetString(rd.GetSqlBytes(3).Buffer),
                role: RoleUtility.ToRole(rd.GetGuid(4).ToString())
            );
        }

        public static List<User> GetUsers()
        {
            SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["ioop"].ToString());
            con.Open();

            SqlCommand cmd = new SqlCommand("select * from [dbo].[User]", con);

            SqlDataReader rd = cmd.ExecuteReader();

            List<User> users = new List<User>();
            
            while (rd.Read())
            {
                users.Add(User.FromDB(rd));
            }
            
            con.Close();

            return users;
        }

        public virtual void UpdateProfile()
        {

        }

        public static User Login(string email, string password)
        {
            SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["ioop"].ToString());
            con.Open();

            SqlCommand cmd = new SqlCommand("Select * from [dbo].[User] where email = @email and password = @password", con);
            cmd.Parameters.AddWithValue("@email", email);

            using (var md5Hash = MD5.Create())
            {
                var passwordBytes = Encoding.UTF8.GetBytes(password);
                var hashedPasswordBytes = md5Hash.ComputeHash(passwordBytes);
                cmd.Parameters.AddWithValue("@password", hashedPasswordBytes);
            }

            SqlDataReader rd = cmd.ExecuteReader();

            rd.Read();
            if (!rd.HasRows)
            {
                throw new Exception("Invalid email or password");
            }

            User user = User.FromDB(rd);

            con.Close();

            switch (user.UserRole)
            {
                case Role.Administrator:
                    return new Administrator(user.UserID, user.UserName, user.Email, user.Password);
                case Role.Manager:
                    return new Manager(user.UserID, user.UserName, user.Email, user.Password);
                case Role.Chef:
                    return new Chef(user.UserID, user.UserName, user.Email, user.Password);
                case Role.Customer:
                    return new Customer(user.UserID, user.UserName, user.Email, user.Password);
                default:
                    throw new InvalidOperationException("Invalid user role.");
            }
        }
    }
}
