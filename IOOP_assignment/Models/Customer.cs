﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IOOP_assignment.Models
{
    internal class Customer : User
    {
        public Customer(string userID, string userName, string email, string password) : base(userID, userName, email, password, Role.Customer)
        {
        }
    }
}
