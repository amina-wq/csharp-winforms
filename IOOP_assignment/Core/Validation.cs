using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace IOOP_assignment.Core
{
    public static class PasswordHasher
    {
        public static byte[] HashPassword(string password)
        {
            using (MD5 md5 = MD5.Create())
            {
                return md5.ComputeHash(Encoding.UTF8.GetBytes(password));
            }
        }
    }

    public static class PasswordValidator
    {
        public static bool IsPasswordComplex(string password)
        {
            // Password must contain at least 1 uppercase letter, 1 number, and 1 symbol
            return Regex.IsMatch(password, @"^(?=.*[A-Z])(?=.*\d)(?=.*[^\da-zA-Z]).{8,}$");
        }
    }
    public static class EmailValidator
    {
        public static bool IsValidEmail(string email)
        {
            return email.Contains("@");
        }
    }
}
