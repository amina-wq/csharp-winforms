using IOOP_assignment.Models;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace IOOP_assignment.Core
{
    internal class UserRepository
    {

        private readonly DBManager _database;

        public UserRepository(DBManager database)
        {
            _database = database;
        }

        public List<User> GetUsers()
        {
            List<User> users = new List<User>();
            
            using (SqlConnection con = _database.GetConnection())
            {
                con.Open();

                SqlCommand cmd = new SqlCommand("select * from [dbo].[User]", con);

                using (SqlDataReader rd = cmd.ExecuteReader())
                {
                    while (rd.Read())
                    {
                        users.Add(User.FromDB(rd));
                    }
                }
            }

            return users;
        }

        public void UpdateProfile(Guid userId, string newName, string newEmail, string newPassword)
        {
            using (SqlConnection con = _database.GetConnection())
            {
                con.Open();

                SqlCommand cmd = new SqlCommand("update [dbo].[User] set UserName = @newName, Email = @newEmail", con);
                cmd.Parameters.AddWithValue("@newName", newName);
                cmd.Parameters.AddWithValue("@newEmail", newEmail);

                if (!string.IsNullOrEmpty(newPassword))
                {
                    using (var md5Hash = MD5.Create())
                    {
                        var hashedPasswordBytes = md5Hash.ComputeHash(Encoding.UTF8.GetBytes(newPassword));
                        cmd.CommandText += ", Password = @newPassword";
                        cmd.Parameters.AddWithValue("@newPassword", hashedPasswordBytes);
                    }
                }

                cmd.CommandText += " WHERE UserID = @UserID";
                cmd.Parameters.AddWithValue("@UserID", userId);

                int number = cmd.ExecuteNonQuery();
            }
        }

        public User Login(string email, string password)
        {
            User user = null;

            using (SqlConnection con = _database.GetConnection())
            {
                con.Open();

                SqlCommand cmd = new SqlCommand("Select * from [dbo].[User] where email = @email and password = @password", con);
                cmd.Parameters.AddWithValue("@email", email);

                using (var md5Hash = MD5.Create())
                {
                    var passwordBytes = Encoding.UTF8.GetBytes(password);
                    var hashedPasswordBytes = md5Hash.ComputeHash(passwordBytes);
                    cmd.Parameters.AddWithValue("@password", hashedPasswordBytes);
                }

                using (SqlDataReader rd = cmd.ExecuteReader())
                {
                    rd.Read();
                    if (!rd.HasRows)
                    {
                        throw new Exception("Invalid email or password");
                    }
                    user = User.FromDB(rd);
                }
            }

            if (user == null)
            {
                throw new Exception("Invalid email or password");
            }

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

        public User AddUser(string userName, string email, string password, Role role)
        {
            Guid userId = Guid.NewGuid();

            using (SqlConnection con = _database.GetConnection())
            {
                con.Open();

                using (var md5Hash = MD5.Create())
                {
                    var passwordBytes = Encoding.UTF8.GetBytes(password);
                    var hashedPasswordBytes = md5Hash.ComputeHash(passwordBytes);

                    SqlCommand cmd = new SqlCommand("insert into [dbo].[User] (UserID, UserName, Email, Password, RoleID) values (@UserID, @UserName, @Email, @Password, @Role)", con);
                    cmd.Parameters.AddWithValue("@UserID", userId);
                    cmd.Parameters.AddWithValue("@UserName", userName);
                    cmd.Parameters.AddWithValue("@Email", email);
                    cmd.Parameters.AddWithValue("@Password", hashedPasswordBytes);
                    cmd.Parameters.AddWithValue("@Role", RoleUtility.ToUUID(role));

                    int number = cmd.ExecuteNonQuery();
                }
            }

            return new User(userId, userName, email, password, role);
        }
    }
}
