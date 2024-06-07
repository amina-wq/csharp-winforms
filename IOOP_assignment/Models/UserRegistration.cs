using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IOOP_assignment.Models
{
    public class UserRegistration
    {
        private Dictionary<string, string> userData = new Dictionary<string, string>();

        public void RegisterUsername(string username)
        {
            if (string.IsNullOrEmpty(username))
            {
                throw new ArgumentException("Username cannot be empty.");
            }
            userData["Username"] = username;
        }

        public void RegisterPassword(string password)
        {
            if (string.IsNullOrEmpty(password))
            {
                throw new ArgumentException("Password cannot be empty.");
            }
            // Implement hashing logic here for secure password storage (e.g., using SHA256)
            userData["Password"] = password; // Placeholder for hashed password
        }

        public void RegisterContact(string contact)
        {
            userData["Contact"] = contact;
        }

        public void RegisterEmail(string email)
        {
            if (string.IsNullOrEmpty(email))
            {
                throw new ArgumentException("Email cannot be empty.");
            }
            // Implement email validation logic here (e.g., check for @ and .)
            userData["Email"] = email;
        }

        public Dictionary<string, string> GetUserData()
        {
            return new Dictionary<string, string>(userData); // Return a copy to avoid modifying original data
        }

        public void SaveData(string filePath)
        {
            string dataToSave = JsonConvert.SerializeObject(userData);

            try
            {
                File.WriteAllText(filePath, dataToSave);
            }
            catch (Exception ex)
            {
                throw new Exception("Error saving data: " + ex.Message); // Re-throw for handling in calling code
            }
        }
    }

    public class JsonConvert
    {
        public static string SerializeObject(Dictionary<string, string> userData)
        {
            throw new NotImplementedException();
        }
    }
}
