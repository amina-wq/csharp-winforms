﻿using IOOP_assignment.Forms;
using IOOP_assignment.Manager_Forms;
using IOOP_assignment.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace IOOP_assignment
{
    internal static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            // Administrator.AddUser("abc", "abc@gmail.com", "abc", Role.Manager);
            // User user = User.Login("abc@gmail.com", "abc");
            // Console.WriteLine(user.UserID);
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new LoginForm());
        }
    }
}
